namespace CursoCSharp.Basic
{
    public class Parameters
    {
        public static void ExampleWithParams()
        {
            MethodWithParamsParameters("Maad", "maadcode.dev", 2023, true);
        }
        public static void ExampleWithObject()
        {
            Object[] obj = { "Maad", "maadcode.dev", 2023, true };
            MethodWithObjectParameters(obj);
        }
        public static void ExampleWithRef()
        {
            var value = "Hello!";
            MethodWithRefParameter(ref value);
            Console.WriteLine(value);
        }

        public static void ExampleWithIn()
        {
            var value = "Hello!";
            MethodWithInParameter(value);
            Console.WriteLine(value);
        }
        public static void ExampleWithOut()
        {
            var value = "Hello!";
            MethodWithOutParameter(out value);
            Console.WriteLine(value);
        }

        private static void MethodWithParamsParameters(params object[] parameters)
        {
            var name = parameters[0];
            Console.WriteLine($"{name} - data type: ${name.GetType()}");
            var website = parameters[1];
            Console.WriteLine($"{website} - data type: ${website.GetType()}");
            var year = parameters[2];
            Console.WriteLine($"{year} - data type: ${year.GetType()}");
            var isOpen = parameters[3];
            Console.WriteLine($"{isOpen} - data type: ${isOpen.GetType()}");
        }
        private static void MethodWithObjectParameters(object[] parameters)
        {
            var name = parameters[0];
            Console.WriteLine($"{name} - data type: ${name.GetType()}");
            var website = parameters[1];
            Console.WriteLine($"{website} - data type: ${website.GetType()}");
            var year = parameters[2];
            Console.WriteLine($"{year} - data type: ${year.GetType()}");
            var isOpen = parameters[3];
            Console.WriteLine($"{isOpen} - data type: ${isOpen.GetType()}");
        }

        private static void MethodWithRefParameter(ref string value)
        {
            value = "New value";
        }

        private static void MethodWithInParameter(in string value)
        {
            //value = "Hi"; // error, because value is readonly
        }

        private static void MethodWithOutParameter(out string value)
        {
            value = "New value";
        }
    }
}
