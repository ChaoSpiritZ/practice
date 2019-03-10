using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_mode
{
    class Program
    {
        static void Main(string[] args)
        {
            //question 1
            /*
            for (int i = 10; i < 101; i= i + 10)
            {
                Console.WriteLine(i);
            }
            */

            //question 2
            /*
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            */

            //question 3
            /*
            Console.WriteLine("insert a 2 digit number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 9 && a < 101)
            {
                int ahadot = a % 10;
                int asarot = a / 10;
                Console.WriteLine($"ahadot = {ahadot}");
                Console.WriteLine($"asarot = {asarot}");
                if (asarot > ahadot)
                {
                    Console.WriteLine("ASAROT");
                }
                else
                {
                    Console.WriteLine("AHADOT");
                }
            }
            else
            {
                Console.WriteLine("hahaha f u");
            }
            */

            //question 6
            /*
            int x = Convert.ToInt32(Console.ReadLine());
            int d = x;
            for (int i = 1; i <= x; i++)
            {
                Console.Write("1");
                for (int j = 2; j <= i; j++)
                {
                    Console.Write(j);
                }

                for (int star = d - 1; star > 0; star--)
                {
                    Console.Write("*");

                }
                d--;

                Console.WriteLine();
            }
            */

            //----------------------------------
            //part two
            //----------------------------------

            //question 2
            /*
            int students = Convert.ToInt32(Console.ReadLine());

            int hundred = students / 100;
            students = students % 100;
            int thirty = students / 30;
            students = students % 30;
            int ten = students / 10;
            students = students % 10;
            int leftovers = students;
            Console.WriteLine($"{hundred} big classrooms");
            Console.WriteLine($"{thirty} big classrooms");
            Console.WriteLine($"{ten} small classrooms");
            Console.WriteLine($"{leftovers} will be dismissed");
            */

            //question 3
            /*
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("==============================");
            Console.WriteLine();
            for (int i = 1; i <= x; i++)
            {
                Console.Write("1");
                for (int j = 2; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
                for (int k = x - 1; k > 0; k--)
                {
                    Console.Write("1");
                    for (int l = 2; l <= k; l++)
                    {
                        Console.Write(l);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            Console.WriteLine("==============================");
            */

            //question 4


            int x = Convert.ToInt32(Console.ReadLine());
            int spaces = (x / 2);
            int aster = 1;
            for (int i = spaces; i >= 0; i--)
            {
                    for (int h = spaces; h > 0; h--)
                    {
                        Console.Write(" ");
                    }            
                for (int j = aster; j <= aster; j = j + 2)
                {
                    for (int k = 1; k <= j; k++)
                    {
                        Console.Write("*");

                    }
                    Console.WriteLine();
                }
                    aster = aster + 2;
                    spaces--;
            }
        }
    }
}
