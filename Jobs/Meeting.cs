using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobs
{
    public class Meeting
    {
        public Meeting()
        {
            Tasks = new List<Task>();
            List<string> Types = new List<string>() { "Online", "Officebase", "Reports", "Schedule" };
            List<string> Times = new List<string>()
            { "2", "3","4","5","6","7","8","9","Daily","Weekly","Monthly","Quaterlly","Yearly"};

            foreach (string type in Types)
            {
                foreach (string times in Times)
                {
                    Task task = new Task();
                    task.Type = type;
                    task.Time = times;
                    Tasks.Add(task);
                }
            }


        }
        public List<Task> Tasks { get; set; }
        public void Shuffle(int times = 1)
        {
            
            for (int i = 0; i < times; i++)
            {
                List<Task> TeampList = new List<Task>();
                Random random = new Random();

                while (Tasks.Count > 0)
                {
                    int randomIndex = random.Next(0,Tasks.Count);
                    TeampList.Add(Tasks[randomIndex]);
                    Tasks.RemoveAt(randomIndex);
                }
                    Tasks = TeampList;

            }

            
        }



    }
}
