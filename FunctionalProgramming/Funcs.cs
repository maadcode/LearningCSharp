using System.Linq;

namespace CSharpFundamentals.FunctionalProgramming
{
    public class Funcs
    {
        public static void PureFunctionExample()
        {
            Func<int, int, int, int> multiply = (x, y, z) => x * y;
            Console.WriteLine(multiply(11, 22, 5));
            Console.WriteLine(multiply(11, 22, 5));
        }

        public static void HightOrderMethodExample()
        {
            Func<List<int>, Func<int, bool>, List<int>> filter = (xs, f) =>
            {
                var result = new List<int>();
                foreach (var x in xs)
                {
                    if (f(x))
                    {
                        result.Add(x);
                    }
                }
                return result;
            };

            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var evenNumbers = filter(numbers, x => x % 2 == 0);
            evenNumbers.ForEach(x => { Console.WriteLine(x); });
        }

        public static void CompositionMethodExample()
        {
            var paises = new List<string> { "Peru", "Mexico", "Argentina", "Paraguay" };
            var paisesFiltrados = paises
                .Where(x => x.StartsWith("P"))
                .Select(x => x.ToUpper())
                .OrderBy(x => x);
            foreach (var item in paisesFiltrados)
                Console.WriteLine(item);
            Console.WriteLine("--------------------");
            foreach (var item in paises)
                Console.WriteLine(item);
        }
    }
}
