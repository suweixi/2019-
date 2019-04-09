using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebArithmetic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string queren)
        {
            if (queren == "学生")
            {
                return View("");

            }

            else if (queren == "老师")
            {
                return View("Examination1");
            }

            else if (queren == "家长")
            {
                return View("Parent");
            }

            else
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
        public ActionResult Help()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
