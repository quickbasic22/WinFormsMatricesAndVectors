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
using System.Text.Unicode;

namespace WinFormsMatricesAndVectors
{
    public partial class dataGridPratice : Form
    {
        MatrixBuilder<double> basicMatrix = Matrix<double>.Build;
        Matrix<double> MatrixA;
        Matrix<double> MatrixB;
        Matrix<double> MatrixC;
        Matrix<double> rowMatrix;
        string comboBoxChoice = "";
        public dataGridPratice()
        {
            InitializeComponent();
            MatrixA = basicMatrix.DenseOfColumnArrays(
         new[] { 1.0, 2.0, 3.0, 4.0 },
         new[] { 5.0, 6.0, 7.0, 8.0 },
         new[] { 11.0, 12.0, 13.0, 14.0 },
         new[] { 15.0, 16.0, 17.0, 18.0 });

            MatrixB = Matrix<double>.Build.DenseOfArray(new double[,]
          {
                    { 1, 2, 3, 4 },
                    { 4, 5, 6, 7 },
                    { 7, 8, 9, 10 },
                    { 11, 12, 13, 14 },
          });
            dataGridView1.Rows.Clear();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Columns.Add("Column2", "Column 2");
            dataGridView1.Columns.Add("Column3", "Column 3");
            dataGridView1.Columns.Add("Column4", "Column 4");
            dataGridView1.Rows.Add(4);

            dataGridView2.Rows.Clear();
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.Columns.Add("Column1", "Column 1");
            dataGridView2.Columns.Add("Column2", "Column 2");
            dataGridView2.Columns.Add("Column3", "Column 3");
            dataGridView2.Columns.Add("Column4", "Column 4");
            dataGridView2.Rows.Add(4);

            dataGridView3.Rows.Clear();
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.Columns.Add("Column1", "Column 1");
            dataGridView3.Columns.Add("Column2", "Column 2");
            dataGridView3.Columns.Add("Column3", "Column 3");
            dataGridView3.Columns.Add("Column4", "Column 4");
            dataGridView3.Rows.Add(4);

            CopyMatrixToDataGrid(MatrixA, dataGridView1);
            CopyMatrixToDataGrid(MatrixB, dataGridView2);
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                DataGridViewColumn destCol = dataGridView2.Columns[col.Name];
                DataGridViewColumn destCol2 = dataGridView3.Columns[col.Name];

                if (destCol != null)
                {
                    // Set style settings for destination column
                    destCol.DefaultCellStyle = col.DefaultCellStyle;
                    destCol.HeaderCell.Style = col.HeaderCell.Style;
                    destCol.Width = col.Width;

                    destCol2.DefaultCellStyle = col.DefaultCellStyle;
                    destCol2.HeaderCell.Style = col.HeaderCell.Style;
                    destCol2.Width = col.Width;
                }
            }
            dataGridView2.Refresh();
            dataGridView3.Refresh();
            label1.Text = string.Format("{0}", "\\U002B");

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

        void CopyDataGridToMatrix(Matrix<double> m1, DataGridView dataGridView)
        {

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

            dataGridView2.Rows.Clear();
            label1.Text = "DataGrid copied to Matrix";
            CopyMatrixToDataGrid(MatrixA, dataGridView2);
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //CopyDataGridToMatrix(MatrixA, dataGridView1);
            //CopyMatrixToDataGrid(MatrixB, dataGridView2);
        }

