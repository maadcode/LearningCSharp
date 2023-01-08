namespace CursoCSharp.Basic
{
    public class Variables
    {
        public static void ExampleImplicit()
        {
            // declares the variable with the implicit data type
            var name = "Maadcode";
            Console.WriteLine(name + " data type: " + name.GetType());
        }
        public static void ExampleExplicit()
        {
            // declares the variable with the explicit data type
            string name = "Maadcode";
            Console.WriteLine(name + " data type: " + name.GetType());
        }
    }
}
