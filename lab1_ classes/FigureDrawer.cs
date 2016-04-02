using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1__classes
{
    abstract class FigureDrawer
    {
        public abstract Bitmap DrawFigure(System.Windows.Forms.PictureBox pb, Pen p, Figure f);
    }
}
