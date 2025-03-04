using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q___1
{
    internal class LMS
    {
        public string Title;
        public string Author;
        public string ISBN;
        public double Price;
        public void ApplyDiscount(double percentage)
        {
            if (percentage < 0 || percentage > 100)
            {
                Console.WriteLine("Invalid discount percentage.");
                return;
            }
            double discount = (Price * percentage) / 100;
            Price-=discount;
            Console.Write($"Price after discount= {Price} \n");
        }
        public  void  DisplayBookInfo() { 
            Console.WriteLine("\nBooks details");
            Console.WriteLine("Title    | Author  | ISBN   | Actual Price");
            Console.WriteLine($"{Title}  {Author}     {ISBN}     {Price}");
        }
    }
}
