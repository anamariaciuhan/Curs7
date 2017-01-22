using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace curs7MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        [ActionName("About")] // exercitiul 2 mvc curs 7

       public ActionResult SomeMethodName() //exercitiul 1 mvc curs 7
        {
            return View();
        }

        [NonAction]
        public int Calc() // exercitiul 3 mvc curs 7
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                
                sum += i;
            }
            return sum;
        }

        public int DisplayCalc()
        {
            return Calc();
        }

        // [HttpPost()] 
        [HttpGet]
        public string VerbsTest() // exercitiul 4 mvc curs 7
        {
            return "Hello";
        }

        [ActionName("authorize")]
        [Authorize(Roles = "Admin")]
        public ActionResult ThisMethodNeedsAuthorization() // exercitiul 5 mvc curs 7
        {
            return Content("Hi!");
        }
    }
}