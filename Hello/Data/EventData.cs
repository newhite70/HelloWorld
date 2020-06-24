using Hello.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Hello.Data
{
    public class EventData
    {
        //store events
        private static Dictionary<int, Event> Events = new Dictionary<int, Event>();
        //interact with events
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.ID, newEvent);
        }
        //add events
        //retrieve events
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }
        // return single event
        public static Event GetById(int ID)
        {
            return Events[ID];
        }
        //remove an event
        public static void Remove(int ID)
        {
            Events.Remove(ID);
        }
    }
}
