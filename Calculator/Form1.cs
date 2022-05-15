using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public delegate void NumberChangedDelegate(object sender, EventArgs e);
    public partial class Form1 : Form
    {
        private int number1, number2;
        public int Number1 {
            get { return number1; }
            set
            {
                number1 = value;
                Number1Changed(this, EventArgs.Empty);
            }
        }
        public int Number2
        {
            get { return number2; }
            set
            {
                number2 = value;
                Number2Changed(this, EventArgs.Empty);
            }
        }

        //Írjak eseményt, ami akkor következik be, ha number1 vagy number2 megváltozik

        private bool number1IsValid, number2IsValid = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = (Number1 + Number2).ToString();
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
            //raise event?
        }

        private void arg2_Leave(object sender, EventArgs e)
        {
            CheckFormatAndConvert(arg2, out number2, out number2IsValid);
            //raise event?
        }

        public event NumberChangedDelegate Number1Changed;
        public event NumberChangedDelegate Number2Changed;
    }
}
