using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatDragonInnWebApp.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        
        public string SendeeName {get; set;}

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }

        [ForeignKey("UserId")]
        public virtual int UserID { get; set; }
    }
}
