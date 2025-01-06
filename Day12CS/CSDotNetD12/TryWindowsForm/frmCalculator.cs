using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryWindowsForm
{
    public partial class frmCalculator : Form
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public string Oper { get; set; }
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnNumOne_Click(object sender, EventArgs e)
        {
            //txtRes.Text += "1";
            txtRes.AppendText("1");
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txtRes.AppendText("2");
        }

        private void btnOperPlus_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt32(txtRes.Text);
            //Num1 = int.Parse(txtRes.Text);
            txtRes.Clear();
            Oper = "+";
        }

        private void btnOperMin_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt32(txtRes.Text);
            //Num1 = int.Parse(txtRes.Text);
            txtRes.Clear();
            Oper = "-";
        }

        private void btnEqulas_Click(object sender, EventArgs e)
        {
            Num2 = Convert.ToInt32(txtRes.Text);
            txtRes.Clear();
            switch (Oper)
            {
                case "+":
                    txtRes.Text = (Num1 + Num2).ToString();
                    break;
                case "-":
                    txtRes.Text = (Num1 - Num2).ToString();
                    break;
            }
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                txtRes.Text = btn.Text;
            }
        }

        private void btnOper_Click(object sender, EventArgs e)
        {
            var btn = (sender as Button);
            Num1 = Convert.ToInt32(txtRes.Text);
            txtRes.Clear();
            Oper = btn.Text;
        }
    }
}
