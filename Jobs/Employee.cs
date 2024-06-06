using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobs
{
    public class Employee
    {

        public List<Task> Hand {  get; set; }
        public int Salary {  get; set; }
        public string Name { get; set; }
        public bool IsActivileyWorking { get; set; }

    }
}
