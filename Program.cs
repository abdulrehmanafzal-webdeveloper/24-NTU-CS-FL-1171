using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Library Management System
            LMS book1 = new LMS(),book2=new LMS();

            //Book1
            book1.Title = "Fashion";
            book1.Author = "Ahmad";
            book1.ISBN = "34563";
            book1.Price = 60;
            book1.DisplayBookInfo();
            book1.ApplyDiscount(10);
            //Book2
            book2.Title = "Politics";
            book2.Author = "Mohsin";
            book2.ISBN = "65545";
            book2.Price = 40;
            book2.DisplayBookInfo();
            book2.ApplyDiscount(5);

            Console.WriteLine("\n\n");

            //Employee Management System
            EMS employee1= new EMS();
            employee1.EmployeeID = 1;
            employee1.EmployeeName = "abdul";
            employee1.Department = "DCS";
            employee1.Salary = 50000;
            employee1.DisplayEmployeeDetails();
            employee1.IncreaseSalary(5000);
        }
    }
}
