using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    public interface ISquare
    {
        double SquareArea(); // <= formula : Area = side * side
        double SquarePerimeter(); // <= formula : Perimeter = 4 * side
        void SquareDisplay();
    }
}
