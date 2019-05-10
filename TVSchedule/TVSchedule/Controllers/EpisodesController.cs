using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TVSchedule.Model;

namespace TVSchedule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpisodesController : ControllerBase
    {
        // GET api/episodes
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var episodes = new Episode();
            // Substitue this with
            episodes = 
            return episodes;
        }
        
        // GET api/episodes/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/episodes
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/episodes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/episodes/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
