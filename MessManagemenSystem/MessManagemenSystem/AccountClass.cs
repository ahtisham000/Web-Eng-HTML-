﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessManagemenSystem
{
    class AccountClass
    {
        public string customerId { get; set; }
        public string name { get; set; }
        public int unitpurchased { get; set; }
        public int unitremaining { get; set; }

        public AccountClass(string customerId,string name)
        {
            this.customerId = customerId;
            this.name = name;
        }
    }
}
