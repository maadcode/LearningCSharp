namespace CursoCSharp.Basic
{
    public class Loops
    {
        public static void DoWhileExample()
        {
            var count = 0; // try with number 4, will enter the loop only once
            do
            {
                Console.WriteLine(count++);
            } while (count <= 3);
        }
        public static void WhileExample()
        {

            var count = 0; // try with number 4, will not enter the loop
            while (count <= 3)
            {
                Console.WriteLine(count++);
            }
        }
        public static void ForExample()
        {
            var count = 0;
            for (int i = 0; i <= 3; i++) // iterate a specified number of times
            {
                Console.WriteLine(count++);
            }
        }
        public static void ForeachExample()
        {
            var count = 0;
            //It is used to iterate collections.
            string[] countries = { "Perú", "Argentina", "Mexico" }; // array with size 3
            foreach (var country in countries)
            {
                Console.WriteLine(count);
                count++;
            }
        }
    }
}