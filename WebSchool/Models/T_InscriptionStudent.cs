using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSchool.Models
{
    public class T_InscriptionStudent : BaseEntity
    {
        [Key]
        public Guid InscriptionStudentID { get; set; }

        public string StudentID { get; set; }

        [Required]
        [StringLength(500)]
        public string Observation { get; set; }

        [Required]
        public Boolean Assistance { get; set; }

        [ForeignKey("StudentID")]
        public virtual ApplicationUser Student { get; set; }

        public Guid InstanceOfCourseID { get; set; }

        [ForeignKey("InstanceOfCourseID")]
        public virtual T_InstanceOfCourse InstanceOfCourse { get; set; }
    }
}