        private void cmbMatrixOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Arial", 60f, FontStyle.Bold);
            switch (cmbMatrixOperation.SelectedIndex)
            {
                case 0:
                    comboBoxChoice = "Addition";
                    richTextBox1.Text = char.ConvertFromUtf32(0x2B);
                    break;
                case 1:
                    comboBoxChoice = "Subtraction";
                    richTextBox1.Text = char.ConvertFromUtf32(0x2212);
                    break;
                case 2:
                    comboBoxChoice = "Multiplication";
                    richTextBox1.Text = char.ConvertFromUtf32(0xD7);
                    break;
                case 3:
                    comboBoxChoice = "Inverse";
                    richTextBox1.Text = char.ConvertFromUtf32(0xF7);
                    break;
                default:
                    comboBoxChoice = "none";
                    richTextBox1.Text = @"None";
                    break;
            }
            label1.Text = comboBoxChoice;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            switch (comboBoxChoice)
            {
                case "Addition":
                    CopyDataGridToMatrix(MatrixA, dataGridView1);
                    CopyDataGridToMatrix(MatrixB, dataGridView2);
                    MatrixC = MatrixA + MatrixB;
                    CopyMatrixToDataGrid(MatrixC, dataGridView3);
                    break;
                case "Subtraction":
                    CopyDataGridToMatrix(MatrixA, dataGridView1);
                    CopyDataGridToMatrix(MatrixB, dataGridView2);
                    MatrixC = MatrixA - MatrixB;
                    CopyMatrixToDataGrid(MatrixC, dataGridView3);
                    break;
                case "Multiplication":
                    CopyDataGridToMatrix(MatrixA, dataGridView1);
                    CopyDataGridToMatrix(MatrixB, dataGridView2);
                    MatrixC = MatrixA * MatrixB;
                    CopyMatrixToDataGrid(MatrixC, dataGridView3);
                    break;
                case "Inverse":
                    CopyDataGridToMatrix(MatrixA, dataGridView1);
                    CopyDataGridToMatrix(MatrixB, dataGridView2);
                    CopyMatrixToDataGrid(MatrixA.Inverse(), dataGridView1);
                    CopyMatrixToDataGrid(MatrixB.Inverse(), dataGridView2);
                    break;
            }

        }

        private void Matrix2x2Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView1.RowCount = 2;
            dataGridView1.ColumnCount = 2;
            dataGridView2.RowCount = 2;
            dataGridView2.ColumnCount = 2;
            dataGridView3.RowCount = 2;
            dataGridView3.ColumnCount = 2;
            MatrixA.Clear();
            
           MatrixA = Matrix<double>.Build.DenseOfColumnArrays(
               new[] { 2.0, 3.0 },
               new[] { 5.0, 6.0 });

            MatrixB = Matrix<double>.Build.DenseOfColumnArrays(
              new[] { 2.0, 3.0 },
              new[] { 5.0, 6.0 });

            CopyMatrixToDataGrid(MatrixA, dataGridView1);
            CopyMatrixToDataGrid(MatrixB, dataGridView2);

        }

        private void Matrix3x3Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;
            dataGridView2.RowCount = 3;
            dataGridView2.ColumnCount = 3;
            dataGridView3.RowCount = 3;
            dataGridView3.ColumnCount = 3;
            MatrixA.Clear();

            MatrixA = Matrix<double>.Build.DenseOfColumnArrays(
                new[] { 2.0, 3.0, 4.0 },
                new[] { 5.0, 6.0, 7.0 },
                new[] { 11.0, 12,0, 13.0 });

            MatrixB = Matrix<double>.Build.DenseOfColumnArrays(
                new[] { 2.0, 3.0, 4.0 },
                new[] { 5.0, 6.0, 7.0 },
                new[] { 11.0, 12, 0, 13.0 });
            CopyMatrixToDataGrid(MatrixA, dataGridView1);
            CopyMatrixToDataGrid(MatrixB, dataGridView2);
        }

        private void Matrix4x4(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView1.RowCount = 4;
            dataGridView1.ColumnCount = 4;
            dataGridView2.RowCount = 4;
            dataGridView2.ColumnCount = 4;
            dataGridView3.RowCount = 4;
            dataGridView3.ColumnCount = 4;
            MatrixA.Clear();

            MatrixA = Matrix<double>.Build.DenseOfColumnArrays(
                new[] { 2.0, 3.0, 4.0, 5.0 },
                new[] { 5.0, 6.0, 7.0, 8.0 },
                new[] { 11.0, 12, 0, 13.0, 14.0 });

            MatrixB = Matrix<double>.Build.DenseOfColumnArrays(
                new[] { 2.0, 3.0, 4.0 },
                new[] { 5.0, 6.0, 7.0 },
                new[] { 11.0, 12, 0, 13.0 });
            CopyMatrixToDataGrid(MatrixA, dataGridView1);
            CopyMatrixToDataGrid(MatrixB, dataGridView2);
        }
    }
}
