using CSharpFundamentals.ObjectOrientedProgramming;
using System.Text.Json;

namespace CSharpFundamentals.NativeLibraries
{
    public class Https
    {
        public static async Task GetMethodExample()
        {
            var url = "https://jsonplaceholder.typicode.com/todos";
            var client = new HttpClient();
            var httpResponse = await client.GetAsync(url);
            if(httpResponse.IsSuccessStatusCode)
            {
                var content = await httpResponse.Content.ReadAsStringAsync();
                List<Todo> todos = JsonSerializer.Deserialize<List<Todo>>(content, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                foreach (var todo in todos)
                {
                    if(todo.Completed)
                        Console.WriteLine(todo.Title);
                }
            }
        }

        public static async Task PostMethodExample()
        {
            var url = "https://jsonplaceholder.typicode.com/todos";
            var todo = new Todo
            {
                UserId = 1,
                Title = "Test",
                Completed = true,
            };
            var data = JsonSerializer.Serialize(todo);
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var client = new HttpClient();
            var httpResponse = await client.PostAsync(url, content);
            if(httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();
                Console.WriteLine(result);
            }
        }

        public static async Task PutMethodExample()
        {
            var url = "https://jsonplaceholder.typicode.com/todos/199";
            var todo = new Todo
            {
                UserId = 1,
                Title = "Test",
                Completed = true,
            };
            var data = JsonSerializer.Serialize(todo);
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var client = new HttpClient();
            var httpResponse = await client.PutAsync(url, content);
            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();
                Console.WriteLine(result);
            }
        }

        public static async Task DeleteMethodExample()
        {
            var url = "https://jsonplaceholder.typicode.com/todos/199";
            var client = new HttpClient();
            var httpResponse = await client.DeleteAsync(url);
            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();
                Console.WriteLine(result);
            }
        }
    }
}
