using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSchool.Models
{
    public class CourseViewModel
    {
       
        public Guid CourseID { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Código")]
        public string Code { get; set; }
    }
}