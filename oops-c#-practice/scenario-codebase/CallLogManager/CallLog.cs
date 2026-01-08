using System;

public class CallLog
{
    public string PhoneNumber { get; set; }
    public string Message { get; set; }
    public DateTime Timestamp { get; set; }

    public CallLog(string phoneNumber, string message, DateTime timestamp)
    {
        PhoneNumber = phoneNumber;
        Message = message;
        Timestamp = timestamp;
    }
}
