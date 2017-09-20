namespace Tickets
{
   public class Ticket : IPurchasable
    {
        Movie Movie;
        public string Time; 
        public float Cost { get; set; }
        public int Inventory { get; set; }

        public void Purchase(int quantity)
        {
             if(Inventory-quantity>=0){
                Inventory-= quantity;
            }
            else
            {
                System.Console.WriteLine($"Sorry, there are { (Inventory == 0 ? "none" : "only " + Inventory) } left" );
            }
        }

        public Ticket(Movie movie, string time, float cost, int inventory){
            Movie = movie;
            Time = time;
            Cost = cost;
            Inventory = inventory;
        }
    }
}