using System.Web.Mvc;
using WebSchool.Services.DAL;

namespace WebSchool.Controllers
{
    public class PersonController : BaseController
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return RedirectToAction("Register", "Account");
        }

        public ActionResult List()
        {
            var personDal = new Person_DAL();
            var persons = personDal.Users();

            return View(persons);
        }
    }
}