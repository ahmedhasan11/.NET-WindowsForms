using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPressTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            int s;

            switch (e.KeyChar)
            {
                case 'A':
                case 'a':
                    s = int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text);
                    txtResult.Text = s.ToString();
                    e.Handled = true;
                    break;
                case 'S':
                case 's':
                   s = int.Parse(txtNum1.Text) - int.Parse(txtNum2.Text);
                    txtResult.Text = s.ToString();
                    e.Handled = true;
                    break;
                case 'M':
                case 'm':
                  s =  int.Parse(txtNum1.Text) * int.Parse(txtNum2.Text);
                    txtResult.Text = s.ToString();
                    e.Handled = true;
                    break;
                case 'D':
                case 'd':
                   s = int.Parse(txtNum1.Text) / int.Parse(txtNum2.Text);
                    txtResult.Text = s.ToString();
                    e.Handled = true;
                    break;
                case 'C':
                case 'c':
                    Close();
                    break;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" thanks for visiting us");
        }
    }
}
