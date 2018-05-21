using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSchool.Infraestructure.Entities;

namespace WebSchool.Models
{
    public class InscriptionStudentViewModel
    {
        public Guid InscriptionStudentID { get; set; }

        public string StudentID { get; set; }

        public string Observation { get; set; }

        public Boolean Assistance { get; set; }
        public  InstanceOfCourseViewModel InstanceOfCourse { get; set; }
    }
}