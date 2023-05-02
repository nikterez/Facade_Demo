using Restaurant_Facade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Facade.Services
{
    public class WaiterService
    {
        public void ReceiveOrder(Order order)
        {
            Console.WriteLine($"Waiter got the order with id {order.OrderId}");
            RegisterOrderToCounter();
            SendOrderToKitchen();
        }    
        
        public void ServeOrder(Order order)
        {
            Console.WriteLine($"Waiter served the order with id {order.OrderId}");
        }
        
        private void SendOrderToKitchen()
        {
            Console.WriteLine("Waiter sent the order to the kitchen");
        }
        
        private void RegisterOrderToCounter()
        {
            Console.WriteLine("Waiter registered the order in the counter");
        }
    }
}
