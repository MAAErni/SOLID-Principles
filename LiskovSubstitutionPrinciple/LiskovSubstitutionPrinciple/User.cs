using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public abstract class User
    {
        protected string _name;

        public User(string name)
        {
            _name = name;
        }

        public void LogIn()
        {
            Console.WriteLine($"{_name} logged in.");
        }

        public virtual void Access() 
        {
            Console.WriteLine($"{_name} access.");
        }

        public void LogOut()
        {
            Console.WriteLine($"{_name} logged out.");
        }
    }
}


