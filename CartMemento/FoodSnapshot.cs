namespace CartMemento
{
    public class FoodSnapshot
    {
        public string Name { get; private set; }
        public FoodSnapshot(string Name)
        {
            this.Name = Name;
        }
        public Food FromSnapshot()
        {
            return new Food(Name);
        }
    }
}