using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public delegate void TextBoxValidityChangedDelegate(TextBox textbox, bool validity);
    public partial class Form1 : Form
    {
        private int number1, number2;

        //Írjak eseményt, ami akkor következik be, ha number1 vagy number2 megváltozik

        private bool number1IsValid = true;
        private bool number2IsValid = true;

        public bool Number1IsValid
        {
            get { return number1IsValid; }
            set 
            {
                if (value == number1IsValid)
                {
                    return;
                }
                number1IsValid = value;
                TextBoxValidityChanged(arg1, value);
            }
        }

        public bool Number2IsValid
        {
            get { return number2IsValid; }
            set 
            {
                if (value == number2IsValid)
                {
                    return;
                }
                number2IsValid = value;
                TextBoxValidityChanged(arg2, value);
            }
        }


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
            return validity;
        }

        private void arg1_Leave(object sender, EventArgs e)
        {
            CheckFormatAndConvert(arg1, out int number, out bool numberisValid);
            number1 = numberisValid ? number : 0;
            Number1IsValid = numberisValid;
        }

        private void arg2_Leave(object sender, EventArgs e)
        {
            CheckFormatAndConvert(arg2, out int number, out bool numberisValid);
            number2 = numberisValid ? number : 0;
            Number2IsValid = numberisValid;
        }

        private void OnTextBoxValidityChanged(TextBox textbox, bool validity)
        {
            if (validity)
            {
                ChangeToValid(textbox);
            }
            else
            {
                ChangeToInValid(textbox);
            }
            this.button1.Enabled = number1IsValid && number2IsValid;
        }

        private void ChangeToValid(TextBox tb)
        {
            tb.BackColor = Color.White;
            tb.ForeColor = Color.Black;
        }

        private void ChangeToInValid(TextBox tb)
        {
            tb.BackColor = Color.Red;
            tb.ForeColor = Color.White;
        }

        public event TextBoxValidityChangedDelegate TextBoxValidityChanged;
    }
}
