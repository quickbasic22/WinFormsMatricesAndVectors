using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.Data.Text;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.Distributions;
using System.Windows.Forms;
using System.Data;

namespace WinFormsMatricesAndVectors
{
    public partial class Form1 : Form
    {
             Matrix<double> m1;
             Matrix<double> m2;
             Matrix<double> m3;
             Matrix<double> resultMatrix;
             
        public Form1()
        {
            InitializeComponent();
            Matrix1.RowCount = 2;
            Matrix2.RowCount = 2;
            Matrix3.RowCount = 2;
            Matrix1.ColumnCount = 2;
            Matrix2.ColumnCount = 2;
            Matrix3.ColumnCount = 2;

            Matrix1.ColumnCount = 1;
            Matrix2.ColumnCount = 1;
            Matrix3.ColumnCount = 1;

            Matrix1RowWidth.Minimum = 2;
            Matrix1ColumnWidth.Minimum = 1;
            Matrix1RowWidth.Maximum = 5;
            Matrix1ColumnWidth.Maximum = 5;
            Matrix1RowWidth.Value = 2;
            Matrix1ColumnWidth.Value = 2;

            Matrix2RowWidth.Minimum = 2;
            Matrix2ColumnWidth.Minimum = 1;
            Matrix2RowWidth.Maximum = 5;
            Matrix2ColumnWidth.Maximum = 5;
            Matrix2RowWidth.Value = 2;
            Matrix2ColumnWidth.Value = 2;

            Matrix3RowWidth.Minimum = 2;
            Matrix3ColumnWidth.Minimum = 1;
            Matrix3RowWidth.Maximum = 5;
            Matrix3ColumnWidth.Maximum = 5;
            Matrix3RowWidth.Value = 2;
            Matrix3ColumnWidth.Value = 2;
        }

        private void Matrix1ColumnWidth_ValueChanged(object sender, EventArgs e)
        {
            var width = Int32.Parse(Matrix1ColumnWidth.Value.ToString());

            Matrix1.ColumnHeadersVisible = true;


            switch (width)
            {
                case 1:
                    Matrix1.Columns.Clear();
                    Matrix1.Columns.Add("Column1", "Column1");
                    return;
                case 2:
                    Matrix1.Columns.Clear();
                    Matrix1.Columns.Add("Column1", "Column1");
                    Matrix1.Columns.Add("Column2", "Column2");
                    return;
                case 3:
                    Matrix1.Columns.Clear();
                    Matrix1.Columns.Add("Column1", "Column1");
                    Matrix1.Columns.Add("Column2", "Column2");
                    Matrix1.Columns.Add("Column3", "Column3");
                    return;
                case 4:
                    Matrix1.Columns.Clear();
                    Matrix1.Columns.Add("Column1", "Column1");
                    Matrix1.Columns.Add("Column2", "Column2");
                    Matrix1.Columns.Add("Column3", "Column3");
                    Matrix1.Columns.Add("Column4", "Column4");
                    return;
                case 5:
                    Matrix1.Columns.Clear();
                    Matrix1.Columns.Add("Column1", "Column1");
                    Matrix1.Columns.Add("Column2", "Column2");
                    Matrix1.Columns.Add("Column3", "Column3");
                    Matrix1.Columns.Add("Column4", "Column4");
                    Matrix1.Columns.Add("Column5", "Column5");
                    return;
            }
        }

        private void Matrix2ColumnWidth_ValueChanged(object sender, EventArgs e)
        {
            var width = Int32.Parse(Matrix2ColumnWidth.Value.ToString());

            Matrix2.ColumnHeadersVisible = true;

            switch (width)
            {
                case 1:
                    Matrix2.Columns.Clear();
                    Matrix2.Columns.Add("Column1", "Column1");
                    return;
                case 2:
                    Matrix2.Columns.Clear();
                    Matrix2.Columns.Add("Column1", "Column1");
                    Matrix2.Columns.Add("Column2", "Column2");
                    return;
                case 3:
                    Matrix2.Columns.Clear();
                    Matrix2.Columns.Add("Column1", "Column1");
                    Matrix2.Columns.Add("Column2", "Column2");
                    Matrix2.Columns.Add("Column3", "Column3");
                    return;
                case 4:
                    Matrix2.Columns.Clear();
                    Matrix2.Columns.Add("Column1", "Column1");
                    Matrix2.Columns.Add("Column2", "Column2");
                    Matrix2.Columns.Add("Column3", "Column3");
                    Matrix2.Columns.Add("Column4", "Column4");
                    return;
                case 5:
                    Matrix2.Columns.Clear();
                    Matrix2.Columns.Add("Column1", "Column1");
                    Matrix2.Columns.Add("Column2", "Column2");
                    Matrix2.Columns.Add("Column3", "Column3");
                    Matrix2.Columns.Add("Column4", "Column4");
                    Matrix2.Columns.Add("Column5", "Column5");
                    return;
            }
        }

