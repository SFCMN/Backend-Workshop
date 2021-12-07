namespace BasicCSharp.Advance1
{
    public class Animal
    {
        public Animal() {}

        public Animal(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }

    public class Cat : Animal
    {
        public Cat() : base("cat") {}
    }

    public class Dog : Animal
    {
        public Dog() : base("dog") {}
    }
}
