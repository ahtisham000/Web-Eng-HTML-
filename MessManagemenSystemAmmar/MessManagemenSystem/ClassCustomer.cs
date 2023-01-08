using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessManagemenSystem
{
    class ClassCustomer
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string  City { get; set; }
        public string  Phone { get; set; }
        public string Gender { get; set; }
        public string DateOfJoin { get; set; }

        public ClassCustomer()
        {

        }
        public ClassCustomer(string CustomerId, string Name, string Address, string City, string Phone, string Gender, string DateOfJoin)
        {
            this.CustomerId = CustomerId;
            this.Name = Name;
            this.Address = Address;
            this.City = City;
            this.Phone = Phone;
            this.Gender = Gender;
            this.DateOfJoin = DateOfJoin;
        }
    }
}
