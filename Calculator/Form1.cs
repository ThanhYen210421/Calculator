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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region GlobalVariable
        int num1, num2;
        double result;
        #endregion

        private void btAddition_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNum1.Text!=""||txtNum2.Text!="")
                {
                    num1 = Int32.Parse(txtNum1.Text);
                    num2 = Int32.Parse(txtNum2.Text);
                }
                else
                {
                    MessageBox.Show("Phải nhập vào giá trị số!");
                }    

                result = (double)num1 + num2;
                txtResult.Text = result.ToString();
            }
            catch (Exception ex1)
            {

                MessageBox.Show(ex1.Message);
            }
        }
    }
}
