using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobs
{
    public class JobsRecruitment:Recruitment, IWorkForces
    {
        public override void Employment()
        {
            throw new NotImplementedException();
        }
        public override void ListEmployees()
        {
            Console.WriteLine("25 Employees:");
            base.ListEmployees();
        }
        public void WorkForces(Employee employee) 
        {
            throw new NotImplementedException();
        }

        

    }
}
