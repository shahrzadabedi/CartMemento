using System;
using System.Collections.Generic;
using System.Linq;

namespace CartMemento
{
    public class CartSnapshot : IMemento
    {
        public DateTime CreateDateTime { get; private set; }
        public Customer Customer { get; private set; }
        private List<CartItemSnapshot> _cartItems = new();
        public IReadOnlyCollection<CartItemSnapshot> CartItems { get { return _cartItems; } }
        public CartSnapshot(DateTime createDateTime, Customer customer, List<CartItem> cartItems)
        {

            this.CreateDateTime = createDateTime;
            this.Customer = customer;
            this._cartItems = cartItems.Select(p=> p.Save()).ToList();            
        }
       
       
         
    }
}