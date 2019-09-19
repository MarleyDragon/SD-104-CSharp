using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Models
{
    public class Student
    {
        [Display(Name = "Student Name")]
        public string Name { get; set; }

       public int Id { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }
        public int Age { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-Mail Address")]
        public string EMail { get; set; }

    }
}
