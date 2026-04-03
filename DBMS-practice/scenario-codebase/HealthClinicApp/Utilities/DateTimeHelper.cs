using System;
using System.Globalization;
using HealthClinicApp.Core.Exceptions;

namespace HealthClinicApp.Utilities
{
    public static class DateTimeHelper
    {
        private const string DateFormat = "dd-MM-yyyy";
        private const string TimeFormat = @"hh\:mm";

        public static DateTime ParseDate(string input)
        {
            input = input?.Trim();

            if (!DateTime.TryParseExact(
                input,
                DateFormat,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out var date))
            {
                throw new ValidationException(
                    $"Invalid date format. Expected {DateFormat}");
            }

            return date;
        }

        public static TimeSpan ParseTime(string input)
        {
            input = input?.Trim();

            if (!TimeSpan.TryParseExact(
                input,
                @"hh\:mm",
                CultureInfo.InvariantCulture,
                out var time))
            {
                throw new ValidationException(
                    $"Invalid time format. Expected {TimeFormat}");
            }

            return time;
        }

        public static string FormatDate(DateTime date)
        {
            return date.ToString(DateFormat);
        }

        public static string FormatTime(TimeSpan time)
        {
            return time.ToString(TimeFormat);
        }
    }
}
