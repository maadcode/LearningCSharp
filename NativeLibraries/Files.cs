namespace CSharpFundamentals.NativeLibraries
{
    public class Files
    {
        public static void FileAndDirectoryManipulationExample()
        {
            var path = @"C:\Users\Pc\Documents\VS2022 Projects\CSharpFundamentals\";
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
