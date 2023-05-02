using Restaurant_Facade.Facade;
using Restaurant_Facade.Models;

namespace Restaurant_Facade
{
    public class Program
    {
        static void Main(string[] args)
        {

            var orderedDishes = new List<MenuItem>
            {
                new MenuItem {Name = "Steak", Price = 10.50},
                new MenuItem { Name = "Chicken", Price = 7.00 },
                new MenuItem { Name = "Fish", Price = 12.50 }
            };

            var restaurantFacade = new RestaurantFacade();
            restaurantFacade.CreateOrder(orderedDishes);

        }
    }
}