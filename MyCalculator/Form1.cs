using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal number1;
            decimal number2;
            decimal answer;

            if (DataValid())
            {
                number1 = Convert.ToDecimal(txtNumber1.Text);
                number2 = Convert.ToDecimal(txtNumber2.Text);

                answer = number1 + number2;

                txtAnswer.Text = Convert.ToString(answer);
            }
            else
            {
                MessageBox.Show("Problems here");
            }
        }

        private bool DataValid()
        {
            if (IsDecimal(txtNumber1) && IsDecimal(txtNumber2))
            {
                return true;
            }
            return false;
        }

        private bool IsDecimal(TextBox tb)
        {
            decimal num;
            if(decimal.TryParse(tb.Text, out num))
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}
