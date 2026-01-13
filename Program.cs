namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            PrintFizzBuzz();
        }

        static void PrintFizzBuzz()
        {
            Console.WriteLine("Welcome to FizzBuzz. Please enter a number: ");
            string input = Console.ReadLine();

            int parsedNumber = 0;
            if (input == null || !int.TryParse(input, out parsedNumber))
            {
                Console.WriteLine("Please enter a valid number.");
                PrintFizzBuzz();
            }

            Console.WriteLine("------");

            for (int x = 1; x <= parsedNumber; x++)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (x % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(x);
                }
            }            
        }
    }
}
