using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Dog : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("Dog says: bark");
        }
    }
}
