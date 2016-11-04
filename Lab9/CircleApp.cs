using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    static public class CircleApp
    {
        static public Circle checkRadius()
        {
            Console.Write("Enter radius: ");
            string strRadius = Console.ReadLine();

            double radius;
            
            while (!checkData(strRadius, out radius))
            {
                Console.Write("Try again: ");
                strRadius = Console.ReadLine();
            }
            Circle NewCircle = new Circle(radius);
            return NewCircle;
        }
        static public void printAnswers(Circle circle)
        {
            Console.WriteLine("Circumference: {0}", circle.getFormattedCircumference());
            Console.WriteLine("Area: {0}", circle.getFormattedArea());
        }
        static bool checkData(string strRadius, out double radius)
        {
            bool isValid = double.TryParse(strRadius, out radius);

            if (isValid && (radius >= 0))
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
