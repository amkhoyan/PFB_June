using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // integers
            //int myInteger1 = 2147483;

            //int myInteger2;
            //myInteger2 = 2147483;

            //int myInteger3 = 545;

            //int sum = myInteger1 + myInteger2 + myInteger3;

            //Console.WriteLine(sum);

            // floating point numbers
            //double d = 1544.74;
            //double myDouble = d;

            // booleans

            //bool isOdd = true;

            //bool isModified = false;

            //isOdd = false;
            //isOdd = true;
            //bool answer = 6 > 1;

            //Console.WriteLine(isOdd);
            //Console.WriteLine(answer);


            // strings 
            //string name = "Petros";
            //string input = Console.ReadLine();

            //Console.WriteLine(input.ToUpper());
            //Console.WriteLine(input.ToLower());
            //Console.WriteLine($"{name} : {input}");


            //char

            //char mChar = 'c';
            //char mChar1 = 'w';

            //bool an = mChar == mChar1;


            // type coversion

            //int i = 45;
            //double d = i;


            //double dd = 45.798;
            //int ii = (int)dd;


            string str1 = "165";
            string str2 = "100";

            //int str1Int = int.Parse(str1);
            //int str2Int = int.Parse(str2);

            int str1Int = Convert.ToInt32(str1);
            int str2Int = Convert.ToInt32(str2);

            string sumString = str1 + str2;
            int sumInt = str1Int + str2Int;

            Console.WriteLine($"sum string: {sumString}, sum Int: {sumInt}");


            // const
            //const string stringValue = "Hello";
            //const double ddd = 32.7;
            //const char myChar2 = 'b';
            //const int myInteger = 2147483;

            //stringValue = "world"; //error! 
            //ddd = 67.3;//error! 
            //myChar2 = 'e';//error! 
            //myInteger = 234;//error! 


            //// var 
            //var myVar = 152;
            //var dddd = new AppDomainManagerInitializationOptions();

            double dec = (double)1 / 3;

            Console.WriteLine(dec);

            Console.ReadLine();
        }
    }
}
