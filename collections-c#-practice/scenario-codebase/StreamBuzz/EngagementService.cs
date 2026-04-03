using System.Collections.Generic;
using StreamBuzz.Models;

namespace StreamBuzz.Services
{
    public class EngagementService
    {
        // Register creator
        public void RegisterCreator(CreatorStats record)
        {
            CreatorStats.EngagementBoard.Add(record);
        }

        // Count weeks >= threshold
        public Dictionary<string, int> GetTopPostCounts(
            List<CreatorStats> records, double likeThreshold)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            for (int i = 0; i < records.Count; i++)
            {
                CreatorStats creator = records[i];
                int count = 0;

                for (int j = 0; j < creator.WeeklyLikes.Length; j++)
                {
                    if (creator.WeeklyLikes[j] >= likeThreshold)
                    {
                        count++;
                    }
                }

                if (count > 0)
                {
                    result.Add(creator.CreatorName, count);
                }
            }

            return result;
        }

        // Calculate overall average
        public double CalculateAverageLikes()
        {
            double total = 0;
            int count = 0;

            for (int i = 0; i < CreatorStats.EngagementBoard.Count; i++)
            {
                double[] likes = CreatorStats.EngagementBoard[i].WeeklyLikes;

                for (int j = 0; j < likes.Length; j++)
                {
                    total += likes[j];
                    count++;
                }
            }

            if (count == 0)
                return 0;

            return total / count;
        }
    }
}
