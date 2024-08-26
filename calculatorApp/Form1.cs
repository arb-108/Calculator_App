using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorApp
{
    public partial class Calculator : Form
    {
        private decimal firstnum = 0.0m;
        private decimal secondnum = 0.0m;
        private decimal result = 0.0m;
        private string operatorstring = "+";
        public Calculator()
        {
            InitializeComponent();
        }

 

    


        private void buttonone_Click(object sender, EventArgs e)
        {
            removezero(1);
        }

        private void removezero(int number)
        {
            if (calctextbox.Text == "0")
            {
                calctextbox.Text = number.ToString();
            }
            else
            {
                calctextbox.Text +=number.ToString();
            }
        }

        private void buttonzero_Click(object sender, EventArgs e)
        {
            removezero(0);
        }

        private void buttontwo_Click(object sender, EventArgs e)
        {
            removezero(2);
        }

        private void buttonthree_Click(object sender, EventArgs e)
        {
            removezero(3);
        }

        private void buttonfour_Click(object sender, EventArgs e)
        {
            removezero(4);
        }

        private void buttonfive_Click(object sender, EventArgs e)
        {
            removezero(5);
        }

        private void buttonsix_Click(object sender, EventArgs e)
        {
            removezero(6);
        }

        private void buttonminusplus_Click(object sender, EventArgs e)
        {
            if (!calctextbox.Text.Contains('-'))
            {
                calctextbox.Text='-'+calctextbox.Text;
            }
            else
            {
                calctextbox.Text = calctextbox.Text.Trim('-');
            }
        }

        private void buttonseven_Click(object sender, EventArgs e)
        {
            removezero(7);
        }

        private void buttoneight_Click(object sender, EventArgs e)
        {
            removezero(8);
        }

        private void buttonnine_Click(object sender, EventArgs e)
        {
            removezero(9);
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            calctextbox.Text = "0";
            firstnum = 0;
            secondnum = 0;
            result = 0;
        }

        private void buttondot_Click(object sender, EventArgs e)
        {
            if (!calctextbox.Text.Contains("."))
            {
                calctextbox.Text += ".";
            }
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            supplyto("-");
        }

        private void supplyto(string _operatorstring)
        {
            firstnum = decimal.Parse(calctextbox.Text);
            calctextbox.Text = "0";
            operatorstring = _operatorstring;
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            supplyto("+");
        }

        private void buttondivide_Click(object sender, EventArgs e)
        {
            supplyto("/");
        }

        private void buttonmultiply_Click(object sender, EventArgs e)
        {
            supplyto("*");
        }

        private void buttonpercent_Click(object sender, EventArgs e)
        {
            supplyto("%");
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            secondnum=decimal.Parse(calctextbox.Text);
            switch (operatorstring) {
                case "+":
                    result = firstnum + secondnum;
                    break;
                case "-":
                    result = firstnum - secondnum;
                    break;
                case "*":
                   result = firstnum * secondnum;
                    break;
                case "%":
                    result = firstnum % secondnum;
                    break;
                case "/":
                    result = firstnum / secondnum;
                    break;

            }
            calctextbox.Text=result.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PUCIT Student Develop this Calculator", "About", MessageBoxButtons.OK);
        }
    }
}
