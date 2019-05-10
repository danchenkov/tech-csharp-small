using System;
namespace Schedule.Models
{
    public class Episodes
    {
        public Episode[] episodes { get; set; }
    }

    public class Episode
    {
        public string Title { get; set; }
        public string Series { get; set; }
        public DateTime AiredAt { get; set; }
    }
}
