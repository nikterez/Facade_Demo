using Restaurant_Facade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Facade.Services
{
    public class BillingService
    {
        public void CreateBill(Order order)
        {
            var total = order.MenuItems.Sum(x => x.Price);
            
            Console.WriteLine($"Total cost of the order is {total} euros");
        }
    }
}
