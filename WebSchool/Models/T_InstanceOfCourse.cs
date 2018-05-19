using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSchool.Models
{
    public class T_InstanceOfCourse : BaseEntity
    {
        [Key]
        public Guid InstanceOfCourseID { get; set; }

        [Required]
        [Index("IX_OnlySchedulePerTeacher", 1, IsUnique = true)]
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }

        [Required]
        [Index("IX_OnlySchedulePerTeacher", 2, IsUnique = true)]
        [DataType("Time(0)")]
        public TimeSpan StartTime { get; set; }

        [Required]
        [Index("IX_OnlySchedulePerTeacher", 3, IsUnique = true)]
        [DataType("Time(0)")]
        public TimeSpan FinalTime { get; set; }

        [StringLength(128)]
        [Index("IX_OnlySchedulePerTeacher", 4, IsUnique = true)]
        public string TeacherID { get; set; }

        [ForeignKey("TeacherID")]
        public virtual ApplicationUser Teacher { get; set; }

    }
}