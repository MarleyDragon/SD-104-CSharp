using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatDragonInnWebApp.Models
{
    public class Customer
    {
        [Required]
        public int CustomerID { get; set; }

        [ForeignKey ("UserId")]
        public virtual int UserID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set;  }

        public string Image { get; set; }

        public string FavGame { get; set; }



    }
}
