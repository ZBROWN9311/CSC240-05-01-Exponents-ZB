using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name: Zachary Brown
 * Date: 10/30/22
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {            
            int num;            
            num = Convert.ToInt32(InputTextBox.Text);            
            xOutputLabel.Text = String.Format("Square = {0}", Square(num));            
            xOutputLabel.Text += String.Format("\nCube = {0}", Cube(num));            
            xOutputLabel.Visible = true;            
            this.GoButton.Enabled = false;
        }

        public int Square(int num)
        {            
            return num * num;
        }

        public int Cube(int num)
        {            
            return num * num * num;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {            
            InputTextBox.Clear();
            xOutputLabel.Text = "";            
            xOutputLabel.Visible = false;            
            this.GoButton.Enabled = true;
        }

    }
}
