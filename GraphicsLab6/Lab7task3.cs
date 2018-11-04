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
        public Lab7task3()
        {
            InitializeComponent();
            figure = new Polyhedron();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DrawPolyhedron(Polyhedron polyhedron, Size size)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            var res = new List<PointF>();
            var x = size.Width / 2 - polyhedron.SegmentLength / 2;
            var y = size.Height / 2 - polyhedron.SegmentLength / 2;
            var z = 1.0;

            using (var g = Graphics.FromImage(pictureBox1.Image))
            {
                foreach (var item in polyhedron.vertexes)
                {
                    if (item.Z != 0)
                        z = item.Z;
                    var scaledPoint = new PointF((float)(item.X / z + x), (float)(item.Y / z) + y);
                    foreach (var neighbour in item.Neighbours)
                    {
                        var scaledNeighbour = new PointF((float)((float)neighbour.X / (float)z + x), (float)((float)neighbour.Y / (float)z) + y);
                        g.DrawLine(redPen, scaledPoint, scaledNeighbour);
                    }
                    res.Add(new PointF((float)(item.X / z + x), (float)(item.Y / z) + y));
                }
            }
        }

        //Flower : 100-3/sqrt(x^2 + y^2)+sin(sqrt(x^2+y^2))+sqrt(200-x^2 + y^2 + 10*sin(x)+10*sin(y))/1000
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(textBoxX1.Text);
            int x2 = int.Parse(textBoxX2.Text);

            int y1 = int.Parse(textBoxY1.Text);
            int y2 = int.Parse(textBoxY2.Text);

            int step = int.Parse(textBoxStep.Text);

            //Build polyhedron

            //foreach (var vertex1 in figure.vertexes)
            //    foreach (var vertex2 in figure.vertexes)
            //        if (vertex1.X == 0 && vertex2.X != 0
            //            || vertex1.Y == 0 && vertex2.Y != 0
            //            || vertex1.Z == 0 && vertex2.Z != 0)
            //            vertex1.AddNeighbour(vertex2);

            var isometric = new List<List<double>> { new List<double> { Math.Sqrt(0.5), -1 / Math.Sqrt(6), 0, 0 }, new List<double> { 0, Math.Sqrt(2) / Math.Sqrt(3), 0, 0 }, new List<double> { -1 / Math.Sqrt(2), -1 / Math.Sqrt(6), 0, 0 }, new List<double> { 0, 0, 0, 1 } };
            foreach (var item in figure.vertexes)
                item.MultiplyByMatrix(isometric);
            DrawPolyhedron(figure, pictureBox1.Size);
            pictureBox1.Invalidate();
        }
    }
}
