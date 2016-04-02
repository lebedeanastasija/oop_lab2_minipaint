using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1__classes
{
    class Line: Figure
    {
        public Point Dot { set; get; }

        public Line()
        {
            Id = 1;
        }
    }
}
