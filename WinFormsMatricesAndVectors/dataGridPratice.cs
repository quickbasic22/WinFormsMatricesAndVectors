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
        public dataGridPratice()
        {
            InitializeComponent();
            Matrix<double> rowMatrix = Matrix<double>.Build.DenseOfColumnArrays(new[] { 1.0, 2.0, 3.0, 4.0 }, new[] { 5.0, 6.0, 7.0, 8.0 }, new[] { 11.0, 12.0, 13.0, 14.0 }, new[] { 15.0, 16.0, 17.0, 18.0 });

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
            CopyMatrixToDataGrid(rowMatrix);
            

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
                    dataGridView1 = cell.DataGridView;
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
