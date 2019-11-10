using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Knight
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public bool Male { get; set; }

        public bool Female { get; set; }

        public string WeaponOfChoice { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public int Age { get; set; }
    }
}
