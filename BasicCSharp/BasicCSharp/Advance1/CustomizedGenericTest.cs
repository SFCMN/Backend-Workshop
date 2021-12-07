using Xunit;

namespace BasicCSharp.Advance1
{
    public class CustomizedGenericTest
    {
        [Fact]
        public void should_return_correct_greeting_when_given_a_cat()
        {
            var cat = new Cat();
            var enabledSaidCat = new CustomizedGeneric<Cat>();
            var actualGreeting = enabledSaidCat.SayHi(cat);

            Assert.Equal("Hello, I am a cat!", actualGreeting);
        }
        [Fact]
        public void should_return_correct_greeting_when_given_a_dog()
        {
            var dog = new Dog();
            var enabledSaidDog = new CustomizedGeneric<Dog>();
            var actualGreeting = enabledSaidDog.SayHi(dog);

            Assert.Equal("Hello, I am a dog!", actualGreeting);
        }
        [Fact]
        public void should_return_correct_greeting_when_given_a_animal()
        {
            var animal = new Animal("bird");
            var enabledSaidAnimal = new CustomizedGeneric<Animal>();
            var actualGreeting = enabledSaidAnimal.SayHi(animal);

            Assert.Equal("Hello, I am a bird!", actualGreeting);
        }
        [Fact]
        public void should_can_not_be_compiled_when_not_given_a_animal()
        {
            // var enabledSaidAnimal = new CustomizedGeneric<string>();
        }
    }
}
