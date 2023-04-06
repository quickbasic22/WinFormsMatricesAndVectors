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
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.Data.Text;

namespace WinFormsMatricesAndVectors
{
    public partial class SolveSystem : Form
    {
        Matrix<double> m1;
        Matrix<double> m2;
        public SolveSystem()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView3.AllowUserToAddRows = false;
            ProduceEchelonForm();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var width = Int32.Parse(numericUpDown1.Value.ToString());

            dataGridView1.ColumnHeadersVisible = true;


            switch (width)
            {
                case 1:
                    dataGridView1.Columns.Clear();

                    dataGridView1.Columns.Add("Column1", "Column1");
                    return;
                case 2:
                    dataGridView1.Columns.Clear();

                    dataGridView1.Columns.Add("Column1", "Column1");
                    dataGridView1.Columns.Add("Column2", "Column2");
                    return;
                case 3:
                    dataGridView1.Columns.Clear();

                    dataGridView1.Columns.Add("Column1", "Column1");
                    dataGridView1.Columns.Add("Column2", "Column2");
                    dataGridView1.Columns.Add("Column3", "Column3");
                    return;
                case 4:
                    dataGridView1.Columns.Clear();

                    dataGridView1.Columns.Add("Column1", "Column1");
                    dataGridView1.Columns.Add("Column2", "Column2");
                    dataGridView1.Columns.Add("Column3", "Column3");
                    dataGridView1.Columns.Add("Column4", "Column4");
                    return;
                case 5:
                    dataGridView1.Columns.Clear();

                    dataGridView1.Columns.Add("Column1", "Column1");
                    dataGridView1.Columns.Add("Column2", "Column2");
                    dataGridView1.Columns.Add("Column3", "Column3");
                    dataGridView1.Columns.Add("Column4", "Column4");
                    dataGridView1.Columns.Add("Column5", "Column5");
                    return;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            var width = Int32.Parse(numericUpDown2.Value.ToString());

            dataGridView1.RowHeadersVisible = true;
            dataGridView1.RowHeadersWidth = 100;

            switch (width)
            {
                case 1:
                    dataGridView1.Rows.Clear();

                    dataGridView1.Rows.Add(1);
                    dataGridView1.Rows[0].HeaderCell.Value = "Row 1";
                    break;
                case 2:
                    dataGridView1.Rows.Clear();

                    dataGridView1.Rows.Add(2);
                    dataGridView1.Rows[0].HeaderCell.Value = "Row 1";
                    dataGridView1.Rows[1].HeaderCell.Value = "Row 2";
                    break;
                case 3:
                    dataGridView1.Rows.Clear();

                    dataGridView1.Rows.Add(3);
                    dataGridView1.Rows[0].HeaderCell.Value = "Row 1";
                    dataGridView1.Rows[1].HeaderCell.Value = "Row 2";
                    dataGridView1.Rows[2].HeaderCell.Value = "Row 3";
                    break;
                case 4:
                    dataGridView1.Rows.Clear();

                    dataGridView1.Rows.Add(4);
                    dataGridView1.Rows[0].HeaderCell.Value = "Row 1";
                    dataGridView1.Rows[1].HeaderCell.Value = "Row 2";
                    dataGridView1.Rows[2].HeaderCell.Value = "Row 3";
                    dataGridView1.Rows[3].HeaderCell.Value = "Row 4";
                    break;
                case 5:
                    dataGridView1.Rows.Clear();

                    dataGridView1.Rows.Add(5);
                    dataGridView1.Rows[0].HeaderCell.Value = "Row 1";
                    dataGridView1.Rows[1].HeaderCell.Value = "Row 2";
                    dataGridView1.Rows[2].HeaderCell.Value = "Row 3";
                    dataGridView1.Rows[3].HeaderCell.Value = "Row 4";
                    dataGridView1.Rows[4].HeaderCell.Value = "Row 5";
                    break;
            }
        }

        void ProduceEchelonForm()
        {
            // create a matrix
            Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(new double[,]
            {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
            });

            // set tolerance for determining nonzero pivot elements
            double tol = 1e-12;

            // perform Gaussian elimination with partial pivoting to reduce matrix to echelon form
            for (int i = 0; i < matrix.RowCount; i++)
            {
                // find pivot element
                int pivotRow = i;
                double pivotValue = Math.Abs(matrix[i, i]);
                for (int j = i + 1; j < matrix.RowCount; j++)
                {
                    double value = Math.Abs(matrix[j, i]);
                    if (value > pivotValue + tol)
                    {
                        pivotRow = j;
                        pivotValue = value;
                    }
                }

                // swap rows if necessary
                if (pivotRow != i)
                {
                    Vector<double> temp = matrix.Row(i);
                    matrix.SetRow(i, matrix.Row(pivotRow));
                    matrix.SetRow(pivotRow, temp);
                }

                // eliminate lower rows
                for (int j = i + 1; j < matrix.RowCount; j++)
                {
                    double factor = matrix[j, i] / matrix[i, i];
                    for (int k = i; k < matrix.ColumnCount; k++)
                    {
                        matrix[j, k] -= factor * matrix[i, k];
                    }
                }
            }

            // divide each row by its pivot element to obtain 1's on the diagonal
            for (int i = 0; i < matrix.RowCount; i++)
            {
                double pivot = matrix[i, i];
                if (Math.Abs(pivot) > tol)
                {
                    for (int j = i; j < matrix.ColumnCount; j++)
                    {
                        matrix[i, j] /= pivot;
                    }
                }
            }

            // display echelon form
            // textBox1.Text += "Echelon form:" + "\n\r" + "\n\r";
            // textBox1.Text += matrix.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m1 = Matrix<double>.Build.Dense(Int32.Parse(numericUpDown1.Value.ToString()), Int32.Parse(numericUpDown2.Value.ToString()));

            CopyMatrixToDataGrid(m1);

            m2 = m1.Inverse();

            FillMatrixColumns3(m2);
        }

        void FillMatrixColumns3(Matrix<double> m3)
        {
            // Set cell values in the DataTable
            for (int i = 0; i < m3.RowCount; i++)
            {
                for (int j = 0; j < m3.ColumnCount; j++)
                {
                    DataGridViewCell cell = dataGridView2[j, i];
                    cell.Value = m3[i, j];
                }
            }
        }

        void CopyMatrixToDataGrid(Matrix<double> m1)
        {
            dataGridView2.RowCount = m1.RowCount;
            dataGridView2.ColumnCount = m1.ColumnCount;
            // Set cell values in the DataTable
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    DataGridViewCell cell = dataGridView1[j, i];
                    m1[i, j] = double.Parse(cell.Value.ToString());
                }
            }
        }
    }
}
