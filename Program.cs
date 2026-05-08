using System;
using System.Collections.Generic;
using BSTProject.Models;
using BSTProject.DataStructures;
using BSTProject.Data;

namespace BSTProject
{
    internal static class Program
    {
        static void Main()
        {
            BinarySearch tree = new BinarySearch();
            List<Employee> employees = EmployeeData.GetEmployees();
            foreach(var emp in employees)
                tree.Insert(emp);
        }
    }
}