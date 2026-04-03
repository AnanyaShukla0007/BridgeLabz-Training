using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning.FitTrack
{
    internal class UserProfile
    {
        public string UserName { get; set; }

        public UserProfile(string userName)
        {
            UserName = userName;
        }

        public void DisplayUser()
        {
            Console.WriteLine("User: " + UserName);
        }
    }
}
