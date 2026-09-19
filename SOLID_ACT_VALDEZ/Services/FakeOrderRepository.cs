    using SOLID_ACT_VALDEZ.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace SOLID_ACT_VALDEZ.Services
    {
        public class FakeOrderRepository : IOrderRepository
        {
            public List<Order> SavedOrders { get; } = new List<Order>();

            public void Save(Order order)
            {
                SavedOrders.Add(order);
            }
        }
    }
