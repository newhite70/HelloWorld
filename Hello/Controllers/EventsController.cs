using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hello.Models;
using Hello.Data;
using Microsoft.AspNetCore.Mvc;

namespace Hello.Controllers
{
    public class EventsController : Controller
    {
        //static private List<Event> Events = new List<Event>();   removed for the Data Folder
        //GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {

            //Events.Add("E3");
            //Events.Add("Unreal");
            //Events.Add("Work");
            ViewBag.Events = EventData.GetAll();

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Events/Add")]
        public IActionResult NewEvent(Event newEvent)
        {
            EventData.Add(newEvent);
            return Redirect("/Events");
        }

        public IActionResult Delete()
        {
            ViewBag.events = EventData.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int[] eventIDs)
        {
            foreach(int eventID in eventIDs)
            {
                EventData.Remove(eventID);
            }
            return Redirect("/Events");
        }

        public IActionResult Edit(int eventId)
        {
            //ViewBag.title = "Edit Event $"EventData.GetById(eventID).Name(id = EventData.GetById(eventID).ID);
            ViewBag.eventToEdit = EventData.GetById(eventId);
            return Redirect("/Edit");
        }

        [HttpPost]
        [Route("/Events/Edit/{eventId?}")]
        public IActionResult SubmitEditEventForm(int eventId, string name, string description)
        {

            return Redirect("/Events");
        }
    }
}
