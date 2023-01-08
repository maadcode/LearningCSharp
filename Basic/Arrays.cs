namespace CursoCSharp.Basic
{
    public class Arrays
    {
        public static void ExampleVector()
        {
            Console.WriteLine("Declare the array with its size");
            string[] countries = new string[5];
            countries[0] = "Perú"; // index 0 and ^4
            countries[1] = "Colombia"; // index 1 and ^3
            countries[2] = "Bolivia"; // index 2 and ^2
            countries[3] = "Argentina"; // index 3 and ^1
            countries[4] = "Brasil"; // index 4 and ^0
            //countries[5] = "Chile"; // Index out range, this will give an error because the size is less than the index where you want to add the value

            Console.WriteLine("inverse index ^1 : " + countries[^1]); // inverse index
            Console.WriteLine("range of indexes 1 ~ 3 : " + string.Join(",", countries[1..3])); // range of indexes

            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }

            Console.WriteLine("Declare an array and assign its values on the same line");
            string[] countries2 = { "Perú", "Colombia", "Bolivia", "Argentina", "Brasil" }; // this will indicate the size of the array implicitly

            foreach (var country in countries2)
            {
                Console.WriteLine(country);
            }
        }
        public static void ExampleMultidimensional()
        {
            Console.WriteLine("Declare the array multidimensional with its size");
            string[,] countries = new string[2,2];
            countries[0,0] = "Perú";
            countries[0,1] = "Colombia";
            countries[1,0] = "Bolivia";
            countries[1,1] = "Argentina";

            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }

            Console.WriteLine("Declare an array multidimensional and assign its values on the same line");
            string[,] countries2 = { { "Perú", "Colombia" }, { "Bolivia", "Argentina" } };

            foreach (var country in countries2)
            {
                Console.WriteLine(country);
            }
        }
    }
}