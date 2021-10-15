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

            Employee emp1 = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Akhi1",
                Address = "10 Pears Avenue",
                Designation = "CTO",
                Salary = 10000000,

            };

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(emp);
            employeeList.Add(emp1);


            string  employeeListJson = JsonConvert.SerializeObject(employeeList);
            //File.Create("Employee.Json");
            File.WriteAllText("Employee.json", employeeListJson);
           
            //Console.ReadLine();
            List<Employee> empTemp = JsonConvert.DeserializeObject<List<Employee>>(File.ReadAllText("Employee.json"));
            string employeeJson1 = JsonConvert.SerializeObject(empTemp);
            File.WriteAllText("Employee1.json", employeeJson1);
            Console.ReadLine();

            //ctr R
            //ctr G


        }

    }
}
