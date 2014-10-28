﻿using System.Web;
using System.Web.Mvc;

namespace MvcMovieDev.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name, int numtimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numtimes;
            return View();
        } 
	}
}