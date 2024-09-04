using System;
using LiskovSubstitutionPrinciple;


public class Program
{
    public static void Main(string[] args)
    {
        Admin admin = new Admin("admin");
        Employee employee = new Employee("employee");

        DoSomething(admin);
        DoSomething(employee);
    }

    public static void DoSomething(User user)
    {
        user.LogIn();
        user.Access();
        user.LogOut();
    }
}


