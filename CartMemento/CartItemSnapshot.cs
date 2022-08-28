namespace CartMemento
{
    public class CartItemSnapshot
    {
        public FoodSnapshot Food { get; private set; }        
        public CartItemSnapshot(FoodSnapshot Food)
        {
            this.Food = Food;
        }
         
    }
}