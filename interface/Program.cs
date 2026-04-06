using Interface;

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.animalSound();

        Pig myPig = new Pig();
        myPig.animalSound();

        var mylvl = Gamelvl.Low;

        Console.WriteLine(mylvl);

        string folderPath = @"C:\Users\josep\OneDrive\Desktop\vbl\lettertoprotori.txt";

        // string writeText = "Hello Protori, give me tsh.";

        // File.WriteAllText(folderPath, writeText);

        string readText = File.ReadAllText(folderPath);
        Console.WriteLine(readText);


    }
}