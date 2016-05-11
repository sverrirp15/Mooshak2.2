using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mooshak2.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

        public ActionResult AddAssignment()
        {
            ViewBag.Message = "Add Assignment";
            return View();
        }

        public ActionResult GiveGrade()
        {
            ViewBag.Message = "GiveGrade";
            return View();
        }
        public ActionResult DeleteAssignment()
        {
            ViewBag.Message = "Delete Assignment";
            return View();
        }

        public ActionResult ChooseCourse()
        {
            ViewBag.Message = "Choose course";
            return View();
        }
	}
}