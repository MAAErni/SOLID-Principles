using InterfaceSegregationPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Employees
{
    public class Manager : IEmployees, IManage
    {
        public void Work()
        {
            Console.WriteLine("Manager is working");
        }

        public void Manage()
        {
            Console.WriteLine("Manager is managing");
        }

        public void TimeIn()
        {
            Console.WriteLine("Manager Time In");
        }
    }
}


