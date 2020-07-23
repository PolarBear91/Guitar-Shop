using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access_Layer.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
