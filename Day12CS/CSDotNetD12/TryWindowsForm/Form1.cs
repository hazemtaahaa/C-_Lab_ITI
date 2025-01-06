namespace TryWindowsForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.BackColor = Color.Red;
            btnRegister.BackColor = Color.OrangeRed;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome");
        }
    }
}
