using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    public interface ICircle
    {
        double CircleArea(); // <= formula : PI * radius * radius
        double CircleCircumference(); // <= formula : PI * 2 * radius
        void CircleDisplay();
    }
}
