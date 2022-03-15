using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double FirstNumber;
        string Operation; 
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Main_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_On_Off_Click(object sender, EventArgs e)
        {
                System.Windows.Forms.Application.Exit();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            double n = 0;
            // Add function where if you press "0" it adds it as a decimal; ex: 02 = 0.2; 0003 = 0.003
            if ( textBox_Main.Text == "0" ) { textBox_Main.Text = n.ToString("0.0"); }
            else { textBox_Main.Text = textBox_Main.Text + n.ToString("0"); }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            double n = 1;
            if ( textBox_Main.Text == "0" && textBox_Main.Text != null ) { textBox_Main.Text = n.ToString("0"); }
            else { textBox_Main.Text = textBox_Main.Text + n.ToString("0"); }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            double n = 2;
            if (textBox_Main.Text == "0" && textBox_Main.Text != null) { textBox_Main.Text = n.ToString("0"); }
            else { textBox_Main.Text = textBox_Main.Text + n.ToString("0"); }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            double n = 3;
            if (textBox_Main.Text == "0" && textBox_Main.Text != null) { textBox_Main.Text = n.ToString("0"); }
            else { textBox_Main.Text = textBox_Main.Text + n.ToString("0"); }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            double n = 4;
            if (textBox_Main.Text == "0" && textBox_Main.Text != null) { textBox_Main.Text = n.ToString("0"); }
            else { textBox_Main.Text = textBox_Main.Text + n.ToString("0"); }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            double n = 5;
            if (textBox_Main.Text == "0" && textBox_Main.Text != null) { textBox_Main.Text = n.ToString("0"); }
            else { textBox_Main.Text = textBox_Main.Text + n.ToString("0"); }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            double n = 6;
            if (textBox_Main.Text == "0" && textBox_Main.Text != null) { textBox_Main.Text = n.ToString("0"); }
            else { textBox_Main.Text = textBox_Main.Text + n.ToString("0"); }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            double n = 7;
            if (textBox_Main.Text == "0" && textBox_Main.Text != null) { textBox_Main.Text = n.ToString("0"); }
            else { textBox_Main.Text = textBox_Main.Text + n.ToString("0"); }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            double n = 8;
            if (textBox_Main.Text == "0" && textBox_Main.Text != null) { textBox_Main.Text = n.ToString("0"); }
            else { textBox_Main.Text = textBox_Main.Text + n.ToString("0"); }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            double n = 9;
            if (textBox_Main.Text == "0" && textBox_Main.Text != null) { textBox_Main.Text = n.ToString("0"); }
            else { textBox_Main.Text = textBox_Main.Text + n.ToString("0"); }
        }

        private void button_addition_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox_Main.Text);
            textBox_Main.Text = "0";
            Operation = "+";
        }

        private void button_subtraction_Click(object sender, EventArgs e)
        {

        }

        private void button_multiplication_Click(object sender, EventArgs e)
        {

        }

        private void button_division_Click(object sender, EventArgs e)
        {

        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            if (textBox_Main.Text == "")
            {
                textBox_Main.Text = "test";
            }
            else
            {
                double SecondNumber;
                double Result;

                SecondNumber = Convert.ToDouble(textBox_Main.Text);

                if (Operation == "+")
                {
                    Result = (FirstNumber + SecondNumber);
                    textBox_Main.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Main.Text = "";
        }
    }
}
