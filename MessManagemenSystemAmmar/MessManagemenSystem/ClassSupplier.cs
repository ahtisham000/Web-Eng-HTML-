using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessManagemenSystem
{
    class ClassSupplier
    {
        public string supplierId { get; set; }
        public string name { get; set; }
        public string cnic { get; set; }
        public string phone { get; set; }
        public string category { get; set; }

        public ClassSupplier()
        {

        }
        public ClassSupplier(string supplierId, string name, string cnic, string phone, string category)
        {
            this.supplierId = supplierId;
            this.name = name;
            this.cnic = cnic;
            this.phone = phone;
            this.category = category;
        }

    }
}