        private void Matrix2RowWidth_ValueChanged(object sender, EventArgs e)
        {
            var width = Int32.Parse(Matrix2RowWidth.Value.ToString());

            Matrix2.RowHeadersVisible = true;
            Matrix2.RowHeadersWidth = 100;

            switch (width)
            {
                case 1:
                    Matrix2.Rows.Clear();
                    Matrix2.Rows.Add(1);
                    Matrix2.Rows[0].HeaderCell.Value = "Row 1";
                    break;
                case 2:
                    Matrix2.Rows.Clear();
                    Matrix2.Rows.Add(2);
                    Matrix2.Rows[0].HeaderCell.Value = "Row 1";
                    Matrix2.Rows[1].HeaderCell.Value = "Row 2";
                    break;
                case 3:
                    Matrix2.Rows.Clear();
                    Matrix2.Rows.Add(3);
                    Matrix2.Rows[0].HeaderCell.Value = "Row 1";
                    Matrix2.Rows[1].HeaderCell.Value = "Row 2";
                    Matrix2.Rows[2].HeaderCell.Value = "Row 3";
                    break;
                case 4:
                    Matrix2.Rows.Clear();
                    Matrix2.Rows.Add(4);
                    Matrix2.Rows[0].HeaderCell.Value = "Row 1";
                    Matrix2.Rows[1].HeaderCell.Value = "Row 2";
                    Matrix2.Rows[2].HeaderCell.Value = "Row 3";
                    Matrix2.Rows[3].HeaderCell.Value = "Row 4";
                    break;
                case 5:
                    Matrix2.Rows.Clear();
                    Matrix2.Rows.Add(5);
                    Matrix2.Rows[0].HeaderCell.Value = "Row 1";
                    Matrix2.Rows[1].HeaderCell.Value = "Row 2";
                    Matrix2.Rows[2].HeaderCell.Value = "Row 3";
                    Matrix2.Rows[3].HeaderCell.Value = "Row 4";
                    Matrix2.Rows[4].HeaderCell.Value = "Row 5";
                    break;
            }
        }

        private void Matrix3ColumnWidth_ValueChanged(object sender, EventArgs e)
        {
            var width = Int32.Parse(Matrix3ColumnWidth.Value.ToString());

            Matrix3.ColumnHeadersVisible = true;

            switch (width)
            {
                case 1:
                    Matrix3.Columns.Clear();
                    Matrix3.Columns.Add("Column1", "Column1");
                    return;
                case 2:
                    Matrix3.Columns.Clear();
                    Matrix3.Columns.Add("Column1", "Column1");
                    Matrix3.Columns.Add("Column2", "Column2");
                    return;
                case 3:
                    Matrix3.Columns.Clear();
                    Matrix3.Columns.Add("Column1", "Column1");
                    Matrix3.Columns.Add("Column2", "Column2");
                    Matrix3.Columns.Add("Column3", "Column3");
                    return;
                case 4:
                    Matrix3.Columns.Clear();
                    Matrix3.Columns.Add("Column1", "Column1");
                    Matrix3.Columns.Add("Column2", "Column2");
                    Matrix3.Columns.Add("Column3", "Column3");
                    Matrix3.Columns.Add("Column4", "Column4");
                    return;
                case 5:
                    Matrix3.Columns.Clear();
                    Matrix3.Columns.Add("Column1", "Column1");
                    Matrix3.Columns.Add("Column2", "Column2");
                    Matrix3.Columns.Add("Column3", "Column3");
                    Matrix3.Columns.Add("Column4", "Column4");
                    Matrix3.Columns.Add("Column5", "Column5");
                    return;
            }
        }

