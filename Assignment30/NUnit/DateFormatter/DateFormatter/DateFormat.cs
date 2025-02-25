using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateFormatter
{
    public class DateFormat
    {
        public string FormatDate(string inputDate)
        {
            if (string.IsNullOrEmpty(inputDate))
            {
                throw new ArgumentException("Input date cannot be null or empty.");
            }

            DateTime parsedDate;
            if (DateTime.TryParseExact(inputDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                return parsedDate.ToString("dd-MM-yyyy");
            }
            else
            {
                throw new FormatException("Invalid date format.");
            }
        }

    }
}
