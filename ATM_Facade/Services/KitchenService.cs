using Restaurant_Facade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Facade.Services
{
    public class KitchenService
    {
        private readonly Dictionary<string, Action> cookingMethods;
        public KitchenService()
        {
            cookingMethods = new Dictionary<string, Action>
            {
                { "Steak", CookSteak },
                { "Chicken", CookChicken },
                { "Fish", CookFish }
            };
        }
        public void PrepareOrder(Order order)
        {
            Console.WriteLine("Kitchen is preparing the ordered meal");

            foreach (var item in order.MenuItems)
            {
                switch (item.Name)
                {
                    case "Steak":
                        CookSteak();
                        break;

                    case "Chicken":
                        CookChicken();
                        break;

                    case "Fish":
                        CookFish();
                        break;
                }
            }

            NotifyWaiter();
        }

        public void PrepareOrder2(Order order)
        {
            Console.WriteLine($"Kitchen is preparing the order with id {order.OrderId}");

            foreach (var item in order.MenuItems)
            {
                cookingMethods[item.Name].Invoke();
            }

            //order.MenuItems.ForEach(item => cookingMethods[item.Name].Invoke());

            NotifyWaiter();

        }

        private void NotifyWaiter()
        {
            Console.WriteLine("Kitchen notified the waiter that order is ready");
        }
        
        private void CookSteak()
        {
            Console.WriteLine("Cooking steak");
        }
        
        private void CookFish()
        {
            Console.WriteLine("Cooking fish");
        }
        
        private void CookChicken()
        {
            Console.WriteLine("Cooking chicken");
        }

    }
}