        private void Matrix3RowWidth_ValueChanged(object sender, EventArgs e)
        {
            var width = Int32.Parse(Matrix3RowWidth.Value.ToString());


            Matrix3.RowHeadersVisible = true;
            Matrix3.RowHeadersWidth = 100;

            switch (width)
            {
                case 1:
                    Matrix3.Rows.Clear();
                    Matrix3.Rows.Add(1);
                    Matrix3.Rows[0].HeaderCell.Value = "Row 1";
                    break;
                case 2:
                    Matrix3.Rows.Clear();
                    Matrix3.Rows.Add(2);
                    Matrix3.Rows[0].HeaderCell.Value = "Row 1";
                    Matrix3.Rows[1].HeaderCell.Value = "Row 2";
                    break;
                case 3:
                    Matrix3.Rows.Clear();
                    Matrix3.Rows.Add(3);
                    Matrix3.Rows[0].HeaderCell.Value = "Row 1";
                    Matrix3.Rows[1].HeaderCell.Value = "Row 2";
                    Matrix3.Rows[2].HeaderCell.Value = "Row 3";
                    break;
                case 4:
                    Matrix3.Rows.Clear();
                    Matrix3.Rows.Add(4);
                    Matrix3.Rows[0].HeaderCell.Value = "Row 1";
                    Matrix3.Rows[1].HeaderCell.Value = "Row 2";
                    Matrix3.Rows[2].HeaderCell.Value = "Row 3";
                    Matrix3.Rows[3].HeaderCell.Value = "Row 4";
                    break;
                case 5:
                    Matrix3.Rows.Clear();
                    Matrix3.Rows.Add(5);
                    Matrix3.Rows[0].HeaderCell.Value = "Row 1";
                    Matrix3.Rows[1].HeaderCell.Value = "Row 2";
                    Matrix3.Rows[2].HeaderCell.Value = "Row 3";
                    Matrix3.Rows[3].HeaderCell.Value = "Row 4";
                    Matrix3.Rows[4].HeaderCell.Value = "Row 5";
                    break;
            }
        }

        private void Matrix1RowWidth_ValueChanged(object sender, EventArgs e)
        {
            var width = Int32.Parse(Matrix1RowWidth.Value.ToString());


            Matrix1.RowHeadersVisible = true;
            Matrix1.RowHeadersWidth = 100;

            switch (width)
            {
                case 1:
                    Matrix1.Rows.Clear();
                    Matrix1.Rows.Add(1);
                    Matrix1.Rows[0].HeaderCell.Value = "Row 1";
                    break;
                case 2:
                    Matrix1.Rows.Clear();
                    Matrix1.Rows.Add(2);
                    Matrix1.Rows[0].HeaderCell.Value = "Row 1";
                    Matrix1.Rows[1].HeaderCell.Value = "Row 2";
                    break;
                case 3:
                    Matrix1.Rows.Clear();
                    Matrix1.Rows.Add(3);
                    Matrix1.Rows[0].HeaderCell.Value = "Row 1";
                    Matrix1.Rows[1].HeaderCell.Value = "Row 2";
                    Matrix1.Rows[2].HeaderCell.Value = "Row 3";
                    break;
                case 4:
                    Matrix1.Rows.Clear();
                    Matrix1.Rows.Add(4);
                    Matrix1.Rows[0].HeaderCell.Value = "Row 1";
                    Matrix1.Rows[1].HeaderCell.Value = "Row 2";
                    Matrix1.Rows[2].HeaderCell.Value = "Row 3";
                    Matrix1.Rows[3].HeaderCell.Value = "Row 4";
                    break;
                case 5:
                    Matrix1.Rows.Clear();
                    Matrix1.Rows.Add(5);
                    Matrix1.Rows[0].HeaderCell.Value = "Row 1";
                    Matrix1.Rows[1].HeaderCell.Value = "Row 2";
                    Matrix1.Rows[2].HeaderCell.Value = "Row 3";
                    Matrix1.Rows[3].HeaderCell.Value = "Row 4";
                    Matrix1.Rows[4].HeaderCell.Value = "Row 5";
                    break;
            }
        }

