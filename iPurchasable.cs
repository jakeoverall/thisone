namespace Tickets
{
    interface IPurchasable 
    {
       float Cost { get; set; }
       int Inventory { get; set; }


       void Purchase(int quantity);


   }


}