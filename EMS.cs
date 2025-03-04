using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q___1
{
    internal class EMS
    {
        public EMS() { 
            EmployeeID = 0;
            EmployeeName = null;
            Department = "SE";
            Salary = 45000;
        }
        public int EmployeeID;
        public string EmployeeName;
        public string Department;
        public double Salary;

        public void IncreaseSalary(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Invalid amount. Salary increase must be positive.");
                return;
            }
            Salary += amount;
            Console.Write($"Salary after increment= {Salary} \n");
        }
        public void DisplayEmployeeDetails() {
            Console.WriteLine("Employee details");
            Console.WriteLine(" EmployeeID|EmployeeName   | Department    |  Salary");
            Console.WriteLine($"{EmployeeID}                {EmployeeName}         {Department}          {Salary} \n");
        }
    }
}
