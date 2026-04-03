using System;

public class CallLogService
{
    private CallLog[] logs;
    private int count;

    public CallLogService(int size)
    {
        logs = new CallLog[size];
        count = 0;
    }

    // Add Call Log
    public void AddCallLog(CallLog log)
    {
        if (count < logs.Length)
        {
            logs[count++] = log;
        }
        else
        {
            Console.WriteLine("Call log storage full.");
        }
    }

    // Search by keyword in message
    public void SearchByKeyword(string keyword)
    {
        Console.WriteLine("\nSearch Results:");
        for (int i = 0; i < count; i++)
        {
            if (logs[i].Message.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                Display(logs[i]);
            }
        }
    }

    // Filter by time range
    public void FilterByTime(DateTime start, DateTime end)
    {
        Console.WriteLine("\nFiltered Logs:");
        for (int i = 0; i < count; i++)
        {
            if (logs[i].Timestamp >= start && logs[i].Timestamp <= end)
            {
                Display(logs[i]);
            }
        }
    }

    private void Display(CallLog log)
    {
        Console.WriteLine($"{log.PhoneNumber} | {log.Message} | {log.Timestamp}");
    }
}
