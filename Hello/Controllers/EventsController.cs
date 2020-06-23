using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hello.Controllers
{
    public class EventsController : Controller
    {
        static private Dictionary<string, string> Events = new Dictionary<string, string>();
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
        public IActionResult NewEvent(string name, string desc)
        {
            Events.Add(name, desc);
            return Redirect("/Events");
        }
    }
}
