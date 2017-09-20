namespace Tickets
{
    public class Food : IPurchasable
    {
        public string Name;
        public float Cost { get; set; }
        public int Inventory { get; set; }
        public void Purchase(int quantity)
        {
            if(Inventory-quantity>=0){
                Inventory-= quantity;
            }
            else
            {
                System.Console.WriteLine($"Sorry, there are { (Inventory == 0 ? "none" : "only "+Inventory)} left" );
            }
        }

        public Food(string name, float cost, int inventory)
        {
            Name = name;
            Cost = cost;
            Inventory = inventory;
        }

    }
}