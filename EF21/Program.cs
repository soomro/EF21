using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF21.Models;

namespace EF21
{
    class Program
    {
        static void Main(string[] args)
        {
            NORTHWNDEntities ne = new NORTHWNDEntities();

            //// 
            //// öVNINGAR 1
            //// 
            var orders = from m in ne.Orders  // tip: from m in ne.Orders.Skip(0).Take(10)
                         select new
                         {
                             m.OrderDate,
                             m.ShipName,
                             m.Customer
                         };
            
            foreach (var o in orders)
            {
                Console.WriteLine("{0} {1} {2}", o.OrderDate, o.ShipName, o.Customer.ContactName);
            }

            //// 
            //// öVNINGAR 2
            //// 
            var categories = ne.Categories.OrderBy(c => c.CategoryName);

            foreach (Category c in categories)
            {
                Console.WriteLine("{0} {1} {2}", c.CategoryName, c.Description, c.Products);
            }

            //// 
            //// öVNINGAR 3
            //// 


            //// 
            //// öVNINGAR
            //// 


            Console.ReadKey();
        }
    }
}
