using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    public class Rectangle : IRectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double RectangleAreaResult { get; set; }
        public double RectanglePerimeterResult { get; set; }
        public double RectangleArea() // <= formula Area = Length * Width
        {
            RectangleAreaResult = Length * Width;
            return RectangleAreaResult; 
        } 
        public double RectanglePerimeter() // <= formula Perimeter = 2 * ( Length + Width )
        {
            RectanglePerimeterResult = 2 * (Length + Width);
            return RectanglePerimeterResult;    
        }

        public void RectangleDisplay()
        {
            Console.WriteLine($" The Area result of Rectangle is : {RectangleArea()} ");
            Console.WriteLine($" The Perimeter result of Rectangle is : {RectanglePerimeter()} ");
        }

     
    }
}
