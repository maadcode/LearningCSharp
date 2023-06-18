namespace CSharpFundamentals.Basic
{
    public class Variables
    {
        public static void ImplicitExample()
        {
            // declares the variable with the implicit data type
            var name = "Maadcode";
            Console.WriteLine(name + " data type: " + name.GetType());
        }
        public static void ExplicitExample()
        {
            // declares the variable with the explicit data type
            string name = "Maadcode";
            Console.WriteLine(name + " data type: " + name.GetType());
        }
    }
}
