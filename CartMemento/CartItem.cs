namespace CartMemento
{
    public class CartItem
    {
        public Food Food { get; private set; }
        public CartItem(Food Food)
        {
            this.Food = Food;
        }
        public CartItemSnapshot CreateSnapshot()
        {
            return new CartItemSnapshot(this.Food.CreateSnapshot());
        }
       

        // Restores the Originator's state from a memento object.
        public void Restore(CartItemSnapshot memento)
        {       
            Food.Restore(memento.Food);           
        }

    }

}
