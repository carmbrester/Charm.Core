using System;

namespace Charm.Core
{
    public static class DateTimeExtensions
    {
        public static bool IsEarlierDateThan(this DateTime sourceDate, DateTime targetDate)
        {
            return DateTime.Compare(sourceDate.Date, targetDate.Date) < 0;
        }

        public static bool IsLaterDateThan(this DateTime sourceDate, DateTime targetDate)
        {
            return DateTime.Compare(sourceDate.Date, targetDate.Date) > 0;
        }

        public static bool IsBetween(this DateTime Value, DateTime ValueMin, DateTime ValueMax)
        {
            return ((Value >= ValueMin) && (Value <= ValueMax));
        }
        public static bool IsBetween(this DateTime Value, DateTime? ValueMin, DateTime? ValueMax)
        {
            if (ValueMin == null || ValueMax == null)
            {
                return false;
            }

            DateTime? nullableDate = Value;
            return ((nullableDate >= ValueMin) && (nullableDate <= ValueMax));
        }
    }
}
