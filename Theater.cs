//list of movies : iPurchaseable

//ticket class

//list of food : iPurchaseable


using System.Collections.Generic;

namespace Tickets
{
    public class Theater
    {
        string Name;
        public List<Movie> Movies = new List<Movie>();

        public List<Food> Foods = new List<Food>();



        public void AddMovie(Movie movie){
            Movies.Add(movie);
        }

        public Theater(string name)
        {
            Name = name;
        }


    }



}