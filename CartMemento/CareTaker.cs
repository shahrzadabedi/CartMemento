using System;
using System.Collections.Generic;
using System.Linq;

namespace CartMemento
{
    public class CareTaker
    {
        private Cart _cart = null;
        private List<CartSnapshot> _mementos = new List<CartSnapshot>();
        public CareTaker(Cart cart)
        {
            this._cart = cart;
        }
        public void Backup()
        {
            this._mementos.Add(this._cart.Save());
        }

        public void Undo()
        {
            if (this._mementos.Count == 0)
            {
                return;
            }

            var memento = this._mementos.Last();
            this._mementos.Remove(memento);
            // Console.WriteLine("Caretaker: Restoring state to: " + memento.GetName());

            try
            {
                this._cart.Restore(memento);
            }
            catch (Exception ex)
            {
                this.Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var memento in this._mementos)
            {
                foreach (var item in memento.CartItems.ToList())
                {
                    Console.WriteLine(item.Food.Name);
                }
                Console.WriteLine();
            }
           
        }
    }

}
