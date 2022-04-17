// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// I am just playing around here. Really wanna knnow the difference betweeen git pull and push

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("What is your name?");
                var name = Console.ReadLine();
                var currentDate = DateTime.Now;
                Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
                Console.Write($"{Environment.NewLine}Press any key to exit...");
                Console.ReadKey(true);
        }
    }
}
