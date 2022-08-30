using cSharpBasicRevision.Interfaces;
using System;

namespace cSharpBasicRevision.Models
{
    public class Dog : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("wo woo");
        }
    }
}
