using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1__classes
{
    public partial class Figures : Form
    {
      
        Figure figure;
        FigureCreator figureCreator;
        FigureInitializer figureInitializer;
        FigureDrawer figureDrawer;

        DrawerList drawerList = new DrawerList();
        CreatorList creatorList = new CreatorList();
        InitializerList initializerList = new InitializerList();

        Pen p;
        Graphics g;
        Graphics g_t;
        Bitmap b;
        Bitmap b_t;
        
 
        public Figures()
        {
            InitializeComponent();
            p = new Pen(Color.Black, 3);
            textBox1.BackColor = p.Color;
            this.Controls.Add(canvas);
            b = new Bitmap(canvas.Size.Width, canvas.Size.Height);
            b_t = new Bitmap(canvas.Size.Width, canvas.Size.Height);
            g = Graphics.FromImage(b);
            g_t = Graphics.FromImage(b_t);
            canvas.Enabled = false;
            canvas.Image = b;
        }

        private void btnFigure_Click(object sender, EventArgs e)
        {
            //создаю нужную фигуру
            //создаём нужного инициализатора
            //coздаю нужного рисовальщика
            canvas.Enabled = true;
            figureCreator = creatorList[Convert.ToInt32((sender as Button).Tag.ToString())];
            figure = figureCreator.CreateFigure();
            figureDrawer = drawerList[Convert.ToInt32((sender as Button).Tag.ToString())];
            figureInitializer = initializerList[Convert.ToInt32((sender as Button).Tag.ToString())];
        } 

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if ((figure.Base.X < 0) && (figure.Base.Y < 0))
            {               
                figure.Base = new Point(e.X, e.Y);                
            }
            else
            {
                g.DrawImage(b, 0, 0);
                g.DrawImage(b_t, 0, 0);
                canvas.Image = b;
                figure.Base = new Point(-1, -1);
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if ((figure.Base.X >= 0) && (figure.Base.Y >= 0))
            {
                canvas.Image = b;
          
                figureInitializer.InitializeFigure(figure, e.X, e.Y);       
                b_t = figureDrawer.DrawFigure(canvas, p, figure);
                
                if(figure.Id == 0)
                    g.DrawImage(b_t, 0, 0);
                canvas.Image = b_t;
                canvas.Refresh();
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            dlgColor.ShowDialog();
            p.Color = dlgColor.Color;
            textBox1.BackColor = p.Color;
        }        

        private void cmbWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.Width = Convert.ToInt32(cmbWidth.SelectedItem.ToString());
        }  

    }
}
