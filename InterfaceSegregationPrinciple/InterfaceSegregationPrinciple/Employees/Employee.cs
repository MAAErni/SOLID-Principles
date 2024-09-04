using InterfaceSegregationPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Employees
{
    public class Employee : IEmployees
    {
        public void Work()
        {
            Console.WriteLine("Employee is working");
        }

        public void TimeIn()
        {
            Console.WriteLine("Employee Time In");
        }
    }
}


