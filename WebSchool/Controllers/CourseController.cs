using Microsoft.AspNet.Identity;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebSchool.Infraestructure.Entities;
using WebSchool.Models;
using WebSchool.Services.DAL;

namespace WebSchool.Controllers
{
    public class CourseController : BaseController
    {
        // GET: Course
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Administrador")]
        public ActionResult Add()
        {
            return View(new CourseViewModel());
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Add(CourseViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newModel = new T_Course
                {
                    CourseID = Guid.NewGuid(),
                    Name = model.Name,
                    Code = model.Code,
                    CreateDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LogicalErasure = false
                };

                var courseDal = new Course_DAL();
                var response = courseDal.Add(newModel);

                if (response != null)
                {
                    return RedirectToAction("List");
                }
                ModelState.AddModelError("", "Error al Crear El Curso");
            }

            return View(model);
        }

        public ActionResult List()
        {
            var courseDal = new Course_DAL();
            var response = courseDal.list();
            return View(response);
        }

        public ActionResult addClass()
        {
            var courseDal = new Course_DAL();
            var courses = courseDal.list();
            ViewBag.courses = courses.Select(i => new SelectListItem() { Text = i.Name, Value = i.CourseID.ToString() });
            DateTime dateTime = DateTime.Now;

            TimeSpan span = dateTime.TimeOfDay;
            return View(new InstanceOfCourseViewModel()
            {
                InstanceOfCourseID = Guid.NewGuid(),
                Date = dateTime,
                // StartTime = span.ToString("hh:mm tt")
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> addClass(InstanceOfCourseViewModel model)
        {
            var courseDal = new Course_DAL();
            if (ModelState.IsValid)
            {
                DateTime dateTime = DateTime.ParseExact(model.StartTime,
                                     "hh:mm tt", CultureInfo.InvariantCulture);
                TimeSpan span = dateTime.TimeOfDay;
                TimeSpan span2 = dateTime.AddHours(3).TimeOfDay;

                var newModel = new T_InstanceOfCourse
                {
                    InstanceOfCourseID = Guid.NewGuid(),
                    TeacherID = User.Identity.GetUserId(),
                    Date = model.Date,
                    StartTime = span,
                    FinalTime = span2,
                    CourseID = Guid.Parse(model.CourseID),
                    CreateDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LogicalErasure = false
                };

                try
                {
                    var response = courseDal.AddClassTeacher(newModel);
                    if (response != null)
                    {
                        return RedirectToAction("Courses");
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            var courses = courseDal.list();
            ViewBag.courses = courses.Select(i => new SelectListItem() { Text = i.Name, Value = i.CourseID.ToString() });

            return View(model);
        }

        public ActionResult Courses()
        {
            var courseDal = new Course_DAL();
            var courses = courseDal.InstanceOfCourses(User.Identity.GetUserId());

            return View(courses);
        }

        public ActionResult Program()
        {
            var courseDal = new Course_DAL();
            var courses = courseDal.InstanceOfCourses();

            ViewBag.courses = courses.Select(i => new SelectListItem()
            {
                Text = $"Curso:{i.CourseName},  Profesor:{i.teacherName},   Programación: {i.Date.ToShortDateString()} desde las {i.StartTime} hasta las {i.FinalTime}",
                Value = i.InstanceOfCourseID.ToString()
            });

            return View(new InscriptionStudentViewModel() { InstanceOfCourse=new InstanceOfCourseViewModel() } );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public  ActionResult Program(InscriptionStudentViewModel model)
        {
            var courseDal = new Course_DAL();

            if (ModelState.IsValid)
            {


                var newModel = new T_InscriptionStudent
                {
                    InscriptionStudentID = Guid.NewGuid(),
                    Assistance = false,
                    Observation = string.Empty,
                    StudentID = User.Identity.GetUserId(),
                    InstanceOfCourseID = model.InstanceOfCourse.InstanceOfCourseID,
                    CreateDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LogicalErasure = false

                };

                try
                {
                    var response = courseDal.AddInscription(newModel);
                    if (response != null)
                    {
                        return RedirectToAction("ProgramList");
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Operacion no valida, recuerde que solo puede agregar hasta 4 materias");
                    ModelState.AddModelError("", "Operacion no valida, No se puede agreagar materias repetidas");
                    ModelState.AddModelError("", ex.Message);
                }
            }
            var courses = courseDal.InstanceOfCourses();

            ViewBag.courses = courses.Select(i => new SelectListItem()
            {
                Text = $"{i.CourseName}-{i.teacherName}  {i.Date}-{i.StartTime}/{i.FinalTime}",
                Value = i.InstanceOfCourseID.ToString()
            });

            return View(model);
        }

        public ActionResult ProgramList()
        {
            var courseDal = new Course_DAL();
            var courses = courseDal.InscriptionStudent(User.Identity.GetUserId());

            return View(courses);
        }
    }
}