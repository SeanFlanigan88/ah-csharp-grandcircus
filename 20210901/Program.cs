using System;
using System.Collections.Generic;
using System.Linq;

namespace _20210901
{
    public class Movie
    {
        private string _title = "";
        private string _category = string.Empty;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

        public Movie(string title, string category)
        {
            _title = title;
            _category = category;
        }

        public override string ToString()
        {
            return $"Title: {Title} Category: {Category}";
        }

    }


    public class Program
    {
        public static List<Movie> listOfMovies = new List<Movie>() 
        {
            new Movie("Imitation Game", "drama"),
            new Movie("Pulp fiction", "drama"),
            new Movie("The Fifth Element", "scifi"),
            new Movie("Serenity", "Scifi"),
            new Movie("SE7EN", "drama"),
            new Movie("Toy story", "animated"),
            new Movie("Spark of Genius", "drama"),
            new Movie("SAW", "horror"),
            new Movie("The Incredibles", "animated"),
            new Movie("The Incredibles 2", "animated")
        };

        public static void Main(string[] args)
        {
            SearchMoviesWithInput();
        }

        public static void SearchMoviesWithInput()
        {
            do
            {
                Console.WriteLine("Enter a move category:");
                var userInput = (Console.ReadLine()).Trim().ToLower();

                if (userInput == "")
                {
                    Console.WriteLine("Input should not be empty.");
                }

                var userChoice = listOfMovies.Where(s => s.Category == userInput);
                foreach (var item in userChoice)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.WriteLine("Would you like to continue searching? (yes/no)");
                userInput = (Console.ReadLine()).Trim().ToLower();
                if (userInput != "yes")
                {
                    break;
                }

            } while (true);
        }

        public static void SearchMovieList(string category)
        {
            foreach (var movie in listOfMovies)
            {
                if (movie.Category == category)
                {
                    Console.WriteLine($"Title: {movie.Title} Category: {movie.Category}");
                }
            }
        }
    }
}
