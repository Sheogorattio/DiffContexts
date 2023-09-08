using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffContexts
{
    public partial class Form1 : Form
    {
        Pen p;
        public Form1()
        {
            InitializeComponent();
            button1.Paint += button1_Paint;
            button1.MouseEnter += Button1_MouseEnter;
            button1.MouseLeave += Button1_MouseLeave;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        

        private void button1_Paint(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            GraphicsPath path2 = new GraphicsPath();
            GraphicsPath path3 = new GraphicsPath();
            path.AddEllipse(0,85, 240,30);
            path2.AddEllipse(100, 0, 30, 220);
            path3.AddEllipse(75, 60, 80, 75);
            Region reg1  = new Region(path);
            Region reg2 = new Region(path2);
            Region reg3 = new Region(path3);
            reg1.Union(reg2);
            reg1.Union(reg3);
            button1.Region = reg1;
        }
    }
}
