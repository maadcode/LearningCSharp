namespace CursoCSharp.Extras
{
    public class Reader : IDisposable
    {
        private string _path;
        private StreamReader _stream;

        public Reader(string path)
        {
            _path = path;
            _stream = new StreamReader(path);
        }

        public void Dispose()
        {
            Console.WriteLine("Execute Dispose!");
        }

        public string ReadLine()
        {
            return _stream.ReadLine();
        }
    }
}
