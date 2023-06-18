namespace CSharpFundamentals.Intermediate
{
    public class Generics
    {
        public static void GenericExample()
        {
            var response = Response<string>.Ok("Maad");
            var response2 = Response<int>.Ok(200);
            //var response3 = Response<string>.Ok(123); // Error, because we are declaring the string data type and an integer is passed to it.
        }
    }

    public class Response<T>
    {
        public bool Success { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
        public T Result { get; set; }

        public static Response<T> Error(List<string> errors) => new Response<T>(errors);

        public static Response<T> Error(string error) => new Response<T>(new List<string> { error });

        public static Response<T> Error() => new Response<T>(new List<string> ());

        public static Response<T> Ok(T response) => new Response<T>(response);

        protected Response(T response)
        {
            Success = true;
            Result = response;
        }

        protected Response(List<string> errors)
        {
            Success = false;
            Errors = new List<string>();
            Errors.AddRange(errors);
        }
    }
}
