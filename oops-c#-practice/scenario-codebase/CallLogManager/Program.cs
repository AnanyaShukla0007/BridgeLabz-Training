using System;

class Program
{
    static void Main()
    {
        CallLogService service = new CallLogService(5);

        service.AddCallLog(new CallLog("9876543210", "Network issue reported", DateTime.Now.AddHours(-2)));
        service.AddCallLog(new CallLog("9123456780", "Billing related query", DateTime.Now.AddHours(-1)));
        service.AddCallLog(new CallLog("9988776655", "Call drop problem", DateTime.Now));

        service.SearchByKeyword("issue");

        DateTime start = DateTime.Now.AddHours(-3);
        DateTime end = DateTime.Now.AddMinutes(-30);

        service.FilterByTime(start, end);
    }
}
