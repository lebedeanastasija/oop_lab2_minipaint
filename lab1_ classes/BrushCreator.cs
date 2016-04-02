using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1__classes
{
    class BrushCreator: FigureCreator
    {
        public override Figure CreateFigure()
        {
            Brush temp = new Brush();
            temp.Base = new Point(-1, -1);
            return temp;
        }
    }
}
