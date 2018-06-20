using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] myStr1 = new string[9];

            string[] myStr2 = new string[] { "Hello", "World", "Hey", "Kuku" };

            string[] myStr3 = {"One", "Two", "Three" };


            int[] intArr = { 4, 7, 9, 522, 7, 9, 552, 7, 99, 5, 4, 9, 7, 5, 47, 9, 7, 7, };


            Console.WriteLine(myStr3[1]);

            myStr3[1] = "Oh no!";
            
            Console.WriteLine(myStr3[1]);


            for (int i = 0; i < myStr1.Length; i++)
            {
                Console.WriteLine(myStr1[i]);
            }

            Console.WriteLine(myStr2);


            int myInt = intArr[5];
            intArr[9] = 15;

            Console.ReadLine();



            ///////////// solution
            Console.WriteLine("Type dimension of an Array:");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Type Elements:");
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("End of input Operation");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]},  ");
            }







        }
    }
}
