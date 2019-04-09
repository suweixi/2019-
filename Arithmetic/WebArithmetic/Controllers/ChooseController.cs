using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebArithmetic.Controllers
{
    public class ChooseController : Controller
    {
        // GET: Choose
        public ActionResult Index()
        {
            return View();
        }

        //学生选择
        public ActionResult S_Select()
        {
            return View();
        }
        //老师选择
        public ActionResult T_Select()
        {
            return View();
        }
        //家长选择
        public ActionResult P_Select()
        {
            return View();
        }
    }
}