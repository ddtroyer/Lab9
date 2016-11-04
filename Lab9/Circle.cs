using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab9
{
    public class Circle
    {
        double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }    
        public double getCircumference()
        {
            return ((2 * Math.PI) * _radius);           
        }
        public String getFormattedCircumference()
        {
            return getCircumference().ToString("0.00");          
        }
        public double getArea()
        {
            return (Math.PI * _radius * _radius);           
        }
        public String getFormattedArea()
        {
            return getArea().ToString("0.00");         
        }
        private String formatNumber(double x)
        {
            return x.ToString("0.00");          
        }
    }
}
