using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;


namespace WinFormsMatricesAndVectors
{
    public partial class NbyMMatrixLoop : Form
    {
        Button[,] buttons = new Button[4, 4];
        Matrix<double> MyMatrix;
        Vector<double> MyVector;

        public NbyMMatrixLoop()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            string[,] btnText = new string[4, 4];
            int loopCount = 1;
            for (int h = 0; h < 4; h++)
            {
                for (int i = 0; i < 4; i++)
                {
                    buttons[h, i] = (Button)this.Controls.Find("button" + (loopCount), true)[0];
                    loopCount++;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            LightUpMatrixDimensions(0, 0);
            MyMatrix = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(1, 1);
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Rows.Add(1);
            CopyMatrixToDataGrid(MyMatrix);
            CopyDataGridToMatrix(MyMatrix);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            LightUpMatrixDimensions(0, 1);
            MyMatrix = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(1, 2);
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Columns.Add("Column2", "Column 2");
            dataGridView1.Rows.Add(1);
            CopyMatrixToDataGrid(MyMatrix);
            CopyDataGridToMatrix(MyMatrix);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            LightUpMatrixDimensions(0, 2);
            MyMatrix = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(1, 3);
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Columns.Add("Column2", "Column 2");
            dataGridView1.Columns.Add("Column3", "Column 3");
            dataGridView1.Rows.Add(1);
            CopyMatrixToDataGrid(MyMatrix);
                CopyDataGridToMatrix(MyMatrix);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            LightUpMatrixDimensions(0, 3);
            MyMatrix = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(1, 4);
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Columns.Add("Column2", "Column 2");
            dataGridView1.Columns.Add("Column3", "Column 3");
            dataGridView1.Columns.Add("Column4", "Column 4");
            dataGridView1.Rows.Add(1);
            CopyMatrixToDataGrid(MyMatrix);
                CopyDataGridToMatrix(MyMatrix);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            LightUpMatrixDimensions(1, 0);
            MyMatrix = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(2, 1);
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Rows.Add(2);
            CopyMatrixToDataGrid(MyMatrix);
                CopyDataGridToMatrix(MyMatrix);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            LightUpMatrixDimensions(1, 1);
            MyMatrix = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(2, 2);
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Columns.Add("Column2", "Column 2");
            dataGridView1.Rows.Add(2);
            CopyMatrixToDataGrid(MyMatrix);
                CopyDataGridToMatrix(MyMatrix);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            LightUpMatrixDimensions(1, 2);
            MyMatrix = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(2, 3);
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Columns.Add("Column2", "Column 2");
            dataGridView1.Columns.Add("Column3", "Column 3");
            dataGridView1.Rows.Add(2);
            CopyMatrixToDataGrid(MyMatrix);
                CopyDataGridToMatrix(MyMatrix);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            LightUpMatrixDimensions(1, 3);
            MyMatrix = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(2, 4);
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Columns.Add("Column2", "Column 2");
            dataGridView1.Columns.Add("Column3", "Column 3");
            dataGridView1.Columns.Add("Column4", "Column 4");
            dataGridView1.Rows.Add(2);
            CopyMatrixToDataGrid(MyMatrix);
                CopyDataGridToMatrix(MyMatrix);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            LightUpMatrixDimensions(2, 0);
            MyMatrix = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(3, 1);
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Rows.Add(3);
            CopyMatrixToDataGrid(MyMatrix);
                CopyDataGridToMatrix(MyMatrix);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            LightUpMatrixDimensions(2, 1);
            MyMatrix = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(3, 2);
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Columns.Add("Column2", "Column 2");
            dataGridView1.Rows.Add(3);
            CopyMatrixToDataGrid(MyMatrix);
                CopyDataGridToMatrix(MyMatrix);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            LightUpMatrixDimensions(2, 2);
            MyMatrix = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(3, 3);
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Columns.Add("Column2", "Column 2");
            dataGridView1.Columns.Add("Column3", "Column 3");
            dataGridView1.Rows.Add(3);
            CopyMatrixToDataGrid(MyMatrix);
                CopyDataGridToMatrix(MyMatrix);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            LightUpMatrixDimensions(2, 3);
            MyMatrix = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(3, 4);
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Columns.Add("Column2", "Column 2");
            dataGridView1.Columns.Add("Column3", "Column 3");
            dataGridView1.Columns.Add("Column4", "Column 4");
            dataGridView1.Rows.Add(3);
            CopyMatrixToDataGrid(MyMatrix);
                CopyDataGridToMatrix(MyMatrix);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            LightUpMatrixDimensions(3, 0);
            MyMatrix = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(4, 1);
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Rows.Add(4);
            CopyMatrixToDataGrid(MyMatrix);
                CopyDataGridToMatrix(MyMatrix);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            LightUpMatrixDimensions(3, 1);
            MyMatrix = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(4, 2);
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Columns.Add("Column2", "Column 2");
            dataGridView1.Rows.Add(4);
            CopyMatrixToDataGrid(MyMatrix);
                CopyDataGridToMatrix(MyMatrix);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            LightUpMatrixDimensions(3, 2);
            MyMatrix = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(4, 3);
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Columns.Add("Column2", "Column 2");
            dataGridView1.Columns.Add("Column3", "Column 3");
            dataGridView1.Rows.Add(4);
            CopyMatrixToDataGrid(MyMatrix);
                CopyDataGridToMatrix(MyMatrix);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            LightUpMatrixDimensions(3, 3);
            MyMatrix = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(4, 4);
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Columns.Add("Column2", "Column 2");
            dataGridView1.Columns.Add("Column3", "Column 3");
            dataGridView1.Columns.Add("Column4", "Column 4");
            dataGridView1.Rows.Add(4);
            CopyMatrixToDataGrid(MyMatrix);
                CopyDataGridToMatrix(MyMatrix);
        }
        void LightUpMatrixDimensions(int row, int column)
        {

            int count = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    buttons[i, j].BackColor = Color.FromName("Control");
                    buttons[i, j].Tag = null;
                    count++;
                }
            }
            count = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i <= row && j <= column)
                    {
                        buttons[i, j].BackColor = Color.Red;
                    }
                    count++;
                }
            }
        }

        void CopyMatrixToDataGrid(Matrix<double> m1)
        {
            dataGridView1.RowCount = m1.RowCount;
            dataGridView1.ColumnCount = m1.ColumnCount;
            // Set cell values in the DataTable
            for (int i = 0; i < m1.RowCount; i++)
            {
                for (int j = 0; j < m1.ColumnCount; j++)
                {
                    DataGridViewCell cell = dataGridView1[i, j];
                    cell.Value = m1[i, j];
                }
            }
        }

        void CopyDataGridToMatrix(Matrix<double> m1)
        {
            dataGridView1.RowCount = m1.RowCount;
            dataGridView1.ColumnCount = m1.ColumnCount;
            // Set cell values in the DataTable
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    DataGridViewCell cell = dataGridView1[i, j];
                    m1[i, j] = double.Parse(cell.Value.ToString());
                }
            }
        }
    }
}
