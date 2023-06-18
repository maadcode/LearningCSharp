namespace CSharpFundamentals.FunctionalProgramming
{
    public class Delegates
    {
        public delegate void DelegateExample(string data);

        public static void MethodExample()
        {
            DelegateExample delegateMethod = PrintMessage;
            delegateMethod("I'm a delegate!");
        }

        private static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
