using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartMemento
{
    public class Cart
    {
        public DateTime CreateDateTime { get; private set; }
        public Customer Customer { get; private set; }
        private List<CartItem> _cartItems = new();
        public IReadOnlyCollection<CartItem> CartItems { get { return _cartItems; }  }
        public Cart(DateTime createDateTime, Customer customer)
        {            
            this.CreateDateTime = createDateTime;
            this.Customer = customer;
        }
        public void AddToCart(CartItem cartItem)
        {
            _cartItems.Add(cartItem);
        }
        // Saves the current state inside a memento.
        public CartSnapshot Save()
        {
            return new CartSnapshot(this.CreateDateTime,this.Customer,this._cartItems);
        }

        // Restores the Originator's state from a memento object.
        public void Restore(CartSnapshot memento)
        {           
            this.CreateDateTime = memento.CreateDateTime;
            int i = 0;
            foreach (var item in _cartItems)
            {
                item.Restore(memento.CartItems.ElementAt(i));
                i++;
            }
            this.Customer = memento.Customer;
        }

    }

}
