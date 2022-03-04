using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    public class Square : ISquare
    {
        public double Side { get; set; }
        public double SquareAreaResult { get; set; }
        public double SquarePerimeterResult { get; set; }

        public double SquareArea() // <= formula : Area = side * side
        {
            SquareAreaResult = Side * Side;
            return SquareAreaResult;
        } 
        public double SquarePerimeter() // <= formula : Perimeter = 4 * side
        {
            SquarePerimeterResult = 4 * Side;
            return 4 * SquarePerimeterResult;
        }

        public void SquareDisplay()
        {
            Console.WriteLine($" Area result of the Square is : {SquareArea()} ");
            Console.WriteLine($" Perimeter result of the Square is : {SquarePerimeter()} ");
        }

     
    }
}
