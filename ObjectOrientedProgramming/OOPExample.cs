namespace CursoCSharp.ObjectOrientedProgramming
{
    public class OOPExample
    {
        public static void ObjectsAndClasesExample()
        {
            var animal = new Dog();
            var animal2 = new Duck("Donald", DateTime.Parse("1/1/2023"));
        }

        public static void ConstructorOverloadExample()
        {
            var dog1 = new Dog();
            var dog2 = new Dog("Gufy");
            var dog3 = new Dog("Pluto", DateTime.Parse("1/1/2023"));
        }

        public static void MethodOverloadExample()
        {
            var animal = new Dog();
            animal.Eat();
            animal.Eat("pizza");
        }

        public static void AbstractionExample()
        {
            //var animal = new Animal(); // can't be instantiated because is an abstract class
            var animal2 = new Dog();
        }

        public static void InheritanceExample()
        {
            Animal dog = new Dog();
            Animal duck = new Duck("Donald", DateTime.Parse("1/1/2023"));
        }

        public static void EncapsulationExample()
        {
            Animal dog = new Dog();
            dog.Eat(); // can be used because it's public
            //dog.Sleep(); // can't be used because it's protected
            //dog.Savor(); // can't be used because it's private
        }

        public static void PolymorphismExample()
        {
            Animal animal1 = new Dog();
            Animal animal2 = new Duck("Donald", DateTime.Parse("1/1/2023"));

            animal1.Walk();
            animal2.Walk();
        }
    }
}