        private void Matrix1_DoubleClick(object sender, EventArgs e)
        {
            double[,] dataArray = new double[Matrix1.Rows.Count - 1, Matrix1.Columns.Count];

            for (int i = 0; i < Matrix1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < Matrix1.Columns.Count; j++)
                {
                    double cellValue;
                    if (double.TryParse(Matrix1.Rows[i].Cells[j].Value.ToString(), out cellValue))
                    {
                        dataArray[i, j] = cellValue;
                    }
                    else
                    {
                        // Handle parsing error, e.g. set default value or throw an exception
                    }
                }
            }

            Matrix<double> m1 = Matrix<double>.Build.DenseOfArray(dataArray);
            MessageBox.Show(m1.ToMatrixString());
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            Matrix<double> m1Matrix = Matrix<double>.Build.Dense(Int32.Parse(Matrix1RowWidth.Value.ToString()), Int32.Parse(Matrix1ColumnWidth.Value.ToString()));
            Matrix<double> m2Matrix = Matrix<double>.Build.Dense(Int32.Parse(Matrix2RowWidth.Value.ToString()), Int32.Parse(Matrix2ColumnWidth.Value.ToString()));
            Matrix<double> m3Matrix = Matrix<double>.Build.Dense(Int32.Parse(Matrix3RowWidth.Value.ToString()), Int32.Parse(Matrix3ColumnWidth.Value.ToString()));

            m1 = m1Matrix.Clone();
            m2 = m2Matrix.Clone();
            m3 = m3Matrix.Clone();

            FillMatrixColumns1(m1);
            FillMatrixColumns2(m2);


            switch (comboBox.SelectedIndex)
            {
                case 0:
                    resultMatrix = m1 + m2;
                    break;
                case 1:
                    resultMatrix = m1 - m2;
                    break;
                case 2:
                    resultMatrix = m1.PointwiseMultiply(m2);
                    break;
                case 3:
                    resultMatrix = m1.PointwiseDivide(m2);
                    break;
                case 4:
                    resultMatrix = m1.Inverse();
                    break;
                default:
                    resultMatrix = m1;
                    break;
            }
            FillMatrixColumns3(resultMatrix);
        }
       void FillMatrixColumns3(Matrix<double> matrix)
        {
            // Create a new DataTable
            DataTable dataTable = new DataTable();

            // Add columns to the DataTable
            for (int j = 0; j < m1.ColumnCount; j++)
            {
                dataTable.Columns.Add($"Column{j + 1}", typeof(double));
            }

            // Add rows to the DataTable
            for (int i = 0; i < m1.RowCount; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataTable.Rows.Add(dataRow);
            }

            // Set cell values in the DataTable
            for (int i = 0; i < m1.RowCount; i++)
            {
                for (int j = 0; j < m1.ColumnCount; j++)
                {
                    dataTable.Rows[i][j] = m1[i, j];
                }
            }

            // Bind the DataTable to the DataGridView
            Matrix3.DataSource = dataTable;
        }

        void FillMatrixColumns2(Matrix<double> matrix)
        {
            // Create a new DataTable
            DataTable dataTable = new DataTable();

            // Add columns to the DataTable
            for (int j = 0; j < m1.ColumnCount; j++)
            {
                dataTable.Columns.Add($"Column{j + 1}", typeof(double));
            }

            // Add rows to the DataTable
            for (int i = 0; i < m1.RowCount; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataTable.Rows.Add(dataRow);
            }

            // Set cell values in the DataTable
            for (int i = 0; i < m1.RowCount; i++)
            {
                for (int j = 0; j < m1.ColumnCount; j++)
                {
                    dataTable.Rows[i][j] = m1[i, j];
                }
            }

            // Bind the DataTable to the DataGridView
            Matrix2.DataSource = dataTable;
        }

        void FillMatrixColumns1(Matrix<double> matrix)
        {
            // Create a new DataTable
            DataTable dataTable = new DataTable();

            // Add columns to the DataTable
            for (int j = 0; j < m1.ColumnCount; j++)
            {
                dataTable.Columns.Add($"Column{j + 1}", typeof(double));
            }

            // Add rows to the DataTable
            for (int i = 0; i < m1.RowCount; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataTable.Rows.Add(dataRow);
            }

            // Set cell values in the DataTable
            for (int i = 0; i < m1.RowCount; i++)
            {
                for (int j = 0; j < m1.ColumnCount; j++)
                {
                    dataTable.Rows[i][j] = m1[i, j];
                }
            }

            // Bind the DataTable to the DataGridView
            Matrix1.DataSource = dataTable;
        }
    }
}