using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebArithmetic.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }
        //自动生成题目
        public ActionResult Automation()
        {
            return View();
        }
        //子拟题目
        public ActionResult Proposed()
        {
            return View();
        }
    }
}