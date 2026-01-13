using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning.CinemaTime
{
    internal sealed class CinemaUtility : IMovieActions
    {
        private Movie[] movies = new Movie[50];
        private ShowTime[] showTimes = new ShowTime[50];
        private int count = 0;

        public void AddMovie()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Director: ");
            string director = Console.ReadLine();

            Console.Write("Summary: ");
            string summary = Console.ReadLine();

            Console.Write("IMDb Rating: ");
            double rating = Convert.ToDouble(Console.ReadLine());

            Console.Write("Show Time: ");
            string time = Console.ReadLine();

            Console.Write("Screen: ");
            string screen = Console.ReadLine();

            Console.Write("Language: ");
            string language = Console.ReadLine();

            movies[count] = new Movie(title, director, summary, rating);
            showTimes[count] = new ShowTime(time, screen, language);
            count++;

            Console.WriteLine("Movie added successfully.");
        }

        public void SearchMovie()
        {
            Console.Write("Enter keyword: ");
            string keyword = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (movies[i].GetTitle()
                    .Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(
                        movies[i].GetDetails() + " | " +
                        showTimes[i].GetShowDetails());
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No movie found.");
        }

        public void DisplayAllMovies()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(
                    movies[i].GetDetails() + " | " +
                    showTimes[i].GetShowDetails());
            }
        }

        public void ExportReport()
        {
            Movie[] exportMovies = new Movie[count];
            Array.Copy(movies, exportMovies, count);

            Console.WriteLine("Printable Report:");
            for (int i = 0; i < exportMovies.Length; i++)
            {
                Console.WriteLine(
                    exportMovies[i].GetDetails() + " | " +
                    showTimes[i].GetShowDetails());
            }
        }
    }
}
