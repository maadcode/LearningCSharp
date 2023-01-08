using CursoCSharp.ObjectOrientedProgramming;

namespace CursoCSharp.NativeLibraries
{
    public class NativeLibrariesExample
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

        public static void FileAndDirectoryManipulationExample()
        {
            var path = @"C:\Users\Pc\Documents\VS2022 Projects\CursoCSharp\";
            var filePath = path + "test.txt";

            var content = File.ReadAllText(filePath);
            Console.WriteLine(content);
            File.AppendAllLines(filePath, new List<string> { "Maad", "Code"});
            var fileInfo = new FileInfo(filePath);
            Console.WriteLine(fileInfo.Extension);

            var existsDirectory = Directory.Exists(path);
            Console.WriteLine(existsDirectory);
            var directoryInfo = new DirectoryInfo(path);
            foreach (var file in directoryInfo.GetFiles())
            {
                Console.WriteLine(file.FullName);
            }
        }
    }
}
