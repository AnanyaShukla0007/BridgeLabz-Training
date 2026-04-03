using System;
using System.Collections.Generic;
using StreamBuzz.Models;
using StreamBuzz.Services;

namespace StreamBuzz.Menu
{
    public class StreamBuzzMenu
    {
        public void Start()
        {
            EngagementService service = new EngagementService();
            int choice = 0;

            while (choice != 4)
            {
                Console.WriteLine();
                Console.WriteLine("1. Register Creator");
                Console.WriteLine("2. Show Top Posts");
                Console.WriteLine("3. Calculate Average Likes");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                Console.WriteLine("Enter your choice:");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        RegisterCreatorFlow(service);
                        break;

                    case 2:
                        ShowTopPostsFlow(service);
                        break;

                    case 3:
                        double avg = service.CalculateAverageLikes();
                        Console.WriteLine("Overall average weekly likes: " + avg);
                        break;

                    case 4:
                        Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                        break;
                }
            }
        }

        private void RegisterCreatorFlow(EngagementService service)
        {
            Console.WriteLine("Enter Creator Name:");
            string name = Console.ReadLine();

            double[] likes = new double[4];
            Console.WriteLine("Enter weekly likes (Week 1 to 4):");

            for (int i = 0; i < 4; i++)
            {
                likes[i] = Convert.ToDouble(Console.ReadLine());
            }

            CreatorStats creator = new CreatorStats
            {
                CreatorName = name,
                WeeklyLikes = likes
            };

            service.RegisterCreator(creator);
            Console.WriteLine("Creator registered successfully");
        }

        private void ShowTopPostsFlow(EngagementService service)
        {
            Console.WriteLine("Enter like threshold:");
            double threshold = Convert.ToDouble(Console.ReadLine());

            Dictionary<string, int> result =
                service.GetTopPostCounts(CreatorStats.EngagementBoard, threshold);

            if (result.Count == 0)
            {
                Console.WriteLine("No top-performing posts this week");
                return;
            }

            foreach (KeyValuePair<string, int> entry in result)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
