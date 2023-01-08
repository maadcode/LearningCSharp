using System.Collections;

namespace CursoCSharp.Intermediate
{
    public class Collections
    {
        public static void ExampleWithList()
        {
            var countries = new List<string>();
            countries.Add("Perú");
            //countries.Add(true); // can't add other data type

            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }
        }
        public static void ExampleWithArrayList()
        {
            var dynamicValueList = new ArrayList();
            dynamicValueList.Add("Maad");
            dynamicValueList.Add(true);
            dynamicValueList.Add(10.0);

            foreach (var value in dynamicValueList)
            {
                Console.WriteLine(value);
            }
        }
        public static void ExampleWithSortedList()
        {
            var dynamicValueList = new SortedList();
            dynamicValueList.Add(3, "Maad"); // Key, value
            dynamicValueList.Add(2, true);
            dynamicValueList.Add(1, 10.0);

            foreach (var value in dynamicValueList.Values) // Iterate values
            {
                Console.WriteLine(value);
            }

            foreach (var value in dynamicValueList.Keys) // Iterate keys
            {
                Console.WriteLine(value);
            }
        }
        public static void ExampleWithDictionary()
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("name", "Maad");
            //dictionary.Add("age", 22); // can't add other data type
            dictionary.Add("age", "22 years old");

            foreach (var value in dictionary.Values) // Iterate values
            {
                Console.WriteLine(value);
            }

            foreach (var value in dictionary.Keys) // Iterate keys
            {
                Console.WriteLine(value);
            }
        }
        public static void ExampleWithHashtable()
        {
            var hash = new Hashtable();
            hash.Add("name", "Maad");
            hash.Add("age", 22);

            foreach (var value in hash.Values) // Iterate values
            {
                Console.WriteLine(value);
            }

            foreach (var value in hash.Keys) // Iterate keys
            {
                Console.WriteLine(value);
            }
        }
        public static void ExampleWithStack()
        {
            var stack = new Stack();
            stack.Push("Maad");
            stack.Push(20);
            stack.Push(DateTime.Now);

            foreach (var value in stack)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("FILO, First In Last Out");
            stack.Pop();
            foreach (var value in stack)
            {
                Console.WriteLine(value);
            }

        }
        public static void ExampleWithQueue()
        {
            var queue = new Queue();
            queue.Enqueue("Maad");
            queue.Enqueue(20);
            queue.Enqueue(DateTime.Now);

            foreach (var value in queue)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("FIFO, First In First Out");
            queue.Dequeue();
            foreach (var value in queue)
            {
                Console.WriteLine(value);
            }
        }
    }
}
