using System;
using InterfaceSegregationPrinciple.Interfaces;
using InterfaceSegregationPrinciple.Employees;


public class Program
{
    public static void Main(string[] args)
    {
        Manager manager = new Manager();
        Employee employee = new Employee();
        Admin admin = new Admin();

        manager.Work();
        manager.Manage();
        manager.TimeIn();

        employee.Work();
        employee.TimeIn();

        admin.Work();
        admin.DeleteUser();
        admin.TimeIn();
    }
}


