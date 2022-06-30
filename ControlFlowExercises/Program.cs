using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-tutorial-for-beginners/learn/lecture/2910704#content
namespace ControlFlowExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex. 1
            //var i = 0;
            //while(i <= 100)
            //{
            //    if (i%3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //Ex. 2
            //    long sum = 0;
            //    while (true)
            //    {
            //        Console.WriteLine("Type a number or \"ok\" to exit: \n");
            //        var input = Console.ReadLine();

            //        if (input == "ok")
            //        {
            //            break;
            //        }
            //            var number = Convert.ToInt64(input);
            //            sum += number;

            //        Console.WriteLine($"Sum of the numbers is: {sum}");

            //        //int number = Convert.ToInt32(Console.ReadLine());

            //    }
            //Ex. 3 // done with very minimal help from stackoverflow :D
            //Console.WriteLine("Type a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int factorial = number;
            //for (int i = number - 1; i > 0; i--)
            //{
            //    factorial *= i;
            //}

            //Console.WriteLine(factorial);

            //Ex. 4 // no stackoverflow
            /*
            Random random = new Random();
            int randNumber = random.Next(0, 11);
            Console.WriteLine(randNumber);

            int i = 0;
            const int iterations = 4;
            while (i <= iterations)
            {
                Console.WriteLine("Guess the number: ");
                int guessedNumber = Convert.ToInt32(Console.ReadLine());
                if (guessedNumber!=randNumber)
                {
                    Console.WriteLine("Guess again!");
                    continue;
                }
                else if (guessedNumber==randNumber)
                {
                    Console.WriteLine("Correct!");
                    break;
                }
                i++;
            }
            */

            //Ex. 5
            //wpisać liczby do stringa
            //następnie do tablicy pod postacią int
            //wyznaczyć najwyższą wartość ascii
            //zamienić na odpowiedni znak i wyświetlić
            
            //taken from stackoverflow
            //??? below has been used .NET library 
            
                Console.WriteLine("Enter a series of numbers seperated by commas (Example: 1, 2, 3)");
                var input = Console.ReadLine();
                var numbers = GetListFromValuesSeparatedWithCommas(input);
                var max = numbers?.Max();

                Console.WriteLine("The maximum number is: " + max);
            
            static IEnumerable<int> GetListFromValuesSeparatedWithCommas(string input)
            {
                return input?.Split(',').Select(number => Convert.ToInt32(number.Trim())).ToList();
            }
        }
    }
}