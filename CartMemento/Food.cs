namespace CartMemento
{
    public class Food
    {
        public string Name { get; private set; }
        public Food(string Name)
        {
            this.Name = Name;
        }
        public FoodSnapshot CreateSnapshot()
        {
            return new FoodSnapshot(this.Name);
        }
        private FoodSnapshot CreateFoodSnapshot(Food food)
        {
            return new FoodSnapshot(food.Name);
        }
        // Restores the Originator's state from a memento object.
        public void Restore(FoodSnapshot memento)
        {
            this.Name = memento.Name;
        }
    }

}
