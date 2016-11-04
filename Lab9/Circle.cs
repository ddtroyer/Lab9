using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab9
{
    class Circle
    {
        public Circle(double radius)
        {
            double radius = 
        }
       
        public double getCircumference(double circumference, int radius)
        {
            circumference = (Math.PI * radius);
            return circumference;
        }
        public String getFormattedCircumference(string circumference)
        {
            string formattedCircumference = string.Format("{0:0.00}", circumference);
            return formattedCircumference;
        }
        public double getArea(int radius)
        {
            double area = (Math.PI * (radius * radius));
            return area;
        }
        public String getFormattedArea(double area)
        {
            string formattedArea = string.Format("{0:0.00}", area);
            return formattedArea;
        }
        private String formatNumber(double x)
        {
            String formatNumber = string.Format("{0:0.00}", x);
            return formatNumber;
        }
    }
}
