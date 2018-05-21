using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSchool.Models
{
    public class RoleModel
    {
        public string RoleID { get; set; }
        public string Name { get; set; }
    }
    public class RoleViewModel
    {
        public static RoleModel Estudiante = new RoleModel { RoleID = "43c53a51-c8df-46cb-a61b-5cffe6c15612", Name = "Estudiante" };
        public static RoleModel Profesor = new RoleModel { RoleID = "14884395-3206-4234-a38a-2f0f4f0d704b", Name = "Profesor" };
    }
}