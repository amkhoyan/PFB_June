using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loop");

            //for (int y = 1; y <= 50; y++)
            //{
            //    Console.Write($"{y}  ");
            //    if (y%2==1)
            //    {
            //        Console.WriteLine();
            //        continue;
            //    }
            //    else if(y==40)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(y);
            //}


            //for (int i = 0; i < 20; i++)
            //{
            //    if (i%2!=0)
            //    {
            //        Console.WriteLine($"i = {i}");
            //    }
            //}

            //for (int i = 1; i < 20; i += 2)
            //{
            //    //if (i%2==0)
            //    //{
            //    //    continue;
            //    //}

            //    Console.WriteLine($"i = {i}");
            //}


            //Console.WriteLine("Numbers from 10 to 1:");
            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine($"i = {i}");
            //}

            ////////////////////
            //int i = 1;
            //while (i>10)
            //{
            //    int y = 2;

            //    Console.WriteLine($"i: {i}, y: {y}");
            //    y++;
            //    i++;
            //}


            //do
            //{
            //    Console.WriteLine($"i: {i}");

            //} while (i>10);




            ///////////////////

            //for (int i = 1; i <= 100; i++)
            //{
            //    //if (i%15==0)
            //    if (i%3==0 && i%5==0)
            //        {
            //        Console.WriteLine("JazzRock");

            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Jazz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Rock");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }


            //}

            Console.WriteLine("Type your A ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Type your B ");
            int b = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                //sum = sum + i;
                sum += i;

            }

            for (int i = a > b ? b : a; i <= (a > b ? a : b); i++)
            {
                //sum = sum + i;
                sum += i;
            }
       
            Console.WriteLine($"Summa = {sum}");


            Console.ReadLine();
        }
    }
}
