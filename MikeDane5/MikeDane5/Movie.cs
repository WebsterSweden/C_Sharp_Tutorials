using System;
using System.Collections.Generic;
using System.Text;

namespace MikeDane5
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string titleParameter, string directorParameter, string ratingParameter)
        {
            title = titleParameter;
            director = directorParameter;
            Rating = ratingParameter;
        }

        // Getters & Setters.
        public string Rating
        {
            get
            {
                return rating;
            }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
