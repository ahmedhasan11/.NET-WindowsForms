using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web;

namespace FileStreamProject
{

    public partial class Form1 : Form
    {
        FileStream rs = new FileStream("num1.txt", FileMode.Open, FileAccess.Read);

        FileStream fs = new FileStream("num2.txt", FileMode.Open, FileAccess.Read);

        FileStream ss = new FileStream("operator.txt", FileMode.Open, FileAccess.Read);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRead1_Click(object sender, EventArgs e)
        {
            StreamReader num1 = new StreamReader(rs);
             int s = int.Parse(num1.ReadLine());
            txtNum1.Text = s.ToString();
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRead2_Click(object sender, EventArgs e)
        {
            StreamReader num2 = new StreamReader(fs);
            int m = int.Parse(num2.ReadLine());
            txtNum2.Text = m.ToString();
        }

        private void txtOperation_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReadOP_Click(object sender, EventArgs e)
        {
            StreamReader OP = new StreamReader(ss);
            string n =OP.ReadLine();
            txtOperation.Text = n.ToString();
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int x;
             switch (txtOperation.Text) {
                case "+" :
                    x = int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text);
                    txtResult.Text = x.ToString();
                    break;
                case "-" :
                    x = int.Parse(txtNum1.Text) - int.Parse(txtNum2.Text);
                    txtResult.Text = x.ToString();
                    break;
                case "*":
                    x = int.Parse(txtNum1.Text) * int.Parse(txtNum2.Text);
                    txtResult.Text = x.ToString();
                    break;
                    case "/":
                    x = int.Parse(txtNum1.Text) / int.Parse(txtNum2.Text);
                    txtResult.Text = x.ToString();
                    break;
                case "%":
                    x = int.Parse(txtNum1.Text) % int.Parse(txtNum2.Text);
                    txtResult.Text = x.ToString();
                    break;
            } 
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GoodBye User");
        }
    }
}
