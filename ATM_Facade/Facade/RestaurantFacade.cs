using Restaurant_Facade.Models;
using Restaurant_Facade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Facade.Facade
{
    public class RestaurantFacade
    {
        private readonly WaiterService _waiter;
        private readonly KitchenService _kitchen;
        private readonly BillingService _billing;

        public RestaurantFacade()
        {
            _waiter = new WaiterService();
            _kitchen = new KitchenService();
            _billing = new BillingService();
        }

        public void CreateOrder(List<MenuItem> menuItems)
        {
            var order = new Order(menuItems);

            _waiter.ReceiveOrder(order);
            Console.WriteLine("");

            _kitchen.PrepareOrder2(order);
            Console.WriteLine("");

            _waiter.ServeOrder(order);
            Console.WriteLine("");

            _billing.CreateBill(order);
        }
    }
}
