using ITI.BussinesLAyer;

namespace PresentationLayer
{
    public partial class PLForm : Form
    {


        public PLForm()
        {
            InitializeComponent();
            FillStudentsToGrid();
            fillNames();
        }

        private void FillStudentsToGrid()
        {
            grdViwe.DataSource = ITI.BussinesLAyer.StudentManager.GetAll();

        }



        private void fillNames()
        {
            cmbboxNames.DataSource = ITI.BussinesLAyer.StudentManager.GetAll();

            cmbboxNames.DisplayMember = "st_fname";
            cmbboxNames.ValueMember = "st_id";

        }

        private void btnIInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFName.Text)
                || string.IsNullOrWhiteSpace(txtLName.Text)
                || string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please complete the data ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            Student student = new Student()
            {
                St_Fname = txtFName.Text,
                St_Lname = txtLName.Text,
                St_Address = txtAddress.Text,
                St_Age = Convert.ToInt32(txtNumDown.Value)
            };

            int result = StudentManager.Add(student);
            resLable.Text = $"{result} Rows Inserted";

            FillStudentsToGrid();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtFName.Text)
               || string.IsNullOrWhiteSpace(txtLName.Text)
               || string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please use Get By Name first to Update ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = Convert.ToInt32(cmbboxNames.SelectedValue);
            Student student = StudentManager.GetById(id);


            student.St_Fname = txtFName.Text;
            student.St_Lname = txtLName.Text;
            student.St_Address = txtAddress.Text;
            student.St_Age = Convert.ToInt32(txtNumDown.Value);
            int rowAffected = ITI.BussinesLAyer.StudentManager.Update(student);
            resLable.Text = rowAffected.ToString();
            if (rowAffected > 0)
            {
                MessageBox.Show("Updated Successfully>>");
                grdViwe.DataSource = ITI.BussinesLAyer.StudentManager.GetAll();

                resLable.Text = null;

               txtFName.Clear();
                txtLName.Clear();
                txtAddress.Clear();

            }
        }

        private void btnGetByName_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbboxNames.SelectedValue);
            Student s = StudentManager.GetById(id);
            //MessageBox.Show(s.St_Fname);
            List<Student> ss = new();

            ss.Add(s);

            grdViwe.DataSource = ss;

            txtFName.Text = s.St_Fname;
            txtLName.Text = s.St_Lname;
            txtAddress.Text = s.St_Address;
            txtNumDown.Value = (decimal)s.St_Age;


        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            grdViwe.DataSource = ITI.BussinesLAyer.StudentManager.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbboxNames.SelectedValue);
            if (grdViwe.RowCount>1)
            {
                MessageBox.Show("Please use Get By Name first to Delete ","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int rowAffected = ITI.BussinesLAyer.StudentManager.Delete(id);
            resLable.Text = $"  {rowAffected} row deleted ";
            if (rowAffected > 0)
            {
                MessageBox.Show("Deleted Successfully>>");
                grdViwe.DataSource = ITI.BussinesLAyer.StudentManager.GetAll();
                fillNames();
                resLable.Text = null;

                txtFName.Clear();
                txtLName.Clear();
                txtAddress.Clear();
                
            }

        }
    }
}
