using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Error() {
            return View("~/Views/Shared/_Error404.cshtml");
        }
        public ActionResult Index()
        {
            return View("Home1");
        }
        public ActionResult Job_Description()
        {

            return View();
        }

        public ActionResult Log_In()
        {

            return View();        }
        public ActionResult Admin_Login()
        {

            return View();
        }
        public ActionResult _Edu_Tab_View()
        {

            return PartialView();
        }
        public ActionResult _Exp_Tab_View()
        {

            return PartialView();
        }
        public ActionResult Sign_Up()
        {

            return View();
        }
        public ActionResult JobCard()
        {

            return View();
        }
        public ActionResult Tab_View()
        {

            return View();
        }
        public ActionResult Submit_Resume()
        {
            return View();
        }
        public ActionResult PostJobs()
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
    }
}