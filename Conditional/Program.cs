using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional
{

    enum Cars
    {
        Bmw = 2,
        Mercedes,
        Bentley,
        Zap
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("START !!!");

            //int input = int.Parse(Console.ReadLine());

            //if (input > 5)
            //{
            //    Console.WriteLine("if");
            //    int x = 15;
            //}
            //else if (input < 2)
            //{
            //    Console.WriteLine("first else if");
            //    int x = 65;

            //    if (true)
            //    {

            //    }

            //}
            //else if (input < 3)
            //{
            //    Console.WriteLine("second else if");
            //}
            //else
            //{
            //    Console.WriteLine("else");
            //}

            //Console.WriteLine("outside if/else if");


            // qarakusayin havasarum

            //double a = double.Parse(Console.ReadLine());
            //double b = double.Parse(Console.ReadLine());
            //double c = double.Parse(Console.ReadLine());
            //double D = b * b - 4 * a * c;

            //if (a > 0 && D > 0)
            //{
            //    double x1 = (-b + Math.Sqrt(D)) / 2 * a;
            //    double x2 = (-b - Math.Sqrt(D)) / 2 * a;
            //    Console.WriteLine($"First solution is {x1}");
            //    Console.WriteLine($"Second solution is {x2}");
            //}
            //else if (a > 0 && D == 0)
            //{
            //    double x = (-b + -Math.Sqrt(D)) / 2 * a;
            //    Console.WriteLine($"The solution is {x}");
            //}
            //else
            //{
            //    Console.WriteLine("No solution");
            //}


            /// swithc

            //string input = Console.ReadLine();

            //switch (input)
            //{
            //    case "Mercedes":
            //        Console.WriteLine("harmar");
                    
            //        break;
            //    case "BMW":
            //        Console.WriteLine("arag");
            //        break;
            //    case "Bentley":
            //        Console.WriteLine("de el chasem");
            //        break;
                    
            //    default:
            //        Console.WriteLine("Votqov");
            //        break;
            //}

            //DayOfWeek today = DateTimeOffset.UtcNow.DayOfWeek;
            //DayOfWeek dayOfWeek = DayOfWeek.Sunday;

            //switch (today)
            //{
            //    case DayOfWeek.Sunday:
            //        break;
            //    case DayOfWeek.Monday:
            //        break;
            //    case DayOfWeek.Tuesday:
            //        break;
            //    case DayOfWeek.Wednesday:
            //        break;
            //    case DayOfWeek.Thursday:
            //        break;
            //    case DayOfWeek.Friday:
            //        break;
            //    case DayOfWeek.Saturday:
            //        break;
            //    default:
            //        break;
            //}

            var myCar = Cars.Mercedes;

            switch (myCar)
            {
                case Cars.Bmw:
                    break;
                case Cars.Mercedes:
                    break;
                case Cars.Bentley:
                    break;
                case Cars.Zap:
                    break;
                default:
                    break;
            }

            Console.WriteLine((int)myCar);


            Console.ReadLine();
        }
    }
}
