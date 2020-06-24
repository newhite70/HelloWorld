using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hello.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hello.Controllers
{
    public class EventsController : Controller
    {
        static private List<Event> Events = new List<Event>();
        //GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {

            //Events.Add("E3");
            //Events.Add("Unreal");
            //Events.Add("Work");
            ViewBag.Events = Events;

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Events/Add")]
        public IActionResult NewEvent(string name)
        {
            Events.Add(new Event(name));
            return Redirect("/Events");
        }
    }
}
