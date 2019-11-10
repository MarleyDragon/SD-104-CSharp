using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatDragonInnWebApp.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string Image { get; set; }

        public string Genre { get; set; }

        [Display(Name= "Product Description")]
        public string ProductDescription { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        public string Creator { get; set; }

        public string Publisher { get; set; }
                      
        public string FileUpload { get; set; }


         

    }
}
