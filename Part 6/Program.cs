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
            Prompter();
            PercentPassing();
            OddSum();
            RandomNumbers();
            Console.ReadLine();
        }

        static void Prompter()
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
        }
        static void PercentPassing()
        {
            int userTotalScore;
            int above70 = 0;
            int score;
            Console.WriteLine("Enter the amount of scores you have");
            userTotalScore = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < userTotalScore; i++)
            {
                Console.WriteLine("Please enter a score");
                score = Convert.ToInt32(Console.ReadLine());
                if (score >= 70)
                {
                    above70 = above70 + 1;
                    Console.WriteLine($"The amount of scores over 70 is: {above70}");
                }

            }
            
        }
        static void OddSum()
        {
            int userNum;
            int sum = 0;
            Console.WriteLine("Enter a number");
            userNum = Convert.ToInt32(Console.ReadLine());
            if (userNum <= 0)
                {
                    Console.WriteLine("Error, please enter a positive number");   
                }
            for (int i = 1; i <= userNum; i += 2)
            {
                sum += i;
            }
            if (userNum >= 1)
            Console.WriteLine(sum);
        }
        static void RandomNumbers()
        {
            int min;
            int max;
            int random;
            Random generator = new Random();

            Console.WriteLine("Please enter a minimum value");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a maximum value");
            max = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 25; i++)
            { 
                random = generator.Next(min, max);
                Console.WriteLine(random);
            }
        }
    }
}