using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //int y = 20;

            //Program.MyMethod1(x, y);

            //Program.MyMethod2(34, "Hello", 54.3, DayOfWeek.Saturday);

            //Program.MyMethod2("Hello".Length, "World", 676.3, DayOfWeek.Tuesday);

            //Program.MyMethod3("Hello World");

            //Program.MyMethod3("Hello , dear Mr. Tozdumanyan Qaruqand");


            int[] myIntArr = { 45, 6, 7, 21, 5, 6, 8, 7, 54, 23, 6, 8, 056, 23, 5, 6, 4, 563, 45345, 345 };
            int[] myIntArr2 = { 457, 6, 7, 521, 55, 645, 448, 722, 54, 283, 689, 8, 596, 23, 35, 63, 14, 5263, 435345, 345 };

            Console.WriteLine("insert your numver");
            int bjj = int.Parse(Console.ReadLine());

            int c1 = FindCount(myIntArr, bjj);
            int c2 = FindCount(myIntArr2, bjj);

            Console.WriteLine($"myIntArr: {c1}, myIntArr1: {c2}");

            Console.WriteLine($"myIntArr: {FindCount(myIntArr, bjj)}, myIntArr1: { FindCount(myIntArr2, bjj)}");


            DummyMethod();

            Console.ReadLine();
        }

        static void DummyMethod()
        {
            int[] myIntArr = { 45, 6, 7, 21, 5, 6, 8, 7, 54, 23, 6, 8, 056, 23, 5, 6, 4, 563, 45345, 345 };

            int xx = FindCount(myIntArr, 8);
        }

        static int FindCount(int[] arr, int num)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % num == 0)
                {
                    count++;
                }
            }

            return count;
        }


        static void MyMethod1(int inputOne, int inputTwo)
        {
            Console.WriteLine($"inputOne: {inputOne}, inputTwo: {inputTwo}");
            
        }

        static void MyMethod2(int parInt, string parString, double parDouble, DayOfWeek parDayOf)
        {
             
        }

        static void MyMethod3(string str)
        {
            Console.WriteLine(str);
        }

    }
}
