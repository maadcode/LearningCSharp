using CursoCSharp.Extras;

namespace CursoCSharp.Intermediate
{
    public class Exceptions
    {
        public static void TryCatchExample()
        {
            try
            {
                var country = GetCountry();
                country.Name = "Unknown";
                Console.WriteLine("End try block");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception! " + ex.Message);
            }
        }

        public static void MultipleExceptionExample()
        {
            try
            {
                var country = GetCountry();
                country.Name = "Unknown";
                Console.WriteLine("End try block");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("ArgumentNullException! " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException! " + ex.Message);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("ArithmeticException! " + ex.Message);
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine("ExceStackOverflowExceptionption! " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception! " + ex.Message);
            }
        }

        public static void FinallyExample()
        {
            try
            {
                var country = GetCountry();
                country.Name = "Unknown";
                Console.WriteLine("End try block");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception! " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Always runs");
            }
        }

        public static void CustomExceptionExample()
        {
            try
            {
                Console.WriteLine("Start try block");
                throw new CustomException("I'm a custom error.");
                Console.WriteLine("End try block");
            }
            catch (CustomException ex)
            {
                Console.WriteLine("CustomException! " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception! " + ex.Message);
            }
        }

        private static Country GetCountry()
        {
            return null;
        }
    }

    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {

        }
    }
}
