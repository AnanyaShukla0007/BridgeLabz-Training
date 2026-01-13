using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning.CinemaTime
{
    internal class Movie
    {
        private string title;
        private string director;
        private string summary;
        private double imdbRating;

        public Movie(string title, string director, string summary, double imdbRating)
        {
            this.title = title;
            this.director = director;
            this.summary = summary;
            this.imdbRating = imdbRating;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetDetails()
        {
            return title + " | Director: " + director +
                   " | IMDb: " + imdbRating;
        }
    }
}

