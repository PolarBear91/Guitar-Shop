﻿using Data_Access_Layer.Models;

namespace Data_Access_Layer.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
