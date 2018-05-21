using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebSchool.Infraestructure.Entities
{
    public class T_Menu : BaseEntity
    {
        [Key]
        public int MenuID { get; set; }

        [Required]
        [StringLength(50)]
        public string DisplayName { get; set; }

        public int ParentMenuID { get; set; }

        public int OrderNumber { get; set; }

        [StringLength(100)]
        public string MenuURL { get; set; }

        [StringLength(25)]
        public string MenuIcon { get; set; }
        public virtual ICollection<T_Permission> T_Permission { get; set; }


        [NotMapped]
        public List<T_Menu> SubMenu { get; set; }

      

    }
}