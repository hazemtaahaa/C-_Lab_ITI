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

        private void btnNums(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                txtRes.AppendText(btn.Text);
            }
        }

        private void btnOper_Click(object sender, EventArgs e)
        {
            try
            {
                var btn = sender as Button;
                Num1 = Convert.ToDouble(txtRes.Text, CultureInfo.InvariantCulture); 
                txtRes.Clear();
                Oprt = Convert.ToChar(btn.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number before selecting an operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEqulas_Click(object sender, EventArgs e)
        {
            try
            {
                Num2 = Convert.ToDouble(txtRes.Text, CultureInfo.InvariantCulture); // ?????? CultureInfo.InvariantCulture
                txtRes.Clear();
                switch (Oprt)
                {
                    case '+':
                        txtRes.Text = (Num1 + Num2).ToString(CultureInfo.InvariantCulture);
                        break;
                    case '-':
                        txtRes.Text = (Num1 - Num2).ToString(CultureInfo.InvariantCulture);
                        break;
                    case '*':
                        txtRes.Text = (Num1 * Num2).ToString(CultureInfo.InvariantCulture);
                        break;
                    case '/':
                        if (Num2 == 0)
                        {
                            MessageBox.Show("Division by zero is not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            txtRes.Text = (Num1 / Num2).ToString(CultureInfo.InvariantCulture);
                        }
                        break;
                    default:
                        MessageBox.Show("Invalid operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number to calculate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRes.Text))
            {
                txtRes.Text = txtRes.Text.Remove(txtRes.Text.Length - 1);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRes.Clear();
        }
    }
}
