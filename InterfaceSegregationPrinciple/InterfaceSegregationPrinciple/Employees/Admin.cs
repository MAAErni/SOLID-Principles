using InterfaceSegregationPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Employees
{
    public class Admin : IEmployees, IDeleteUser
    {
        public void Work()
        {
            Console.WriteLine("Admin is working");
        }

        public void DeleteUser()
        {
            Console.WriteLine("Admin Delete User");
        }

        public void TimeIn()
        {
            Console.WriteLine("Admin Time In");
        }
    }
}


