using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello.Models
{
    public class Event
    {
        public int ID { get; }
        private static int nextID = 1;
        public string Name { get; set; }
        public string Description { get; set; }

        public Event()
        {
            ID = nextID;
            nextID++;
        }
        public Event(string name, string desc) : this()
        {

            Name = name;
            Description = desc;

        }
        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Event @event &&
                   ID == @event.ID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ID);
        }
    }
}
