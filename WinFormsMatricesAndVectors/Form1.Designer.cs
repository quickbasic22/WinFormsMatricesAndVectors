namespace WinFormsMatricesAndVectors
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            matricesToolStripMenuItem = new ToolStripMenuItem();
            create3X4ToolStripMenuItem = new ToolStripMenuItem();
            vectorsToolStripMenuItem = new ToolStripMenuItem();
            create2X1ToolStripMenuItem = new ToolStripMenuItem();
            Matrix1 = new DataGridView();
            Matrix2 = new DataGridView();
            Matrix3 = new DataGridView();
            Matrix1ColumnWidth = new NumericUpDown();
            Matrix1RowWidth = new NumericUpDown();
            Matrix2RowWidth = new NumericUpDown();
            Matrix2ColumnWidth = new NumericUpDown();
            Matrix3RowWidth = new NumericUpDown();
            Matrix3ColumnWidth = new NumericUpDown();
            comboBox1 = new ComboBox();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Matrix1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Matrix2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Matrix3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Matrix1ColumnWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Matrix1RowWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Matrix2RowWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Matrix2ColumnWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Matrix3RowWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Matrix3ColumnWidth).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { matricesToolStripMenuItem, vectorsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1331, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // matricesToolStripMenuItem
            // 
            matricesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { create3X4ToolStripMenuItem });
            matricesToolStripMenuItem.Name = "matricesToolStripMenuItem";
            matricesToolStripMenuItem.Size = new Size(64, 20);
            matricesToolStripMenuItem.Text = "Matrices";
            // 
            // create3X4ToolStripMenuItem
            // 
            create3X4ToolStripMenuItem.Name = "create3X4ToolStripMenuItem";
            create3X4ToolStripMenuItem.Size = new Size(135, 22);
            create3X4ToolStripMenuItem.Text = "Create 3 x 4";
            // 
            // vectorsToolStripMenuItem
            // 
            vectorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { create2X1ToolStripMenuItem });
            vectorsToolStripMenuItem.Name = "vectorsToolStripMenuItem";
            vectorsToolStripMenuItem.Size = new Size(57, 20);
            vectorsToolStripMenuItem.Text = "Vectors";
            // 
            // create2X1ToolStripMenuItem
            // 
            create2X1ToolStripMenuItem.Name = "create2X1ToolStripMenuItem";
            create2X1ToolStripMenuItem.Size = new Size(135, 22);
            create2X1ToolStripMenuItem.Text = "Create 2 x 1";
            // 
            // Matrix1
            // 
            Matrix1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Matrix1.Location = new Point(143, 81);
            Matrix1.Name = "Matrix1";
            Matrix1.RowTemplate.Height = 25;
            Matrix1.Size = new Size(574, 185);
            Matrix1.TabIndex = 1;
            Matrix1.DoubleClick += Matrix1_DoubleClick;
            // 
            // Matrix2
            // 
            Matrix2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Matrix2.Location = new Point(143, 361);
            Matrix2.Name = "Matrix2";
            Matrix2.RowTemplate.Height = 25;
            Matrix2.Size = new Size(574, 185);
            Matrix2.TabIndex = 2;
            // 
            // Matrix3
            // 
            Matrix3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Matrix3.Location = new Point(818, 248);
            Matrix3.Name = "Matrix3";
            Matrix3.RowTemplate.Height = 25;
            Matrix3.Size = new Size(574, 185);
            Matrix3.TabIndex = 3;
            // 
            // Matrix1ColumnWidth
            // 
            Matrix1ColumnWidth.Location = new Point(250, 52);
            Matrix1ColumnWidth.Name = "Matrix1ColumnWidth";
            Matrix1ColumnWidth.Size = new Size(47, 23);
            Matrix1ColumnWidth.TabIndex = 4;
            Matrix1ColumnWidth.ValueChanged += Matrix1ColumnWidth_ValueChanged;
            // 
            // Matrix1RowWidth
            // 
            Matrix1RowWidth.Location = new Point(60, 188);
            Matrix1RowWidth.Name = "Matrix1RowWidth";
            Matrix1RowWidth.Size = new Size(60, 23);
            Matrix1RowWidth.TabIndex = 5;
            Matrix1RowWidth.ValueChanged += Matrix1RowWidth_ValueChanged;
            // 
            // Matrix2RowWidth
            // 
            Matrix2RowWidth.Location = new Point(60, 468);
            Matrix2RowWidth.Name = "Matrix2RowWidth";
            Matrix2RowWidth.Size = new Size(60, 23);
            Matrix2RowWidth.TabIndex = 7;
            Matrix2RowWidth.ValueChanged += Matrix2RowWidth_ValueChanged;
            // 
            // Matrix2ColumnWidth
            // 
            Matrix2ColumnWidth.Location = new Point(260, 332);
            Matrix2ColumnWidth.Name = "Matrix2ColumnWidth";
            Matrix2ColumnWidth.Size = new Size(47, 23);
            Matrix2ColumnWidth.TabIndex = 6;
            Matrix2ColumnWidth.ValueChanged += Matrix2ColumnWidth_ValueChanged;
            // 
            // Matrix3RowWidth
            // 
            Matrix3RowWidth.Location = new Point(742, 361);
            Matrix3RowWidth.Name = "Matrix3RowWidth";
            Matrix3RowWidth.Size = new Size(60, 23);
            Matrix3RowWidth.TabIndex = 9;
            Matrix3RowWidth.ValueChanged += Matrix3RowWidth_ValueChanged;
            // 
            // Matrix3ColumnWidth
            // 
            Matrix3ColumnWidth.Location = new Point(1030, 207);
            Matrix3ColumnWidth.Name = "Matrix3ColumnWidth";
            Matrix3ColumnWidth.Size = new Size(47, 23);
            Matrix3ColumnWidth.TabIndex = 8;
            Matrix3ColumnWidth.ValueChanged += Matrix3ColumnWidth_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Addition", "Substraction", "Multipication", "Division", "Inverse" });
            comboBox1.Location = new Point(942, 490);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(277, 23);
            comboBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(982, 556);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 616);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(Matrix3RowWidth);
            Controls.Add(Matrix3ColumnWidth);
            Controls.Add(Matrix2RowWidth);
            Controls.Add(Matrix2ColumnWidth);
            Controls.Add(Matrix1RowWidth);
            Controls.Add(Matrix1ColumnWidth);
            Controls.Add(Matrix3);
            Controls.Add(Matrix2);
            Controls.Add(Matrix1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Matrix1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Matrix2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Matrix3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Matrix1ColumnWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)Matrix1RowWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)Matrix2RowWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)Matrix2ColumnWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)Matrix3RowWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)Matrix3ColumnWidth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem matricesToolStripMenuItem;
        private ToolStripMenuItem create3X4ToolStripMenuItem;
        private ToolStripMenuItem vectorsToolStripMenuItem;
        private ToolStripMenuItem create2X1ToolStripMenuItem;
        private DataGridView Matrix1;
        private DataGridView Matrix2;
        private DataGridView Matrix3;
        private NumericUpDown Matrix1ColumnWidth;
        private NumericUpDown Matrix1RowWidth;
        private NumericUpDown Matrix2RowWidth;
        private NumericUpDown Matrix2ColumnWidth;
        private NumericUpDown Matrix3RowWidth;
        private NumericUpDown Matrix3ColumnWidth;
        private ComboBox comboBox1;
        private Button button1;
    }
}