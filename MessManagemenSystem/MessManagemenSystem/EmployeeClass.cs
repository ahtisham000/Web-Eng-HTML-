using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessManagemenSystem
{
    class EmployeeClass
    {
        public string employeeId { get; set; }
        public string name {get; set;}
        public string cnic { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string gender { get; set; }
        public string jobtype { get; set; }
        public int salary { get; set; }
        public string dateOfJoin { get; set; }

        public EmployeeClass(string employeeId, string name, string cnic, string phone, string address, string city, string gender,string jobtype, int salary, string dateOfJoin)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.cnic = cnic;
            this.address = address;
            this.city = city;
            this.phone = phone;
            this.gender = gender;
            this.jobtype = jobtype; 
            this.salary = salary;
            this.dateOfJoin = dateOfJoin;
        }
    }
}
