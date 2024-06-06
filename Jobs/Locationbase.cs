using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Jobs
{
    public class Locationbase
    {
        public string Name { get; set; }
        public Meeting Meeting { get; set; }
        public int Distance { get; set; }
        public void Location(List<Task> Hand)
        {
            Hand.Add(Meeting.Tasks.First());
            Console.WriteLine(Meeting.Tasks.First().ToString() + "\n");
            Meeting.Tasks.RemoveAt(0);
        }


    }
}
    

