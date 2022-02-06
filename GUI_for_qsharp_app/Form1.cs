using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_for_qsharp_app
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap buf;
        public Form1()
        {
            InitializeComponent();
            //buf = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //g = Graphics.FromImage(buf);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //g = this.CreateGraphics();
            buf = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(buf);
            pictureBox1.Size = new Size(this.Width, this.Height);
            Task MouseTracker = new Task(()=>GetMousePosition());
            MouseTracker.Start();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(this.Width, this.Height);
            label2.Text = $"{Width}:{Height}";
            label4.Text = $"{pictureBox1.Size.Width}:{pictureBox1.Size.Width}";
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            /*Point p = new Point(Cursor.Position.X,Cursor.Position.Y);
            g.DrawEllipse(new Pen(Color.Green), new RectangleF(p, new Size(10,10)));
            pictureBox1.Image = buf;*/
        }

        private void GetMousePosition() 
        {
            while (true) {
                if (label6.Text !=$"{Cursor.Position.X}:{Cursor.Position.Y}")
                label6.Invoke(new Action(() => label6.Text = $"{Cursor.Position.X}:{Cursor.Position.Y}"));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}   
