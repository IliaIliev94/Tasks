using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.MovieStar
{
    public class MovieStar
    {

        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Sex { get; set; }
        public string? Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int Age { 
            get 
            {
                return new DateTime((DateTime.UtcNow - DateOfBirth).Ticks).Year - 1;
            } 
        }

        public override string ToString()
        {
            StringBuilder movieStar = new StringBuilder();
            movieStar.AppendLine($"{Name} {Surname}");
            movieStar.AppendLine(Sex);
            movieStar.AppendLine(Nationality);
            movieStar.AppendLine($"{Age} years old");

            return movieStar.ToString();
        }
    }
}
