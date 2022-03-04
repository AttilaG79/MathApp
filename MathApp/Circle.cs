using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    public class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Pi { get; set; }
        public double CircleAreaResult { get; set; }
        public double CircleCircumferenceResult { get; set; }

        public Circle()
        {
            this.Pi = Math.PI;
        }
        public void CircleDisplay()
        {
            Console.WriteLine($" The Area result of Circle is : {CircleArea()} ");
            Console.WriteLine($" The Circumference result of Circle is : {CircleCircumference()} ");
        }

        public double CircleArea() // <= formula : PI * radius * radius
        {
            CircleAreaResult = Pi * (Radius * Radius);
            return CircleAreaResult;
        }

        public double CircleCircumference() // <= formula : PI * 2 * radius
        {   
            CircleCircumferenceResult = Pi * ( 2 * Radius );
            return CircleCircumferenceResult;
        }
    }
}
