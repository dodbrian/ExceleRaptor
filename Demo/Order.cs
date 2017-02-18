using System;
using System.Collections.Generic;

namespace Demo
{
    public class Order
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}