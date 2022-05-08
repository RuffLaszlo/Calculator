using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private int number1, number2;
        private bool number1IsValid, number2IsValid = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = (number1 + number2).ToString();
        }

        private bool CheckFormatAndConvert(TextBox tb, out int output, out bool validity)
        {
            validity = int.TryParse(tb.Text, out output);

            if (validity)
            {
                tb.BackColor = Color.White;
                this.button1.Enabled = number1IsValid && number2IsValid;
            }
            else
            {
                tb.BackColor = Color.Red;
                this.button1.Enabled = false;
            }

            return validity;
        }

        private void arg1_Leave(object sender, EventArgs e)
        {
            CheckFormatAndConvert(arg1, out number1, out number1IsValid);
        }

        private void arg2_Leave(object sender, EventArgs e)
        {
            CheckFormatAndConvert(arg2, out number2, out number2IsValid);
        }

    }
}
