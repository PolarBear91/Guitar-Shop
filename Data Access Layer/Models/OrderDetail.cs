using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access_Layer.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int GuitarId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Guitar Guitar { get; set; }
        public Order Order { get; set; }
    }
}
