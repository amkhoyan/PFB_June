using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //string toEnd = "";

            //for (; toEnd != "y"; )
            //{
            //    Console.WriteLine("bla bla bla");

            //    Console.Write("to continue, press any key, to stop work, press Y/y: ");
            //    toEnd = Console.ReadLine().ToLower();
            //}

            //BigInteger bg = 22;

            // trvats e N bnakan tivy: Stanal Ev tpel N-ic mets ajn amenapoqr tivy, vory
            // 2-i astichan e


            //Console.Write("Type your N num: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; ; i++)
            //{
            //    double a = Math.Pow(2, i);
            //    if (a > n)
            //    {
            //        Console.WriteLine($"Answer: {a}");
            //        break;
            //    }
            //}



            //int n1 = 1587;
            //Console.WriteLine($"{n1}");
            //int num = n1 % 10;
            //n1 = n1 / 10;
            //Console.WriteLine($"n1 : {n1},  num: {num}");

            //int n3 = 9;

            //n3 = n3 / 10;
            //Console.WriteLine(n3);





            //Console.WriteLine("Please insert n");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int art = 1;
            //int i;
            //int count = 0;
            //while (n!=0)
            //{
            //    i = n % 10;
            //    Console.WriteLine(i);
            //    n = n / 10;
            //    sum = sum + i;
            //    art = art * i;
            //    count++;
            //}
            //Console.WriteLine($"Sum {sum}, Art {art}, Qanak {count}");

            
            for (int j = 0; j < 6; j++)
            {
                for (int k = 0; k <= j; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
