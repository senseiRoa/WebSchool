using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebSchool.Models;

namespace WebSchool.Infraestructure.Entities
{
    public class T_InscriptionStudent : BaseEntity
    {
        [Key]
        public Guid InscriptionStudentID { get; set; }

        [Index("IX_one", 1, IsUnique = true)]
        public string StudentID { get; set; }

        [StringLength(500)]
        public string Observation { get; set; }

        [Required]
        public Boolean Assistance { get; set; }

        [ForeignKey("StudentID")]
        public virtual IdentityUserModel Student { get; set; }


        [Index("IX_one", 2, IsUnique = true)]
        public Guid InstanceOfCourseID { get; set; }

        [ForeignKey("InstanceOfCourseID")]
        public virtual T_InstanceOfCourse InstanceOfCourse { get; set; }
    }
}