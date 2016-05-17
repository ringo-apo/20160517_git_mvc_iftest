using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kekka(int hensu1)
        {
            if (hensu1 > 10)
            {
                ViewBag.Kotae = "10以上";
            }
            else
            {
                ViewBag.Kotae = "10以下";
            }

            return View();
        }
    }
}