using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClayTree
{

    public partial class clayTree : Form
    {
        private Graphics graphics;
        public double Th1 { get; set; }
        public double Th2 { get; set; }
        public double Per1 { get; set; }
        public double Per2 { get; set; }
        public int N { get; set; }
        public Pen Pen_ { get; set; }
        public double Leng { get; set; }

        public clayTree()
        {
            InitializeComponent();
        }


        private void draw_button_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawClayTree(N,200,300,Leng,-Math.PI/2);
        }
        void drawClayTree(int n, double x0, double y0,double leng,double th) {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawClayTree(n - 1, x1, y1, Per1 * leng, th + Th1*Math.PI/180);
            drawClayTree(n - 1, x1, y1, Per2 * leng, th - Th2 * Math.PI / 180);
        }
        void drawLine(double x0, double y0,double x1,double y1)
        {
            graphics.DrawLine(Pen_,(int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void clayTree_Load(object sender, EventArgs e)
        {
            Th1 = 30;Th2 = 20;Per1 = 0.6;Per2 = 0.7;Leng = 100;N = 10;Pen_ = Pens.Blue;
            ratextBox.DataBindings.Add("Text", this, "Th1");
            latextBox.DataBindings.Add("Text", this, "Th2");
            rltextBox.DataBindings.Add("Text", this, "Per1");
            lltextBox.DataBindings.Add("Text", this, "Per2");
            mtextBox.DataBindings.Add("Text", this, "Leng");
            dtextBox.DataBindings.Add("Text", this, "N");
            Pen[] pens = { Pens.Red, Pens.Yellow, Pens.Blue, Pens.Green };
            ccomboBox.DataSource = pens;
            ccomboBox.DisplayMember = "Color";
            ccomboBox.DataBindings.Add("SelectedItem", this, "Pen_");
        }
    }
}
