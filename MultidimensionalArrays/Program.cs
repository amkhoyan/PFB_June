using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] multiArr = new int[4, 4];


            //Random rd = new Random();

            //int random = rd.Next(0,2);

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int y = 0; y < 4; y++)
            //    {
            //        multiArr[i, y] = rd.Next(0, 2);
            //    }
            //}


            //for (int i = 0; i < 4; i++)
            //{
            //    for (int y = 0; y < 4; y++)
            //    {
            //        if (multiArr[i, y] == 0)
            //        {
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}



            //int[,] myIntMult =  {
            //                        {1,2,3,4 },
            //                        {4,5,6,7 },
            //                        {7,6,54 ,9}
            //                    };

            //int value = 85;
            //int[,] myIntMult3 = new int[3, 3] { 
            //                                    { value, 7, 7 }, 
            //                                    { value, int.Parse(Console.ReadLine()), 7 }, 
            //                                    { value, 8, 7 },
            //                                   };



            for (int i = 0; i < 5; i++)
            {
                for (int y = 0; y < 5; y++)
                {
                    Console.Write($"[{i}, {y}]");
                }
                Console.WriteLine();
            }


            ////////////////////

            //int[,] myMass = new int[5, 5];
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int y = 0; y < 5; y++)
            //    {
            //        if ((i+y)%2==0)
            //        {
            //            myMass[i, y] = 1;
            //        }
                   
            //        Console.Write($"{myMass[i, y]}\t");
            //    }
            //    Console.WriteLine();
            //}
            
            Console.ReadLine();
        }
    }
}
