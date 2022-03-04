using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    public interface IRectangle
    {
        double RectangleArea(); // <= formula Area = Length * Width
        double RectanglePerimeter(); // <= formula Perimeter = 2 * ( Length + Width )
        void RectangleDisplay();
    }
}
