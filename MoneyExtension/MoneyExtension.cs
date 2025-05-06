using System;
using System.Globalization;

namespace MoneyExtension
{
    public static class Money
    {
        public static int ToCents(this decimal amount)
        {
            if (amount < 0)
                return 0;

            var value = amount
                .ToString("F2", CultureInfo.InvariantCulture)
                .Replace(".", "");

            if (string.IsNullOrEmpty(value))
                return 0;

            int.TryParse(value, out var result);
            return result;
        }
    }
}
