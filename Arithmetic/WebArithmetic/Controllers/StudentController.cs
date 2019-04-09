using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebArithmetic.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        //练习
        public ActionResult Exam()
        {
            return View();
        }
        //测试
        public ActionResult Practice()
        {
            return View();
        }
    }
}