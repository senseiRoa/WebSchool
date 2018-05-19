using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebSchool.Models
{
    public class T_Permission : BaseEntity
    {
        [Key]
        public Guid PermissionID { get; set; }

        [Required]
        [StringLength(128)]
        public string RoleID { get; set; }

        public int MenuID { get; set; }

        [ForeignKey("RoleID")]
        public virtual IdentityRole AspNetRoles { get; set; }

        [ForeignKey("MenuID")]
        public virtual T_Menu T_Menu { get; set; }

        public string Action { get; set; }


    }
}