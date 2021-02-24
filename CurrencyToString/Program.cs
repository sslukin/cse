using System;
using System.Globalization;

namespace CurrencyToString
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Enter a number");
            string number = Console.ReadLine();
  
            int n;

            if (int.TryParse(number, out n))
            {
                Console.WriteLine(n.Convert());
            }
            else
                Console.WriteLine("Not a number!");
        }
    }
}
