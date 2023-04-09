namespace CursoCSharp.FunctionalProgramming
{
    public class Funcs
    {
        public static void PureFunctionExample()
        {
            Func<int, int, int> multiply = (x, y) => x * y;
            Console.WriteLine(multiply(11, 22));
            Console.WriteLine(multiply(11, 22));
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
            Func<int, int> doubleFunction = x => x * 2;
            Func<int, int> sumFunction = x => x + 10;

            Func<Func<int, int>, Func<int, int>, Func<int, int>> compose = (f, g) => x => g(f(x));

            Func<int, int> composedFunction = compose(doubleFunction, sumFunction);

            Console.WriteLine(composedFunction(5));
        }
    }
}
