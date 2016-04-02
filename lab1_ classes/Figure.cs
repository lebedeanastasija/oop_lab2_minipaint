using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1__classes
{
    abstract class Figure
    {
        public int Id { get; set;}
        public Point Base { get; set; }

        public Figure()
        {
            this.Id = 0;
            Base = new Point(-1, -1);
        }   
    }
}
