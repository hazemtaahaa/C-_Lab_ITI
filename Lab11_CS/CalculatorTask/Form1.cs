using System.Data;
using System.Globalization; 

namespace CalculatorTask
{
    public partial class FrmCalc : Form
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public char Oprt { get; set; }

        public FrmCalc()
        {
            InitializeComponent();
        }
        string str = string.Empty;
        private void btnNums(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            str += btn.Text;

            if (btn != null)
            {
                txtRes.AppendText(btn.Text);
            }
        }

        

        private void btnEqulas_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(str, null);
                txtRes.Text = result.ToString();
                str = string.Empty;
            }
            catch (Exception ex)
            {
                txtRes.Text = "Error";
                str = string.Empty;
            }
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRes.Text))
            {
                txtRes.Text = txtRes.Text.Substring(0, txtRes.Text.Length - 1);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRes.Clear();
        }
    }
}
