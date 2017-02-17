using ExceleRaptor;
using System;
using System.Collections.Generic;

namespace Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var data = new List<Order>
            {
                new Order { Id = 1, Number = 100, Items = new List<OrderItem>
                                        {
                                            new OrderItem { Id = 1, CreatedOn = DateTime.Now, Name = "Chair", Quantity = 5 }
                                        }
                          }
            };

            var report = new Report();

            report.Band("Orders", data,
                b1 => b1.Bind("Id", v => v.Id)
                        .Bind("Number", v => v.Number)
                        .Band("OrderItems", v => v.Items, b2 => b2.Bind("Name", v => v.Name)
                                                                  .Bind("Quantity", v => v.Quantity)));

            report.Render();
        }
    }
}
