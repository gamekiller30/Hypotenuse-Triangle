using System;

namespace Programm
{


    class Programm
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Value of side A of the Triangle:");

            double value1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Value of side B of the Triangle:");

            double value2 = Convert.ToDouble(Console.ReadLine());

            double result = Math.Sqrt(Math.Pow(value1, 2) + Math.Pow(value2, 2));

            Console.WriteLine("The Hypotenuse of your Triangle is: " + result);


        }

    }

}

