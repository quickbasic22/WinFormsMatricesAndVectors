using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMatricesAndVectors
{
   public partial class NbyMMatrixLoop : Form
    {
        Button[,] buttons = new Button[4, 4];
        public NbyMMatrixLoop()
        {
            InitializeComponent();
            string[,] btnText = new string[4,4];
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
            LightUpMatrixDimensions(0, 0);
        }
        private void button2_Click(object sender, EventArgs e)
        {

            LightUpMatrixDimensions(0, 1);
        }
       private void button3_Click(object sender, EventArgs e)
        {
            LightUpMatrixDimensions(0, 2);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            LightUpMatrixDimensions(0, 3);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            LightUpMatrixDimensions(1, 0);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            LightUpMatrixDimensions(1, 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LightUpMatrixDimensions(1, 2);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            LightUpMatrixDimensions(1, 3);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            LightUpMatrixDimensions(2, 0);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            LightUpMatrixDimensions(2, 1);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            LightUpMatrixDimensions(2, 2);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            LightUpMatrixDimensions(2, 3);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            LightUpMatrixDimensions(3, 0);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            LightUpMatrixDimensions(3, 1);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            LightUpMatrixDimensions(3, 2);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            LightUpMatrixDimensions(3, 3);
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
    }
}
