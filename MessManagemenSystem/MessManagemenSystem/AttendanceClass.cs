using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessManagemenSystem
{
    class AttendanceClass
    {
        public int breakfast { get; set; }
        public int lunch { get; set; }
        public int dinner { get; set; }
        public int totalunits { get; set; }
        public string customerId{get;set;}
        public string date { get; set; }
        public AttendanceClass(string customerId)
        {
            this.customerId = customerId;
        }
    }
}
