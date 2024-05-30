using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the position of the Fibonacci number you want: ");
            int position = int.Parse(Console.ReadLine());

            int result = Fibonacci(position);
            Console.WriteLine($"Fibonacci({position}) = {result}");
        }

 
        static int Fibonacci(int n)
        {
          
            if (n == 1 || n == 2)
            {
                return 1;
            }
            
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}