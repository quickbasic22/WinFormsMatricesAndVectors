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
            int count = 1;
            for (int i = 0; i < 4;i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    buttons[i, j].BackColor = Color.Red;
                    buttons[i, j].Text = "Matrix" + count.ToString();
                    count++;
                }
            }       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Code for button2_Click event handler
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Code for button3_Click event handler
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Code for button4_Click event handler
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Code for button5_Click event handler
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Code for button6_Click event handler
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Code for button7_Click event handler
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Code for button8_Click event handler
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Code for button9_Click event handler
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Code for button10_Click event handler
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Code for button11_Click event handler
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Code for button12_Click event handler
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Code for button13_Click event handler
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Code for button14_Click event handler
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Code for button15_Click event handler
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Code for button16_Click event handler
        }



    }
}
