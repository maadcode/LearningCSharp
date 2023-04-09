namespace CursoCSharp.ObjectOrientedProgramming
{
    public class Dog : Animal
    {
        public Dog() : base("unknown", DateTime.Now)
        {

        }

        public Dog(string name) : base(name, DateTime.Now)
        {

        }

        public Dog(DateTime dateOfBirth) : base("unknown", dateOfBirth)
        {

        }

        public Dog(string name, DateTime dateOfBirth) : base(name, dateOfBirth)
        {
        }

        public override void Walk()
        {
            //Savor(); // You can't use it because is private, only in class Animal
            Console.WriteLine("Walking on all fours.");
            Sleep();
        }

        public string ToString()
        {
            return $"Objeto Dog llamado {Name}";
        }
    }
}
