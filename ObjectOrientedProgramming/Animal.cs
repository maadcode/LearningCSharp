namespace CSharpFundamentals.ObjectOrientedProgramming
{
    public abstract class Animal
    {
        private DateTime _dateOfBirth;
        private string _color;
        public string Name { get; set; }
        public string Color
        {
            get => _color;
            set => _color = value;
        }
        public DateTime DateOfBirth { 
            get 
            {
                return _dateOfBirth.AddDays(1);
            }
            
            set {
                _dateOfBirth = value.AddDays(-1);
            } 
        }

        public Animal(string name, DateTime dateOfBirth)
        {
            Name = name;
            _dateOfBirth = dateOfBirth;
            _color = string.Empty;
        }

        public Animal(string name)
        {
            Name = name.ToUpper();
            _dateOfBirth = DateTime.Now;
            _color = string.Empty;
        }
        public Animal()
        {
            Name = "Sin nombre";
            _color = string.Empty;
        }

        private void Savor()
        {
            Console.WriteLine("Mmm.");
        }

        protected void Sleep()
        {
            Console.WriteLine("ZzZz...");
        }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
        public void Eat(string food)
        {
            Savor();
            Console.WriteLine("Eating " + food);
            Sleep();
        }

        public abstract void Walk();
    }
}
