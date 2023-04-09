namespace CursoCSharp.NativeLibraries
{
    public class Dates
    {
        public static void DateManipulationExample()
        {
            var currentDate = DateTime.Now;
            Console.WriteLine($"Year {currentDate.Year} / Month {currentDate.Month} / Day {currentDate.Day}");
            Console.WriteLine($"Date {currentDate.ToShortDateString()}");
            Console.WriteLine($"Date in other format {currentDate.ToString("dd-MM-yyyy")}");
            Console.WriteLine("One more day " + currentDate.AddDays(1));
            Console.WriteLine("An hour less " + currentDate.AddHours(-1));
            var specificDate = DateTime.Parse("2022/01/01");
            Console.WriteLine(specificDate);
            var specificDate2 = new DateTime(2022, 01, 02);
            Console.WriteLine(specificDate2);
        }
    }
}
