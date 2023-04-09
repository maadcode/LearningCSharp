namespace CursoCSharp.FunctionalProgramming
{
    public class Actions
    {
        public static void WithoutParamsExample()
        {
            Action print = () => Console.WriteLine("Anonymous Function without params");
            print();
        }

        public static void WithParamsExample()
        {
            Action<string> print = (message) => Console.WriteLine(message);
            var message = "Anonymous Function wit params";
            print(message);
        }
    }
}
