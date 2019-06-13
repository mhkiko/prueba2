using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AplicacionMVC.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string StudentName { get; set; }
        [Required]
        public int Age { get; set; }
    }
}