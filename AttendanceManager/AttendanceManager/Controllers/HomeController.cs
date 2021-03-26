using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttendanceManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Attendance Manager - Home";

            return View();
        }
        public ActionResult Add_Subject()
        {
            ViewBag.Title = "Attendance Manager - Add Subject";

            return View();
        }
        public ActionResult View_Subject()
        {
            ViewBag.Title = "Attendance Manager - View Subject";

            return View();
        }
    }
}
