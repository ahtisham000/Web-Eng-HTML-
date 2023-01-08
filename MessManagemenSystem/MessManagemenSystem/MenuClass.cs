using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessManagemenSystem
{
    class MenuClass
    {
        public string day { get; set; }
        public string breakFast { get; set; }
        public string lunch { get; set; }
        public string dinner { get; set; }

        public MenuClass(string day,string breakFast,string lunch,string dinner)
        {
            this.day = day;
            this.breakFast = breakFast;
            this.lunch = lunch;
            this.dinner = dinner;
        }
    }
}
