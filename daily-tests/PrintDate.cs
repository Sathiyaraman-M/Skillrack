using System;
using System.Linq;
 
namespace Hello
{
    class Hello
    {
        public static DateTime GetDate(string date)
        {
            var tokens = date.Split('/').Select(x => int.Parse(x)).ToList();
            try
            {
                return new DateTime(tokens[2], tokens[1], tokens[0]);
            }
            catch(Exception)
            {
                return DateTime.MinValue;
            }
        }

        static void Main(string[] args)
        {
            var dates = Console.ReadLine().Trim().Split(' ').Select(x => GetDate(x)).ToList();
            Console.WriteLine(dates.Max() != DateTime.MinValue ? dates.Max().ToString("dd/MM/yyyy") : "-1");
        }
    }
}
