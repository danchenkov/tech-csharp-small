using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Schedule.Models;

namespace Schedule.Controllers
{

    public class EpisodesController : Controller
    {
        private const string logPath = @"data/episodes.json";

        [HttpGet]
        public IActionResult Index([FromHeader(Name = "Accept")]string format)
        {
            if (format.Contains("application/json")) {
                var logFile = System.IO.File.OpenRead(logPath);
                var logReader = new System.IO.StreamReader(logFile);
                JsonSerializer serializer = new JsonSerializer();
                Episodes episodes = (Episodes)serializer.Deserialize(logReader, typeof(Episodes));
                return Json(episodes.episodes);
            }
            return (IActionResult)View();
        }

        [HttpPost]
        public IActionResult UpdateAll([FromBody] Episodes episodes)
        {
            var logFile = System.IO.File.Create(logPath);
            var logWriter = new System.IO.StreamWriter(logFile);
            logWriter.WriteLine(JsonConvert.SerializeObject(episodes));
            logWriter.Close();
            return Content("Ok", "text/html");
        }
    }
}
