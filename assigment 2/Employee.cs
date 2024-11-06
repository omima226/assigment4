using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_2
{
    public class Employee
    {
        public Employee(string name, int yearsOfExperience, double salary)
        {
            Name = name;
            YearsOfExperience = yearsOfExperience;
            Salary = salary;
        }

        public string Name { get; set; }
        public int YearsOfExperience { get; set; }
        public double Salary { get; set; }
    }
}
