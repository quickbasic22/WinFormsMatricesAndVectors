using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMatricesAndVectors
{
    public partial class GDIMatrix : Form
    {
        System.Drawing.Drawing2D.Matrix matrixA = new System.Drawing.Drawing2D.Matrix();
        float[,] myMatrix = new float[3, 2];
        System.Drawing.Drawing2D.Matrix MainMatrix = new System.Drawing.Drawing2D.Matrix();
        int count = 0;
        Point mouseLocation;
        Point[] points;

        public GDIMatrix()
        {
            InitializeComponent();
           
            textBox1.Visible = false;
            displayMatrixDimensions();
        }

        void MatrixDimensions(System.Drawing.Drawing2D.Matrix matrix)
        {
            textBox1.Text += "\n\r" + "\n\r";
            string matrixString = string.Format("[{0:F0},{1:F0},{2:F0}],{3},[{4:F0},{5:F0},{6:F0}],{7},[{8:F0},{9:F0},{10:F0}]",
     matrix.Elements[0], matrix.Elements[1], 0,
     Environment.NewLine,
     matrix.Elements[2], matrix.Elements[3], 0,
     Environment.NewLine,
     matrix.Elements[4], matrix.Elements[5], 1);
            textBox1.Text += matrixString + "\n\r" + "\n\r";

        }

        void MatrixDimensions2(System.Drawing.Drawing2D.Matrix matrix)
        {
            textBox1.Text += "\n\r" + "\n\r";
            string matrixString = string.Format("[{0:F0},{1:F0}],{2},[{3:F0},{4:F0}],{5},[{6:F0},{7:F0}]",
     matrix.Elements[0], matrix.Elements[1],
     Environment.NewLine,
     matrix.Elements[2], matrix.Elements[3],
     Environment.NewLine,
     matrix.Elements[4], matrix.Elements[5]);
            textBox1.Text += matrixString + "\n\r" + "\n\r";

        }


        private void GDIMatrix_Paint(object sender, PaintEventArgs e)
        {
              
            e.Graphics.ResetTransform();

            float xMin = -10f;
            float xMax = 10f;
            float yMin = -7f;
            float yMax = 7f;


            float xRange = xMax - xMin;
            float yRange = yMax - yMin;

            float scaleX = this.Width / xRange;
            float scaleY = this.Height / yRange;

            // Flip the y-axis direction by setting the second element of the scaling vector to negative
            e.Graphics.Transform = new Matrix(scaleX, 0, 0, -scaleY, this.Width / 2, this.Height / 2);

            Matrix matrixRight = new Matrix(scaleX, 0, 0, scaleY, this.Width / 2, this.Height / 2);

            Pen bluePen = new Pen(Color.Blue, 0.1f);

            for (float i = xMin; i <= xMax; i += 0.1f)
            {
                // Compute the y-coordinate of the point on the parabola y = x^2
                float y = i * i * i;

                // Transform the coordinates of the point using the current transformation matrix
                PointF pt = new PointF(i, y);
               

                // Draw a small dot at the transformed point
                e.Graphics.DrawLine(bluePen, pt.X, pt.Y, pt.X + 0.01f, pt.Y + y);
            }
                    
           
            Point[] mouseTransformed = new Point[] { mouseLocation };
            e.Graphics.TransformPoints(CoordinateSpace.World, CoordinateSpace.Page, mouseTransformed);

            float displayHeight = float.Parse(e.Graphics.VisibleClipBounds.Height.ToString());
            int invertedY = (int)Math.Round(displayHeight, 0) - mouseLocation.Y;
            Point invertedMouseLocation = new Point(mouseLocation.X, invertedY);

            Font myFont = new Font("Arial", 0.1f, FontStyle.Bold);
            e.Graphics.DrawString(String.Format("x = {0}\n\ry = {1}", invertedMouseLocation.X.ToString(), invertedMouseLocation.Y), myFont, Brushes.Blue, invertedMouseLocation);


        }

        private void GDIMatrix_MouseMove(object sender, MouseEventArgs e)
        {
            this.Invalidate();
            mouseLocation = e.Location;

        }

        void displayMatrixDimensions()
        {
            Graphics g = this.CreateGraphics();

            Matrix Matrix360 = new Matrix(0, 1, 1, 0, 0, 0);
            MatrixDimensions(Matrix360);
            Matrix Matrix270 = new Matrix(0, 1, -1, 0, 0, 0);
            MatrixDimensions(Matrix270);
            Matrix Matrix180 = new Matrix(-1, 0, 0, -1, 0, 0);
            MatrixDimensions(Matrix180);
            Matrix Matrix90 = new Matrix(0, -1, 1, 0, 0, 0);
            MatrixDimensions(Matrix90);

            //MainMatrix.Reset();
            //MainMatrix.Rotate(360);
            //MatrixDimensions2(MainMatrix);
            //MainMatrix.Reset();
            //MainMatrix.Rotate(270);
            //MatrixDimensions2(MainMatrix);
            //MainMatrix.Reset();
            //MainMatrix.Rotate(180);
            //MatrixDimensions2(MainMatrix);
            //MainMatrix.Reset();
            //MainMatrix.Rotate(90);
            //MatrixDimensions2(MainMatrix);
        }

        private void GDIMatrix_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            points = new Point[]
           {
                new Point(1180, 161),
                new Point(946, 661),
                new Point(1500, 661)
           };

            for (int i = 0; i < points.Length; i++)
            {
                MessageBox.Show(points[i].ToString());
            }

            Graphics g = this.CreateGraphics();
            float xMin = -10f;
            float xMax = 10f;
            float yMin = -7f;
            float yMax = 7f;


            float xRange = xMax - xMin;
            float yRange = yMax - yMin;

            float scaleX = this.Width / xRange;
            float scaleY = this.Height / yRange;

            // Flip the y-axis direction by setting the second element of the scaling vector to negative
            g.Transform = new Matrix(scaleX, 0, 0, -scaleY, this.Width / 2, this.Height / 2);

            Matrix matrixRight = new Matrix(scaleX, 0, 0, scaleY, this.Width / 2, this.Height / 2);

            g.TransformPoints(CoordinateSpace.World, CoordinateSpace.Page, points);


            for (int i = 0;i < points.Length;i++)
            {
                MessageBox.Show(points[i].ToString());
            }
        }
    }
}
