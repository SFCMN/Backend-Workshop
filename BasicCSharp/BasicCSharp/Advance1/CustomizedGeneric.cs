using System;

namespace BasicCSharp.Advance1
{
    public class CustomizedGeneric<T> where T : Animal, new()
    {
        public string SayHi(T animal)
        {
            return "Hello, I am a " + animal.Name + "!";
        }
    }
}
