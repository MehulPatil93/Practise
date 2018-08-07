using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult ListPeople()
        {
            List<PersonModel> ppl = new List<PersonModel>();
            ppl.Add(new PersonModel { Id = 1, FirstName = "Mehul", LastName = "Patil", Age = 25 });
            ppl.Add(new PersonModel { Id = 2, FirstName = "Abhijit", LastName = "Kale", Age = 25});
            ppl.Add(new PersonModel { Id = 3, FirstName = "Rohit", LastName = "Morajkar", Age = 24 });
            ppl.Add(new PersonModel { Id = 4, FirstName = "Sachin", LastName = "kale", Age = 26     });

            return View(ppl);

        }

            
    }
}