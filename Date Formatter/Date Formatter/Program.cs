using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Formatter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region -- Date Formatter --
            Console.WriteLine("Date Formatter");
            // Date Formatter //

            Console.Write("Enter number of a Month : ");
            var month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Date : ");
            var date = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Year : ");
            var year = Convert.ToInt32(Console.ReadLine());

            string dateString = $"{month}/{date}/{year}";

            string format = "M/d/yyyy";

            DateTime parsedDate;

            bool isValidDate = DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate);

            if (isValidDate)
            {

                switch (month)
                {
                    case 1:
                        Console.WriteLine($"January {date}, {year}");
                        break;
                    case 2:
                        Console.WriteLine($"February {date}, {year}");
                        break;
                    case 3:
                        Console.WriteLine($"March {date}, {year}");
                        break;
                    case 4:
                        Console.WriteLine($"April {date}, {year}");
                        break;
                    case 5:
                        Console.WriteLine($"May {date}, {year}");
                        break;
                    case 6:
                        Console.WriteLine($"June {date}, {year}");
                        break;
                    case 7:
                        Console.WriteLine($"July {date}, {year}");
                        break;
                    case 8:
                        Console.WriteLine($"August {date}, {year}");
                        break;
                    case 9:
                        Console.WriteLine($"September {date}, {year}");
                        break;
                    case 10:
                        Console.WriteLine($"October {date}, {year}");
                        break;
                    case 11:
                        Console.WriteLine($"November {date}, {year}");
                        break;
                    case 12:
                        Console.WriteLine($"December {date}, {year}");
                        break;
                    default:
                        Console.WriteLine($"Invalid Month");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Month/Date, Month must not exceed 12 and the Date must not exceed 31");
            }

            #endregion

            Console.ReadLine();
        }
    }
}
