
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Drawing;

namespace Ado_Disconnected_Mode
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
        SqlCommand sqlCommand;
        SqlDataAdapter adapter;
        DataTable dataTable;
        SqlConnection sqlConnection;

        public Form1()
        {
            InitializeComponent();

            sqlConnection = new(connectionString); ;
            sqlCommand = new SqlCommand();
            dataTable = new DataTable();
            adapter = new SqlDataAdapter();
            fillNames();
            fillDepartmentData();
            fillStudentData();
        }
        private void InitializeDataTable()
        {
            dataTable.Columns.Add("St_Id", typeof(int));
            dataTable.Columns.Add("St_Fname", typeof(string));
            dataTable.Columns.Add("St_Lname", typeof(string));
            dataTable.Columns.Add("St_Address", typeof(string));
            dataTable.Columns.Add("St_Age", typeof(int));
            dataTable.Columns.Add("Dept_Id", typeof(int));

            // Set the primary key for the DataTable
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["St_Id"] };
        }

        private void fillStudentData()
        {

            dataTable.Clear();

            sqlCommand.CommandText = "SELECT * FROM Student";
            sqlCommand.Connection = sqlConnection;
            adapter.SelectCommand = sqlCommand;

            try
            {
                adapter.Fill(dataTable);
                grdViwe.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillNames()
        {



        }

        private void fillDepartmentData()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);


            string query = "SELECT Dept_Id, Dept_Name FROM Department";

            try
            {

                SqlDataAdapter sqlDataAdapter = new(query, sqlConnection);

                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
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


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdViwe.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = grdViwe.SelectedRows[0];

                // Get the St_Id of the selected row
                int stId = Convert.ToInt32(selectedRow.Cells["St_Id"].Value);

                // Find the corresponding row in the DataTable
                DataRow rowToDelete = dataTable.Rows.Find(stId);

                if (rowToDelete != null)
                {
                    // Delete the row from the DataTable
                    rowToDelete.Delete();

                    // Refresh the GridView to reflect the changes
                    grdViwe.DataSource = null;
                    grdViwe.DataSource = dataTable;

                    MessageBox.Show("Row deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGetAll_Click(object sender, EventArgs e)
        {
            fillStudentData();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new(connectionString);

            #region Insert
            string insQuery = "INSERT INTO Student (St_Fname, St_Lname, St_Age, Dept_Id, St_Address) VALUES (@FName, @LName, @Age, @DeptId, @Address)";

            SqlCommand insCommand = new SqlCommand();
            insCommand.CommandText = insQuery;

            insCommand.Parameters.AddWithValue("@FName", txtFName.Text);
            insCommand.Parameters.AddWithValue("@LName", txtLName.Text);
            insCommand.Parameters.AddWithValue("@Age", Convert.ToInt32(txtNumDown.Value));
            insCommand.Parameters.AddWithValue("@DeptId", Convert.ToInt32(dptCmBox.SelectedValue));
            insCommand.Parameters.AddWithValue("@Address", txtAddress.Text);
            insCommand.Connection = sqlConnection;
            #endregion

            #region Update
            SqlCommand updatCommand = new SqlCommand();
            string updateQuery = "UPDATE Student SET St_Fname = @FName, St_Lname = @LName, St_Age = @Age, Dept_Id = @DeptId, St_Address = @Address WHERE St_Id = @St_Id";

            updatCommand.CommandText = updateQuery;
            updatCommand.Parameters.AddWithValue("@St_Id", St_Id);
            updatCommand.Parameters.AddWithValue("@FName", FName);
            updatCommand.Parameters.AddWithValue("@LName", LName);
            updatCommand.Parameters.AddWithValue("@Age", Age);
            updatCommand.Parameters.AddWithValue("@DeptId", DeptId);
            updatCommand.Parameters.AddWithValue("@Address", Address);
            updatCommand.Connection = sqlConnection;
            #endregion

            #region Delete
            SqlCommand deletCommand = new SqlCommand();
            string deletQuery = "DELETE FROM Student WHERE St_Id = @St_Id";
            deletCommand.CommandText = deletQuery;
            deletCommand.Parameters.AddWithValue("@St_Id", St_Id);
            deletCommand.Connection = sqlConnection;
            #endregion

            // Assign commands to the adapter
            adapter.InsertCommand = insCommand;
            adapter.DeleteCommand = deletCommand;
            adapter.UpdateCommand = updatCommand;

            try
            {
                // Synchronize changes with the database
                adapter.Update(dataTable);

                MessageBox.Show("Sync Successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Refresh the GridView
            fillStudentData();
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


            DataRow dr = dataTable.NewRow();
            dr["St_Fname"] = txtFName.Text;
            dr["St_Lname"] = txtLName.Text;
            dr["St_Address"] = txtAddress.Text;
            dr["St_Age"] = Convert.ToInt32(txtNumDown.Value);
            dr["Dept_Id"] = Convert.ToInt32(dptCmBox.SelectedValue);


            dataTable.Rows.Add(dr);
            // MessageBox.Show($"Rows in DataTable: {dataTable.Rows.Count}", "Debug");
            grdViwe.DataSource = null;
            grdViwe.DataSource = dataTable;


            txtFName.Clear();
            txtLName.Clear();
            txtAddress.Clear();
            txtNumDown.Value = 0;
            dptCmBox.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grdViwe.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = grdViwe.SelectedRows[0];

                // Get the St_Id of the selected row
                int stId = Convert.ToInt32(selectedRow.Cells["St_Id"].Value);

                // Find the corresponding row in the DataTable
                DataRow rowToUpdate = dataTable.Rows.Find(stId);

                if (rowToUpdate != null)
                {
                    // Update the row with new values from the input fields
                    rowToUpdate["St_Fname"] = txtFName.Text;
                    rowToUpdate["St_Lname"] = txtLName.Text;
                    rowToUpdate["St_Address"] = txtAddress.Text;
                    rowToUpdate["St_Age"] = Convert.ToInt32(txtNumDown.Value);
                    rowToUpdate["Dept_Id"] = Convert.ToInt32(dptCmBox.SelectedValue);

                    // Refresh the GridView to reflect the changes
                    grdViwe.DataSource = null;
                    grdViwe.DataSource = dataTable;

                    MessageBox.Show("Row updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void cmbboxNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
