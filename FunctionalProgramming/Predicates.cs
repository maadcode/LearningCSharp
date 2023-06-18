using CSharpFundamentals.ObjectOrientedProgramming;

namespace CSharpFundamentals.FunctionalProgramming
{
    public class Predicates
    {
        public static void MethodExample()
        {

            var todosList = new List<Todo> { 
                new Todo
                {
                    Id = 1,
                    UserId = 1,
                    Title = "Test 1",
                    Completed = true,
                },
                new Todo
                {
                    Id = 2,
                    UserId = 1,
                    Title = "Test 2",
                    Completed = false,
                },
            };
            Predicate<Todo> filterTodoCompleted = x => x.Completed;
            foreach (var todo in todosList)
            {
                if(filterTodoCompleted(todo))
                    Console.WriteLine(todo.Title);
            }
        }
    }
}
