using MathNet.Numerics.LinearAlgebra;
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
    public partial class dataGridPratice : Form
    {
        MatrixBuilder<double> basicMatrix = Matrix<double>.Build;
        Matrix<double> rowMatrix;
        public dataGridPratice()
        {
            InitializeComponent();
            rowMatrix = basicMatrix.DenseOfColumnArrays(
         new[] { 1.0, 2.0, 3.0, 4.0 },
         new[] { 5.0, 6.0, 7.0, 8.0 },
         new[] { 11.0, 12.0, 13.0, 14.0 },
         new[] { 15.0, 16.0, 17.0, 18.0 });

            Matrix<double> columnMatrix = Matrix<double>.Build.DenseOfArray(new double[,]
            {
                    { 1, 2, 3, 4 },
                    { 4, 5, 6, 7 },
                    { 7, 8, 9, 10 },
                    { 11, 12, 13, 14 },
            });
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Columns.Add("Column2", "Column 2");
            dataGridView1.Columns.Add("Column3", "Column 3");
            dataGridView1.Columns.Add("Column4", "Column 4");
            dataGridView1.Rows.Add(4);

            CopyMatrixToDataGrid(rowMatrix, dataGridView1);
            Math.Log(1);

        }

        void CopyMatrixToDataGrid(Matrix<double> m1, DataGridView dataGridView)
        {
            dataGridView.RowCount = m1.RowCount;
            dataGridView.ColumnCount = m1.ColumnCount;
            // Set cell values in the DataTable
            for (int i = 0; i < m1.RowCount; i++)
            {
                for (int j = 0; j < m1.ColumnCount; j++)
                {
                    DataGridViewCell cell = dataGridView[i, j];
                    dataGridView1 = cell.DataGridView;
                    cell.Value = m1[i, j];
                }
            }
        }

        void CopyDataGridToMatrix(Matrix<double> m1,DataGridView dataGridView)
        {
            dataGridView.RowCount = m1.RowCount;
            dataGridView.ColumnCount = m1.ColumnCount;
            // Set cell values in the DataTable
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    DataGridViewCell cell = dataGridView[i, j];
                    m1[i, j] = double.Parse(cell.Value.ToString());
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "DataGrid copied to Matrix";
            CopyMatrixToDataGrid(rowMatrix, dataGridView2);
        }
    }
}
