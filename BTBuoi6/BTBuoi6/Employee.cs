using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTBuoi6
{
    public class Employee
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string Firstname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        //
        public Employee(int id, string lastName, string firstName, string address, string phone)
        {
            this.ID = id;
            this.LastName = lastName;
            this.Firstname = firstName;
            this.Address = address;
            this.Phone = phone;
        }
    }
}
