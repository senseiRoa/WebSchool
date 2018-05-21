using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSchool.Infraestructure.Entities
{
    public class T_School : BaseEntity
    {
        [Key]
        public Guid SchoolID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(25)]
        public string Code { get; set; }

       
    }
}