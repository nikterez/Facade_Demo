using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Facade.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<MenuItem> MenuItems { get; set; }

        public Order(List<MenuItem> selectedMenuItems)
        {
            OrderId = 1;
            MenuItems = selectedMenuItems;
        }

    }
}
