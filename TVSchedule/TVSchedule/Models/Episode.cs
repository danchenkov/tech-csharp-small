using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TVSchedule.Model
{
    public class Episode
    {
        public int Id { get; set; }
        public string Series { get; set; }
        public string Title { get; set; }
        public DateTime AiredAt { get; set; }
    }
}
