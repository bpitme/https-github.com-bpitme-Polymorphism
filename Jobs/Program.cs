using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Jobs
{

    class Program
    {
        static void Main(string[] args)
        {
            JobsRecruitment recruitment = new JobsRecruitment();
            recruitment.Employees = new List<string>() { "Mala", "Jack", "Rozzi", "Devan" };
            recruitment.ListEmployees();
            Console.ReadLine();

            //Meeting meeting = new Meeting();
            //meeting.Shuffle(3);

            //foreach (Task task in meeting.Tasks)
            //{
            //    Console.WriteLine(task.Time + " of " + task.Type);
            //}
            //Console.WriteLine(meeting.Tasks.Count);
            //Console.ReadLine();
        }
}   }

       