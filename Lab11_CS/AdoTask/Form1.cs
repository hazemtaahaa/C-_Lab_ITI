
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace AdoTask
{
    public partial class Form1 : Form
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int DeptId { get; set; }
        public int St_Id { get; set; }

        string connectionString = "Server=.;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
            fillDepartmentData();
            fillNames();
        }



        private void fillNames()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string query = "select * from student";


            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cmbboxNames.DataSource = dt;

                cmbboxNames.DisplayMember = "St_Fname";

                cmbboxNames.ValueMember = "St_Id";


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                sqlConnection.Close();
            };

        }

        private void fillStudentData()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string query = "select * from student";

            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                grdViwe.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                sqlConnection.Close();
            };


        }

        private void fillDepartmentData()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //string query = "select * from Department";
            string query = "SELECT Dept_Id, Dept_Name FROM Department";

            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dptCmBox.DataSource = dt;
                dptCmBox.DisplayMember = "Dept_Name";
                dptCmBox.ValueMember = "Dept_Id";
                //dptCmBox.SelectedValue = "";

                //grdViwe.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                sqlConnection.Close();
            };


        }





        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            if (string.IsNullOrWhiteSpace(txtFName.Text)
                || string.IsNullOrWhiteSpace(txtLName.Text)
                || string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please complete the data ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FName = txtFName.Text;
            LName = txtLName.Text;
            Age = Convert.ToInt32(txtNumDown.Value);
            DeptId = Convert.ToInt32(dptCmBox.SelectedValue);
            Address = txtAddress.Text;




            string query = "INSERT INTO Student (St_Fname, St_Lname, St_Age, Dept_Id, St_Address) VALUES (@FName, @LName, @Age, @DeptId, @Address)";


            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@FName", FName);
                command.Parameters.AddWithValue("@LName", LName);
                command.Parameters.AddWithValue("@Age", Age);
                command.Parameters.AddWithValue("@DeptId", DeptId);
                command.Parameters.AddWithValue("@Address", Address);
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillStudentData();
                }
                else
                {
                    MessageBox.Show("Failed to add student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //grdViwe.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                sqlConnection.Close();
            };
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            fillStudentData();

        }

        private void btnGetByName_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            St_Id = Convert.ToInt32(cmbboxNames.SelectedValue);


            string query = $"select * from student where St_Id = @St_Id";
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@St_Id", St_Id);
                SqlDataReader reader = command.ExecuteReader();



                DataTable dt = new DataTable();
                dt.Load(reader);
                grdViwe.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No student found with the selected ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataRow row = dt.Rows[0];

                FName = row["St_Fname"].ToString();
                LName = row["St_Lname"].ToString();
                Address = row["St_Address"].ToString();
                Age = Convert.ToInt32(row["St_Age"]);
                DeptId = Convert.ToInt32(row["Dept_Id"]);

                txtFName.Text = FName;
                txtLName.Text = LName;
                txtAddress.Text = Address;
                txtNumDown.Value = Age;
                dptCmBox.SelectedValue = DeptId;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { sqlConnection.Close(); }



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            if (string.IsNullOrWhiteSpace(txtFName.Text)
                || string.IsNullOrWhiteSpace(txtLName.Text)
                || string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please use Get By Name first to Update ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FName = txtFName.Text;
            LName = txtLName.Text;
            Age = Convert.ToInt32(txtNumDown.Value);
            DeptId = Convert.ToInt32(dptCmBox.SelectedValue);
            Address = txtAddress.Text;




            string query = "UPDATE Student SET St_Fname = @FName, St_Lname = @LName, St_Age = @Age, Dept_Id = @DeptId, St_Address = @Address WHERE St_Id = @St_Id";

            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);

                // Add parameters
                command.Parameters.Add("@St_Id", SqlDbType.Int).Value = St_Id;
                command.Parameters.Add("@FName", SqlDbType.NVarChar).Value = FName;
                command.Parameters.Add("@LName", SqlDbType.NVarChar).Value = LName;
                command.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
                command.Parameters.Add("@DeptId", SqlDbType.Int).Value = DeptId;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address;

                int rowAffected = command.ExecuteNonQuery();

                if (rowAffected > 0)
                {
                    resLable.Text = $"{rowAffected} row(s) affected";
                    MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillStudentData();
                    fillNames();
                    resLable.Text = "";
                }
                else
                {
                    MessageBox.Show("No student found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            if(St_Id==0)
            {
                MessageBox.Show("Pleas select a student to delete.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResualt = MessageBox.Show("Ar you sure you want to delete this student?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(confirmResualt==DialogResult.No)
            {
                return;
            }

            string query = "DELETE FROM Student WHERE St_Id = @St_Id";
            try
            {
                connection.Open();
                SqlCommand command =new SqlCommand(query,connection);
                command.Parameters.Add("@St_Id", SqlDbType.Int).Value = St_Id;


                int rowAffected =command.ExecuteNonQuery();
                if(rowAffected>0)
                {
                    MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillStudentData();
                }
                else
                {
                    MessageBox.Show("No student found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                connection.Close();
            }



          

        }
    }
}
