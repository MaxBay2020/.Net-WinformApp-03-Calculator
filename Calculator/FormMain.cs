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
    public partial class frm_main : Form
    {
        bool flag = false;
        double num1 = 0;
        double num2 = 0;
        bool hasnum1 = false;
        string sign = null;
        public frm_main()
        {
            InitializeComponent();
        }

        private void one_btn_Click(object sender, EventArgs e)
        {

            if (flag)
            {
                result_txt.Text = "";
                result_txt.Text += "1";
                flag = false;
            }
            else
            {
                if (result_txt.Text == "0")
                {
                    result_txt.Text = "";
                }
                result_txt.Text += "1";
            }

            


        }

        private void two_btn_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                result_txt.Text = "";
                result_txt.Text += "2";
                flag = false;
            }
            else
            {
                if (result_txt.Text == "0")
                {
                    result_txt.Text = "";
                }
                result_txt.Text += "2";
            }
            
        }

        private void c_btn_Click(object sender, EventArgs e)
        {
            result_txt.Text = "0";
        }

        private void three_btn_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                result_txt.Text = "";
                result_txt.Text += "3";
                flag = false;
            }
            else
            {
                if (result_txt.Text == "0")
                {
                    result_txt.Text = "";
                }
                result_txt.Text += "3";
            }
           
        }

        private void four_btn_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                result_txt.Text = "";
                result_txt.Text += "4";
                flag = false;
            }
            else
            {
                if (result_txt.Text == "0")
                {
                    result_txt.Text = "";
                }
                result_txt.Text += "4";
            }
        
        }

        private void five_btn_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                result_txt.Text = "";
                result_txt.Text += "5";
                flag = false;
            }
            else
            {
                if (result_txt.Text == "0")
                {
                    result_txt.Text = "";
                }
                result_txt.Text += "5";
            }
           
        }

        private void six_btn_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                result_txt.Text = "";
                result_txt.Text += "6";
                flag = false;
            }
            else
            {
                if (result_txt.Text == "0")
                {
                    result_txt.Text = "";
                }
                result_txt.Text += "6";
            }
            
        }

        private void sevent_btn_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                result_txt.Text = "";
                result_txt.Text += "7";
                flag = false;
            }
            else
            {
                if (result_txt.Text == "0")
                {
                    result_txt.Text = "";
                }
                result_txt.Text += "7";
            }
            
        }

        private void eightn_btn_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                result_txt.Text = "";
                result_txt.Text += "8";
                flag = false;
            }
            else
            {
                if (result_txt.Text == "0")
                {
                    result_txt.Text = "";
                }
                result_txt.Text += "8";
            }
           
        }

        private void nine_btn_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                result_txt.Text = "";
                result_txt.Text += "9";
                flag = false;
            }
            else
            {
                if (result_txt.Text == "0")
                {
                    result_txt.Text = "";
                }
                result_txt.Text += "9";
            }
           
        }

        private void sng_btn_Click(object sender, EventArgs e)
        {
            double res = double.Parse(result_txt.Text);
            if (res == 0)
            {
                result_txt.Text = "0";
            }
            else if (res > 0)
            {

                result_txt.Text = res * (-1) + "";
            }
            else
            {
                result_txt.Text = res * (-1) + "";

            }

        }

        private void point_btn_Click(object sender, EventArgs e)
        {
            string res = result_txt.Text;
            flag = true;
            if (result_txt.Text.IndexOf('.') == -1)
            {
                result_txt.Text += ".";

            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        private void root_btn_Click(object sender, EventArgs e)
        {
            double res = Convert.ToDouble(result_txt.Text);
            flag = true;
            if (res < 0)
            {
                MessageBox.Show("Invalid");
                return;
            }
            else
            {
                result_txt.Text = Math.Sqrt(res) + "";
            }
        }

        private void square_btn_Click(object sender, EventArgs e)
        {
            double res = Convert.ToDouble(result_txt.Text);
            flag = true;
            res *= res;
            result_txt.Text = res + "";
        }

        private void inverse_btn_Click(object sender, EventArgs e)
        {
            double res = Convert.ToDouble(result_txt.Text);
            flag = true;
            if (res == 0)
            {
                MessageBox.Show("Invalid");
                return;
            }
            else
            {
                result_txt.Text = 1 / res + "";

            }
        }

        private void zero_btn_Click(object sender, EventArgs e)
        {
            if (result_txt.Text == "0")
            {
                return;
            }
            if (flag)
            {
                result_txt.Text = "";
                result_txt.Text += "0";
                flag = false;
            }
            else
            {
                if (result_txt.Text == "0")
                {
                    result_txt.Text = "";
                }
                result_txt.Text += "0";
            }
            
        }

        private void back_btn_Click(object sender, EventArgs e)
        {


            if (result_txt.Text.Length <= 1)
            {
                result_txt.Text = "0";
            }
            else
            {
                result_txt.Text = result_txt.Text.Substring(0, result_txt.Text.Length - 1);

            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (hasnum1 == false)
            {
                num1 = Convert.ToDouble(result_txt.Text);
                result_txt.Text = num1 + "";
                hasnum1 = true;
            }
            else
            {
                num2 = Convert.ToDouble(result_txt.Text);
                result_txt.Text = num1 + num2 + "";
                num1 = Convert.ToDouble(result_txt.Text);
            }
            sign = "+";
            flag = true;


        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            if (hasnum1 == false)
            {
                num1 = Convert.ToDouble(result_txt.Text);
                result_txt.Text = num1 + "";
                hasnum1 = true;
            }
            else
            {
                num2 = Convert.ToDouble(result_txt.Text);
                result_txt.Text = num1 - num2 + "";
                num1 = Convert.ToDouble(result_txt.Text);
            }
            sign = "-";
            flag = true;
        }

        private void multiply_btn_Click(object sender, EventArgs e)
        {
            if (hasnum1 == false)
            {
                num1 = Convert.ToDouble(result_txt.Text);
                result_txt.Text = num1 + "";
                hasnum1 = true;
            }
            else
            {
                num2 = Convert.ToDouble(result_txt.Text);
                result_txt.Text = num1 * num2 + "";
                num1 = Convert.ToDouble(result_txt.Text);
            }
            sign = "*";
            flag = true;
        }

        private void divide_btn_Click(object sender, EventArgs e)
        {
            if (hasnum1 == false)
            {
                num1 = Convert.ToDouble(result_txt.Text);
                result_txt.Text = num1 + "";
                hasnum1 = true;
            }
            else
            {
                num2 = Convert.ToDouble(result_txt.Text);
                result_txt.Text = num1 / num2 + "";
                num1 = Convert.ToDouble(result_txt.Text);
                
            }
            sign = "/";
            flag = true;
        }

        private void equal_btn_Click(object sender, EventArgs e)
        {
            if (hasnum1 == false)
            {
                num1 = Convert.ToDouble(result_txt.Text);
                result_txt.Text = num1 + "";
                hasnum1 = true;
            }
            else
            {
                num2 = Convert.ToDouble(result_txt.Text);
                switch (sign)
                {
                    case "+":
                        result_txt.Text = num1 + num2 + "";
                        sign = null;
                        break;
                    case "-":
                        result_txt.Text = num1 - num2 + "";
                        sign = null;
                        break;
                    case "*":
                        result_txt.Text = num1 * num2 + "";
                        sign = null;
                        break;
                    case "/":
                        result_txt.Text = num1 / num2 + "";
                        sign = null;
                        break;
                    default:
                        return;
                }
                
                hasnum1 = false;
            }

            flag = true;
        }
    }
}
