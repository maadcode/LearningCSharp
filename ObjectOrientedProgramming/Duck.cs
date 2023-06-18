namespace CSharpFundamentals.ObjectOrientedProgramming
{
    public class Duck : Animal, IFly
    {
        public Duck(string name, DateTime dateOfBirth) : base(name, dateOfBirth)
        {
        }

        public void Fly()
        {
            Console.WriteLine("duck is flying.");
        }

        public override void Walk()
        {
            Console.WriteLine("Walking on two legs.");
        }
    }
}
