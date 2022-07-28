// See https://aka.ms/new-console-template for more information
/* This is my first C# project 
   Here we have a simple console application. 
   My main goal is to lear the basic syntaxis.
*/
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {//We can manage to write on the console with
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}


