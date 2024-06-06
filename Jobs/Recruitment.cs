using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobs 
{
   public abstract class Recruitment
    {
        public List<string>Employees { get; set; }
        public string Name { get; set; }
        public string Locationbase { get; set; }

        public abstract void Employment();
        public  virtual void ListEmployees() 
            
        {
            foreach (string employee in Employees) 
            {
                Console.WriteLine(employee);
            }
        }


                  
    }

}

