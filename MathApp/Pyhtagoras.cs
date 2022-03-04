using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    public class Pyhtagoras : IPythagoras
    {
        public double sidaA { get; set; }
        public double sideB { get; set; }
        public double Hypotenuse { get; set; }
        public void HypotenuseDisplay()
        {
            Console.WriteLine($" The result of the Hypotenuse is : {HypotenuseResult()} ");
        }

        public double HypotenuseResult()
        {
            Hypotenuse = (sidaA * sidaA) + (sideB * sideB);
            return Math.Sqrt(Hypotenuse);
        }
    }
}
