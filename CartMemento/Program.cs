using System;

namespace CartMemento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart(DateTime.Now, new Customer("Shahrzad", "Abedi"));
            cart.AddToCart(new CartItem(new Food("Pizza")));
            CareTaker careTaker = new CareTaker(cart);
            careTaker.Backup();
            careTaker.ShowHistory();

            cart.AddToCart(new CartItem(new Food("Fries")));
            careTaker.Backup();
            careTaker.ShowHistory();

            cart.AddToCart(new CartItem(new Food("Hamburger")));
            careTaker.Backup();
            careTaker.ShowHistory();

            careTaker.Undo();
            careTaker.ShowHistory();

        }
    }
}
