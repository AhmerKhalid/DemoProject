﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Home1");
        }

        public ActionResult Log_In()
        {

            return View();        }
        public ActionResult Admin_Login()
        {

            return View();
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