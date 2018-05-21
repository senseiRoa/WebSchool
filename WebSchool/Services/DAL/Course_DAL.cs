using System;
using System.Collections.Generic;
using System.Linq;
using WebSchool.Infraestructure;
using WebSchool.Infraestructure.Entities;
using WebSchool.Models;

namespace WebSchool.Services.DAL
{
    public class Course_DAL
    {
        private ApplicationDbContext dataContext;

        public List<CourseViewModel> list()
        {
            try
            {
                using (dataContext = new ApplicationDbContext())
                {
                    var courses = (from c in dataContext.Set<T_Course>()
                                   select new CourseViewModel
                                   {
                                       CourseID = c.CourseID,
                                       Code = c.Code,
                                       Name = c.Name
                                   }).ToList();
                    return courses;
                }
            }
            catch (Exception ex)
            {
                //TODO: guardar en api log
            }
            return new List<CourseViewModel>();
        }

        public T_Course Add(T_Course course)
        {
            try
            {
                using (dataContext = new ApplicationDbContext())
                {
                    dataContext.Set<T_Course>().Add(course);
                    dataContext.SaveChanges();
                    return course;
                }
            }
            catch (Exception ex)
            {
                //TODO: guardar en api log
            }
            return null;
        }

        public T_InstanceOfCourse AddClassTeacher(T_InstanceOfCourse instanceOfCourse)
        {
            try
            {
                using (dataContext = new ApplicationDbContext())
                {
                    dataContext.Set<T_InstanceOfCourse>().Add(instanceOfCourse);
                    dataContext.SaveChanges();
                    return instanceOfCourse;
                }
            }
            catch (Exception ex)
            {
                //TODO: guardar en api log
                throw;
            }
        }

        public List<InstanceOfCourseViewModel> InstanceOfCourses(string teacherID)
        {
            try
            {
                using (dataContext = new ApplicationDbContext())
                {
                    var instances = (from i in dataContext.Set<T_InstanceOfCourse>()
                                     where i.TeacherID.Equals(teacherID) && !i.LogicalErasure
                                     select new InstanceOfCourseViewModel
                                     {
                                         CourseID = i.CourseID.ToString(),
                                         CourseName = i.Course.Name,
                                         TeacherID = i.TeacherID,
                                         teacherName = i.Teacher.FirtsName +" "+i.Teacher.LastName,
                                         Date = i.Date,
                                         FinalTime = i.FinalTime.ToString(),
                                         StartTime = i.StartTime.ToString(),
                                         InstanceOfCourseID = i.InstanceOfCourseID
                                     }
                                     ).ToList();
                    return instances;
                }
            }
            catch (Exception ex)
            {
                //TODO: guardar en api log
            }
            return new List<InstanceOfCourseViewModel>(); ;
        }

        public List<InstanceOfCourseViewModel> InstanceOfCourses()
        {
            try
            {
                using (dataContext = new ApplicationDbContext())
                {
                    var instances = (from i in dataContext.Set<T_InstanceOfCourse>()
                                     where !i.LogicalErasure
                                     select new InstanceOfCourseViewModel
                                     {
                                         CourseID = i.CourseID.ToString(),
                                         CourseName = i.Course.Name,
                                         TeacherID = i.TeacherID,
                                         teacherName = i.Teacher.FirtsName + " " + i.Teacher.LastName,
                                         Date = i.Date,
                                         FinalTime = i.FinalTime.ToString(),
                                         StartTime = i.StartTime.ToString(),
                                         InstanceOfCourseID = i.InstanceOfCourseID
                                     }
                                     ).ToList();
                    return instances;
                }
            }
            catch (Exception ex)
            {
                //TODO: guardar en api log
            }
            return new List<InstanceOfCourseViewModel>();
        }

        public T_InscriptionStudent AddInscription(T_InscriptionStudent inscriptionStudent)
        {
            try
            {
                using (dataContext = new ApplicationDbContext())
                {
                    dataContext.Set<T_InscriptionStudent>().Add(inscriptionStudent);
                    dataContext.SaveChanges();
                    return inscriptionStudent;
                }
            }
            catch (Exception ex)
            {
                //TODO: guardar en api log
                throw;
            }
        }

        public List<InscriptionStudentViewModel> InscriptionStudent(string studentID)
        {
            try
            {
                using (dataContext = new ApplicationDbContext())
                {
                    var instances = (from i in dataContext.Set<T_InscriptionStudent>()
                                     where i.StudentID.Equals(studentID) && !i.LogicalErasure
                                     select new InscriptionStudentViewModel
                                     {
                                         InscriptionStudentID = i.InscriptionStudentID,
                                         Assistance = i.Assistance,
                                         Observation = i.Observation,
                                         InstanceOfCourse = new InstanceOfCourseViewModel
                                         {
                                             CourseID = i.InstanceOfCourse.CourseID.ToString(),
                                             CourseName = i.InstanceOfCourse.Course.Name,
                                             TeacherID = i.InstanceOfCourse.TeacherID,
                                             teacherName = i.InstanceOfCourse.Teacher.FirtsName+" "+ i.InstanceOfCourse.Teacher.LastName,
                                             Date = i.InstanceOfCourse.Date,
                                             FinalTime = i.InstanceOfCourse.FinalTime.ToString(),
                                             StartTime = i.InstanceOfCourse.StartTime.ToString(),
                                             InstanceOfCourseID = i.InstanceOfCourse.InstanceOfCourseID
                                         }

                                     }

                        ).ToList();
                    return instances;
                }
            }
            catch (Exception ex)
            {
                //TODO: guardar en api log
            }
            return new List<InscriptionStudentViewModel>();
        }
    }
}