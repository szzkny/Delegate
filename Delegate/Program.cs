using Library;
using System.Diagnostics;

namespace Delegate
{
    internal class Program
    {
        static Cart cart = new Cart();

        static void Main(string[] args)
        {
            LoadDemoData();

            Console.WriteLine("The price with the discount is: " + cart.CalculatePrice(Discount, Total) + " EUR");

            // Example of anonymous method
            Console.WriteLine("The price of the second cart is: " +
                cart.CalculatePrice(p =>
                {
                    if (p >= 100.00M)
                    {
                        return p * 0.8M;
                    }
                    else
                    {
                        return p;
                    };
                }, price => {
                    Console.WriteLine("The total price of the second cart is: " +
                    price + " EUR");
                })
                );
        }


        private static void LoadDemoData()
        {
            cart.ShoppingList.Add(new Game { Name = "Far Car 6", Price = 59.99M });
            cart.ShoppingList.Add(new Game { Name = "GTA V.", Price = 20.49M });
            cart.ShoppingList.Add(new Game { Name = "God Of War", Price = 49.99M });
        }

        private static void Total(decimal totalP)
        {
            Console.WriteLine("The total price is: " + totalP + " EUR");
        }

        private static decimal Discount(decimal totalPrice)
        {
            if (totalPrice >= 100.00M)
            {
                return totalPrice * 0.8M;
            }
            else
            {
                return totalPrice;
            }
        }
    }
}