using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSchool.Models;

namespace WebSchool.Services.DAL
{
    public class Course_DAL
    {
        private ApplicationDbContext dataContext;

        public List<T_Course> Courses(string userID)
        {
            try
            {
                using (dataContext = new ApplicationDbContext())
                {
                    var courses = dataContext.Set<T_Course>().ToList();
                    return courses;
                }
            }
            catch (Exception ex)
            {
                //TODO: guardar en api log
            }
            return null;
        }
        public T_Course Add(T_Course course)
        {
            try
            {
                using (dataContext = new ApplicationDbContext())
                {
                    dataContext.Set<T_Course>().Add(course);
                    dataContext.SaveChangesAsync();
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
                    dataContext.SaveChangesAsync();
                    return instanceOfCourse;
                }
            }
            catch (Exception ex)
            {
                //TODO: guardar en api log
                throw;
            }
            
        }

       
        public List<T_InstanceOfCourse> InstanceOfCourses(string teacherID)
        {
            try
            {
                using (dataContext = new ApplicationDbContext())
                {
                    var instances = dataContext.Set<T_InstanceOfCourse>().Where(i=>i.TeacherID.Equals(teacherID) && !i.LogicalErasure).ToList();
                    return instances;
                }
            }
            catch (Exception ex)
            {
                //TODO: guardar en api log
            }
            return null;
        }


        public T_InscriptionStudent AddInscription(T_InscriptionStudent inscriptionStudent)
        {
            try
            {
                using (dataContext = new ApplicationDbContext())
                {
                    dataContext.Set<T_InscriptionStudent>().Add(inscriptionStudent);
                    dataContext.SaveChangesAsync();
                    return inscriptionStudent;
                }
            }
            catch (Exception ex)
            {
                //TODO: guardar en api log
                throw;
            }

        }

        public List<T_InscriptionStudent> InscriptionStudent(string studentID)
        {
            try
            {
                using (dataContext = new ApplicationDbContext())
                {
                    var instances = dataContext.Set<T_InscriptionStudent>().Where(i => i.StudentID.Equals(studentID) && !i.LogicalErasure).ToList();
                    return instances;
                }
            }
            catch (Exception ex)
            {
                //TODO: guardar en api log
            }
            return null;
        }
    }
}