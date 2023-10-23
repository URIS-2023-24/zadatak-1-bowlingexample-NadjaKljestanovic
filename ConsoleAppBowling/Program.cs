using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBowling
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            bool isStrike = false;
            bool isSpare = false;
            bool isLastTry = false;
            for (int i = 1; i <= 10; i++) {
                if (i == 10) isLastTry = true;
                Console.WriteLine("************");
                Console.WriteLine("Insert values for frame " + i + ":");
                Console.WriteLine("First:");
                int first = Convert.ToInt32(Console.ReadLine());
                int second = 0;
                if (first != 10) {
                    Console.WriteLine("Second:");
                    second = Convert.ToInt32(Console.ReadLine());
                }
               
                if (first == 10)
                {
                    Console.WriteLine("---STRIKE---");
                    if (isSpare == true)
                    {
                        sum += first * 2 + second;
                        isSpare = false;
                    }
                    else if (isStrike == true)
                    {
                        sum += (first + second) * 2;
                    }
                    else
                    {
                        sum += 10;
                    }
                    isStrike = true;

                    if (isLastTry == true) {
                        Console.WriteLine("Third:");
                        int third = Convert.ToInt32(Console.ReadLine());
                        sum += third * 2;
                        Console.WriteLine("End sum: " + sum);
                        Console.WriteLine("************");
                    }
                }
                else if (first + second == 10)
                {
                    Console.WriteLine("---SPARE---");
                    if (isStrike == true)
                    {
                        sum += (first + second)*2;
                        isStrike = false;
                    }
                    else if (isSpare == true)
                    {
                        sum += first * 2 + second;
                    }
                    else {
                        sum += first + second;
                    }
                    isSpare = true;
                    if (isLastTry == true)
                    {
                        Console.WriteLine("Third:");
                        int third = Convert.ToInt32(Console.ReadLine());
                        sum += third;
                        Console.WriteLine("End sum: " + sum);
                        Console.WriteLine("************");

                    }
                }
                else {
                    if (isStrike == true)
                    {
                        sum += (first + second) * 2;
                        isStrike = false;
                    }
                    else if (isSpare == true)
                    {
                        sum += first * 2 + second;
                        isSpare = false;
                    }
                    else
                    {
                        sum += first + second;
                    }
                    if (isLastTry == true)
                    {
                        Console.WriteLine("End sum: " + sum);
                        Console.WriteLine("************");
                    }
                    else
                    {
                        Console.WriteLine("Sum: " + sum);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
