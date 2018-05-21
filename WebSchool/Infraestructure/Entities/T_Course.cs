using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebSchool.Infraestructure.Entities
{
    public class T_Course : BaseEntity
    {
        [Key]
        public Guid CourseID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(25)]
        public string Code { get; set; }



       
    }
}