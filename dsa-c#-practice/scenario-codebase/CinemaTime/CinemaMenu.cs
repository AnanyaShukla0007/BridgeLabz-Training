using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning.CinemaTime
{
    internal class CinemaMenu
    {
        private IMovieActions actions = new CinemaUtility();

        public void Start()
        {
            int choice;
            do
            {
                Console.WriteLine("\n1.Add  2.Search  3.View All  4.Export  5.Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        actions.AddMovie();
                        break;
                    case 2:
                        actions.SearchMovie();
                        break;
                    case 3:
                        actions.DisplayAllMovies();
                        break;
                    case 4:
                        actions.ExportReport();
                        break;
                }
            } while (choice != 5);
        }
    }
}

