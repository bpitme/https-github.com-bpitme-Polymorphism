using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobs
{
    public class Task

    {
        public Task() 
        {
            Type = "Online";
            Time = "2";             
         }
        public string Type { get; set; }    
        public string Time { get; set; }

    }
}
