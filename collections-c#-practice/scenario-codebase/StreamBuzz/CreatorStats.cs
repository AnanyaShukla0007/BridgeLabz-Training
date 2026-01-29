using System.Collections.Generic;

namespace StreamBuzz.Models
{
    public class CreatorStats
    {
        public string CreatorName { get; set; }
        public double[] WeeklyLikes { get; set; }

        // Given static list (as per problem)
        public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();
    }
}
