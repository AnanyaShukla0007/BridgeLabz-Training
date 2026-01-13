using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning.CinemaTime
{
    internal class ShowTime
    {
        private string time;
        private string screen;
        private string language;

        public ShowTime(string time, string screen, string language)
        {
            this.time = time;
            this.screen = screen;
            this.language = language;
        }

        public string GetShowDetails()
        {
            return time + " | Screen: " + screen +
                   " | Language: " + language;
        }
    }
}

