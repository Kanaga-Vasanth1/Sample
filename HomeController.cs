
using System.Web.Mvc;
using NameApplication.Models;

namespace NameApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveStudent(Student student)
        {

            string FirstName = student.FirstName;
            string LastName = student.LastName;
            Student obj = new Student();
          
            return Json(obj, JsonRequestBehavior.AllowGet);

        }


    }
}