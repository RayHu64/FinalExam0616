using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebFInalExam0619.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int number)
        {
            if (number==1) {
                ViewBag.result = "星期一";
            }
            if (number == 2)
            {
                ViewBag.result = "星期二";
            }
            if (number == 3)
            {
                ViewBag.result = "星期三";
            }
            if (number == 4)
            {
                ViewBag.result = "星期四";
            }
            if (number == 5)
            {
                ViewBag.result = "星期五";
            }
            if (number == 6)
            {
                ViewBag.result = "星期六";
            }
            if (number == 7)
            {
                ViewBag.result = "星期日";
            }
            return View();
        }

    }
}