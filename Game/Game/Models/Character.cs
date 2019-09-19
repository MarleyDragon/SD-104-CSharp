using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Game.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Parentage { get; set; }
        public string Trope { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }
        [Display(Name = "Fighting Stle")]
        public string FightingStyle { get; set; }

        
        public int Brawn { get; set; }
        public int Speed { get; set; }
        public int Spirit { get; set; }
        public int Finesse { get; set; }
        public int Wit { get; set; }

        
       
    }
}
