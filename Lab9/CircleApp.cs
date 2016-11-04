using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class CircleApp
    {
        public string printRadius(string strRadius, double radius)
        {
            Console.Write("Enter radius: ");
            strRadius = Console.ReadLine();
            
            while (!checkData(strRadius, out radius))
            {
                Console.Write("Try again: ");
                strRadius = Console.ReadLine();
            }
        }
        public void printScreenTwo()
        {
            Console.WriteLine("Circumference: ");
            Console.WriteLine("Area: \t");
        }
        static bool checkData(string strRadius, out double radius)
        {
            bool isValid = double.TryParse(strRadius, out radius);

            if (isValid && (radius <= 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
