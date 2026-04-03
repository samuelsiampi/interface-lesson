using Interface;

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.animalSound();

        Pig myPig = new Pig();
        myPig.animalSound();
    }
}