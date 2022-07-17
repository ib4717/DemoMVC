using System;

namespace DemoMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }

        public Movie(int Id, string Name, int Year, int Rating)
        {
            this.Id = Id;
            this.Name = Name;
            this.Year = Year;
            this.Rating = Rating;
        }
    }
}

