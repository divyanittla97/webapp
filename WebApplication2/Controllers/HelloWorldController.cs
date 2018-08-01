using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

        public ViewResult TextView(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

        public PartialViewResult Partial()
        {
            return PartialView("_PartialView");
        }

        public RedirectResult RedirectView()
        {
            return Redirect("Welcome");
        }

        public ActionResult JSON()
        {
            var persons = new List<Person1>
       {
        new Person1{Id=1, FirstName="Harry", LastName="Potter"},
              new Person1{Id=2, FirstName="James", LastName="Raj"}
       };
            return Json(persons, JsonRequestBehavior.AllowGet);
        }

    }
}