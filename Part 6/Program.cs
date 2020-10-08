using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int min;
            int max;
            int userNum;
            Console.WriteLine("Please enter a minimum integer value");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a maximum integer value");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The range is {min} to {max}");
            Console.WriteLine("Enter a number in the range");
            while (!Int32.TryParse(Console.ReadLine(), out userNum))
                Console.WriteLine("That is outside the range, please try again");
            Console.WriteLine("thanks!");
            Console.ReadLine();
        }
    }
}