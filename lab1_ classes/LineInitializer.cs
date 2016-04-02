using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1__classes
{
    class LineInitializer:FigureInitializer
    {
        public override void InitializeFigure(Figure f, int x, int y)
        {
            ((Line)f).Dot = new Point(x, y);
        }
    }
}
