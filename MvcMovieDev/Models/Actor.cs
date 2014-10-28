using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovieDev.Models
{
    public class Actor
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        public int OscarsNumber { get; set; }
    }
}