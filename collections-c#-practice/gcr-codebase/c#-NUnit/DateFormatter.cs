using System;

public class DateFormatter
{
    public string FormatDate(string input)
    {
        DateTime dt = DateTime.ParseExact(input, "yyyy-MM-dd", null);
        return dt.ToString("dd-MM-yyyy");
    }
}
