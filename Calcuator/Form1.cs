using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcuator
{
    public partial class CalculatorForm : Form
    {
        private double No;
        private string operation;

      
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void PercentageButton_Click(object sender, EventArgs e)
        {

        }

        private void CEButton_Click(object sender, EventArgs e)
        {
            MainTextBox2.Text = "";

        }

        private void CButton_Click(object sender, EventArgs e)
        {
            MainTextBox2.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            MainTextBox2.Text = "";
        }

        private void OneDivXButton_Click(object sender, EventArgs e)
        {

        }

        private void XSquareButton_Click(object sender, EventArgs e)
        {
           double value = Convert.ToDouble(MainTextBox2.Text) * 2;
            MainTextBox2.Text = Convert.ToString(value);
            
        }

        private void UnderRootButton_Click(object sender, EventArgs e)
        {
           double value =  Math.Sqrt(Convert.ToDouble(MainTextBox2.Text));
            MainTextBox2.Text = Convert.ToString(value);

        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            No = Convert.ToDouble(MainTextBox2.Text);
            MainTextBox2.Text = "0";
            operation = "/";

        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            No = Convert.ToDouble(MainTextBox2.Text);
            MainTextBox2.Text = "0";
            operation = "*";

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            No = Convert.ToDouble(MainTextBox2.Text);
            MainTextBox2.Text = "0";
            operation = "+";



        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            No = Convert.ToDouble(MainTextBox2.Text);
            MainTextBox2.Text = "0";
            operation = "-";


        }

        private void EqualButton_Click(object sender, EventArgs e)
        {

            double no;
            double result;
            no = Convert.ToDouble(MainTextBox2.Text);
            switch (operation)
            {
                case "+" :
                    result = No + no;
                    MainTextBox2.Text = Convert.ToString(result);
                    No = result;
                    break;
                case "-":
                    result = No -no;
                    MainTextBox2.Text = Convert.ToString(result);
                    No = result;
                    break;
                case "*":
                    result = No * no;
                    MainTextBox2.Text = Convert.ToString(result);
                    No = result;
                    break;
                case "/":
                    if (no == 0)
                    {
                        MainTextBox2.Text = "Cannot Divide With 0";
                    }
                    else
                    {
                        result = No / no;
                        MainTextBox2.Text = Convert.ToString(result);
                        No = result;
                    }
                    break;
              




            }


        }

        private void DotButton_Click(object sender, EventArgs e)
        {

        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {

            if (MainTextBox2.Text == "" && MainTextBox2.Text != null)
            {
                MainTextBox2.Text = "0";
            }
            else
            {

                MainTextBox2.Text = MainTextBox2.Text + 0;

            }
        }

        private void DelegateButton_Click(object sender, EventArgs e)
        {

        }

        private void OneButton_Click(object sender, EventArgs e)
        {

            if (MainTextBox2.Text == "" && MainTextBox2.Text != null)
            {
                MainTextBox2.Text = "1";
            }
            else 
            {

                MainTextBox2.Text = MainTextBox2.Text + 1;

            }
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (MainTextBox2.Text == "" && MainTextBox2.Text != null)
            {
                MainTextBox2.Text = "2";
            }
            else
            {

                MainTextBox2.Text = MainTextBox2.Text + 2;

            }
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {

            if (MainTextBox2.Text == "" && MainTextBox2.Text != null)
            {
                MainTextBox2.Text = "3";
            }
            else
            {

                MainTextBox2.Text = MainTextBox2.Text + 3;

            }
        }

        private void FourButton_Click(object sender, EventArgs e)
        {

            if (MainTextBox2.Text == "" && MainTextBox2.Text != null)
            {
                MainTextBox2.Text = "4";
            }
            else
            {

                MainTextBox2.Text = MainTextBox2.Text + 4;

            }
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {

            if (MainTextBox2.Text == "" && MainTextBox2.Text != null)
            {
                MainTextBox2.Text = "5";
            }
            else
            {

                MainTextBox2.Text = MainTextBox2.Text + 5;

            }
        }

        private void SixButton_Click(object sender, EventArgs e)
        {

            if (MainTextBox2.Text == "" && MainTextBox2.Text != null)
            {
                MainTextBox2.Text = "6";
            }
            else
            {

                MainTextBox2.Text = MainTextBox2.Text + 6;

            }

        }

        private void SevenButton_Click(object sender, EventArgs e)
        {

            if (MainTextBox2.Text == "" && MainTextBox2.Text != null)
            {
                MainTextBox2.Text = "7";
            }
            else
            {

                MainTextBox2.Text = MainTextBox2.Text + 7;

            }
        }

        private void EightButton_Click(object sender, EventArgs e)
        {

            if (MainTextBox2.Text == "" && MainTextBox2.Text != null)
            {
                MainTextBox2.Text = "8";
            }
            else
            {

                MainTextBox2.Text = MainTextBox2.Text + 8;

            }
        }

        private void NineButton_Click(object sender, EventArgs e)
        {

            if (MainTextBox2.Text == "" && MainTextBox2.Text != null)
            {
                MainTextBox2.Text = "9";
            }
            else
            {

                MainTextBox2.Text = MainTextBox2.Text + 9;

            }
        }
        
    }
}
