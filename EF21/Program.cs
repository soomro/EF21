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
            var categories2 = ne.Categories.OrderByDescending(c => c.CategoryName);

            foreach (Category c in categories2)
            {
                Console.WriteLine("{0} {1} {2}", c.CategoryName, c.Description, c.Products);
            }

            //// 
            //// öVNINGAR 4
            //// 
            var orders4 = from m in ne.Orders.Skip(10)
                          select new
                          {
                              m.OrderDate,
                              m.ShipName
                          };

            foreach (var o in orders4)
            {
                Console.WriteLine("{0} {1}", o.OrderDate, o.ShipName);
            }


            //// 
            //// öVNINGAR 5
            //// 

            var orders5 = from m in ne.Orders.Where(m => m.CustomerID == "VINET")
                          select new
                          {
                              m.OrderID,
                              m.Customer,
                              m.OrderDate,
                              m.ShipName
                          };
            foreach (var o in orders5)
            {
                Console.WriteLine("{0} {1}", o.OrderDate, o.ShipName);
            }

            //// 
            //// öVNINGAR 6
            //// 
            var orders6 = from m in ne.Orders.Where(m => m.EmployeeID == 5)
                          select new
                          {
                              m.OrderID,
                              m.Customer,
                              m.OrderDate,
                              m.ShipName
                          };
            foreach (var o in orders6)
            {
                Console.WriteLine("{0} {1}", o.OrderDate, o.ShipName);
            }


            //// 
            //// öVNINGAR 7
            //// 

            var product_FirstOrDefault = ne.Products.FirstOrDefault();
            Console.WriteLine(product_FirstOrDefault);
            var product_First = ne.Products.First();
            Console.WriteLine(product_First);

            //// 
            //// öVNINGAR
            //// 


            //// 
            //// öVNINGAR
            //// 

            Console.ReadKey();
        }
    }
}
