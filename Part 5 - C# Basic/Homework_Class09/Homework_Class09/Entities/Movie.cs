using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Class09.Entities
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; }

        public Movie(string title, Genre genre, int rating)
        {
            if (rating < 1 || rating > 5)
            {
                throw new Exception("Rating must be between 1 and 5");
            }
            if (string.IsNullOrEmpty(title))
            {
                throw new Exception("You must enter a title");
            }

            //if exception is not thrown
            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = 5 * rating;
        }
    }
}