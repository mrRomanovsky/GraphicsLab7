using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLab6
{
    public partial class Lab7task3 : Form
    {

        private Pen redPen = new Pen(Color.Red);
        private Polyhedron figure;
        private Form1 parent;
        public Lab7task3(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
            figure = new Polyhedron();
        }

        public Lab7task3()
        {
            InitializeComponent();
            figure = new Polyhedron();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private double currentFunction(double x, double y)
        {
            if (checkBoxXXYY.Checked)
                return x * x + y * y;
            else if (checkBoxSinCos.Checked)
                return Math.Sin(x) * Math.Cos(y);
            else if (checkBoxAbs.Checked)
                return Math.Abs(x) + Math.Abs(y);
            else
                return (x * x + 3 * y * y) * Math.Exp(-(x * x) - (y * y));

        }
        //Flower : 100-3/sqrt(x^2 + y^2)+sin(sqrt(x^2+y^2))+sqrt(200-x^2 + y^2 + 10*sin(x)+10*sin(y))/1000
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            figure.vertexes.Clear();

            int x1 = int.Parse(textBoxX1.Text);
            int x2 = int.Parse(textBoxX2.Text);

            int y1 = int.Parse(textBoxY1.Text);
            int y2 = int.Parse(textBoxY2.Text);

            double step = double.Parse(textBoxStep.Text);

            //Build polyhedron
            for (double i = x1; i <= x2; i += step)
            {
                for (double j = y1; j <= y2; j += step)
                    figure.vertexes.Add(new Point3D(i, j, currentFunction(i, j)));
            }
            foreach(var vertex in figure.vertexes)
            {
                var ind1 = figure.vertexes.Where(x => (x.X == vertex.X + step) && (x.Y == vertex.Y) ).ToList();
                if (ind1.Count > 0)
                    vertex.AddNeighbour(ind1.First());
                var ind2 = figure.vertexes.Where(x => (x.X == vertex.X - step) && (x.Y == vertex.Y)).ToList();
                if (ind2.Count > 0)
                    vertex.AddNeighbour(ind2.First());
                var ind3 = figure.vertexes.Where(y => (y.X == vertex.X) && (y.Y == vertex.Y + step)).ToList();
                if (ind3.Count > 0)
                    vertex.AddNeighbour(ind3.First());
                var ind4 = figure.vertexes.Where(y => (y.X == vertex.X) && (y.Y == vertex.Y - step)).ToList();
                if(ind4.Count > 0)
                    vertex.AddNeighbour(ind4.First());
            }


            var isometric = new List<List<double>> { new List<double> { Math.Sqrt(0.5), -1 / Math.Sqrt(6), 0, 0 }, new List<double> { 0, Math.Sqrt(2) / Math.Sqrt(3), 0, 0 }, new List<double> { -1 / Math.Sqrt(2), -1 / Math.Sqrt(6), 0, 0 }, new List<double> { 0, 0, 0, 1 } };

            foreach (var item in figure.vertexes)
                item.MultiplyByMatrix(isometric);
            figure.Centre = new Point3D(0, 0, 0);
            figure.CountVertex = figure.vertexes.Count();
            parent.DrawPolyhedron(figure, parent.PictureBoxSize);
            parent.getFigureFromChild(figure);
        }

        private void Lab7task3_Load(object sender, EventArgs e)
        {
        }
    }
}
