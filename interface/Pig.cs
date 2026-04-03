using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Pig : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("Pig says: oink");
        }
    }
}
