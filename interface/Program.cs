using Interface;

class Program
{
    static void Main(string[] args)
    {
        /*
        Dog myDog = new Dog();
        myDog.animalSound();

        Pig myPig = new Pig();
        myPig.animalSound();

        var mylvl = Gamelvl.Low;

        Console.WriteLine(mylvl);
        */

        string folderPath = @"C:\Users\josep\OneDrive\Desktop\vbl\lettertoprotori.txt";

        string writeText = "Hello Protori, give me tsh.";

        try
        {
            File.WriteAllText(folderPath, writeText);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


        try
        {
            string readText = File.ReadAllText(folderPath);
            Console.WriteLine(readText);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}