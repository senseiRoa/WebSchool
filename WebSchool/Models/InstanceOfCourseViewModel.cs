using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSchool.Models
{
    public class InstanceOfCourseViewModel
    {
        public Guid InstanceOfCourseID { get; set; }

        public DateTime Date { get; set; }

        public string StartTime { get; set; }

        public string FinalTime { get; set; }

        public string TeacherID { get; set; }
        public string teacherName { get; set; }
        public string CourseID { get; set; }
        public string CourseName { get; set; }



    }
}