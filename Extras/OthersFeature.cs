namespace CSharpFundamentals.Extras
{
    public class OthersFeature
    {
        public static void StaticLocalFunciontsExample()
        {
            int numberOne = 10;
            int numberTwo = 20;
            Console.WriteLine(Addition(numberOne, numberTwo));

            static int Addition(int num1, int num2) => num1 + num2;
        }

        public static void UsingDeclarationExample()
        {
            var path = @"C:\Users\Pc\Documents\VS2022 Projects\CSharpFundamentals\test.txt";

            Console.WriteLine("Without using declaration");
            var response = string.Empty;
            using (var stream = new Reader(path))
            {
                response = stream.ReadLine();
            }
            Console.WriteLine(response);

            Console.WriteLine("With using declaration");
            var response2 = string.Empty;
            using var stream2 = new Reader(path);
            response2 = stream2.ReadLine();
            Console.WriteLine(response2);
        }
    }
}
