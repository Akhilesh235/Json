using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6D5_Training_Ses1
{
    public class Employee
    {
        public string Name { get;  set; }
        public Guid Id { get;  set; }

        public string Designation { get;  set; }

        public string Address { get;  set; }

        public double Salary { get;  set; }

        public Employee()
        {

        }
    }
}
