using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessManagemenSystem
{
    class ClassItem
    {
        public string supplierId { get; set; }
        public string itemname { get; set; }
        public string quantity { get; set; }
        public int amount { get; set; }
        public string date { get; set; }

        public ClassItem()
        {

        }
        public ClassItem(string supplierId, string itemname, string quantity, int amount, string date)
        {
            this.supplierId = supplierId;
            this.itemname = itemname;
            this.quantity = quantity;
            this.amount = amount;
            this.date = date;
        }
    }
}
