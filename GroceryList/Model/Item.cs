namespace GroceryList.Model
{
    class Item
    {
        public string Name { get; }
        public double Price { get; }
        
        public Item(string na, double pr)
        {
            Name = na;
            Price = pr;
        }
    }
}

//Item it = new Item();
//string na = it.Name;
//it.Name = "Juan";
