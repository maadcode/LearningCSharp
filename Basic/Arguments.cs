namespace CSharpFundamentals.Basic
{
    public class Arguments
    {
        public static void OptionalArgumentsExample()
        {
            FunctionWithArguments(20, "Maad");
            FunctionWithArguments(21);
        }

        public static void SpecificNameArgumentsExample()
        {
            FunctionWithArguments(22, "Maadcode");
            FunctionWithArguments(optional: "Maadcode", number: 22);
        }

        private static void FunctionWithArguments(int number, string optional = "unknown")
        {
            Console.WriteLine("optional value {0} number {1}", optional, number);
        }
    }
}
