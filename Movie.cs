using System.Collections.Generic;

namespace Tickets
{
    public class Movie
    {
        public string Title;
        public string Description;

        public Dictionary<string, Ticket> Showtimes = new Dictionary<string, Ticket>();

        public void AddShowtime(string time, float cost, int quantity)
        {
            Showtimes.Add(time, new Ticket(this, time, cost, quantity));
        }

        public Movie(string title, string description){
            Title = title;
            Description = description;
        }

    }
}