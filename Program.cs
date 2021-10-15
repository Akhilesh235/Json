using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace W6D5_Training_Ses1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Akhi",
                Address = "23 Pears Avenue",
                Designation = "CEO",
                Salary = 10000000,
            };
            string  employeeJson = JsonConvert.SerializeObject(emp);
            //File.Create("Employee.Json");
            File.WriteAllText("Employee.json", employeeJson);
           
            //Console.ReadLine();
            Employee empTemp =JsonConvert.DeserializeObject<Employee>(File.ReadAllText("Employee.json"));
            string employeeJson1 = JsonConvert.SerializeObject(empTemp);
            File.WriteAllText("Employee1.json", employeeJson1);
            Console.ReadLine();
        }

    }
}
