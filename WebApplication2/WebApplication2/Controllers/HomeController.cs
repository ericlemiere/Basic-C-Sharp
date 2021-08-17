using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Log to text file every time home page is visited
            string text = "Index Visited";
            System.IO.File.WriteAllText(@"C:\Users\ericr\Documents\GitHub\Basic-C-Sharp\WebApplication2\log.txt", text);

            User user = new User();
            user.Id = 1;
            user.firstName = "Tommy";
            user.lastName = "Filson";
            user.Age = 42;

            return View(user);
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