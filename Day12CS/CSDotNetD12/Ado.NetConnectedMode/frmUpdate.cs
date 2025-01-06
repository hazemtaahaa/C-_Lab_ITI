using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Ado.NetConnectedMode
{
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
            FillAuthorsToComboBox();
        }
        private void FillAuthorsToComboBox()
        {
            SqlConnection sqlConnection = new SqlConnection("Server=LAPTOP-789NDEKK\\SQLEXPRESS;Database=pubs;Trusted_Connection=true;TrustServerCertificate=true");

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select *,concat(au_fname, ' ' , au_lname) as fullname from authors";

            sqlCommand.Connection = sqlConnection;

            try
            {
                sqlConnection.Open();

                // container 
                SqlDataReader reader = sqlCommand.ExecuteReader();
                // Data Binding
                DataTable dt = new DataTable();
                dt.Load(reader);

                comboBoxAuth.DataSource = dt;
                comboBoxAuth.DisplayMember = "fullname";
                comboBoxAuth.ValueMember = "au_id";

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void comboBoxAuth_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=LAPTOP-789NDEKK\\SQLEXPRESS;Database=pubs;Trusted_Connection=true;TrustServerCertificate=true");

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            var id = comboBoxAuth.SelectedValue;
            sqlCommand.CommandText = $"select * from authors where au_id=@id";
            sqlCommand.Parameters.AddWithValue("@id", id);

            sqlCommand.Connection = sqlConnection;
            try
            {
                sqlConnection.Open();
                // container 
                SqlDataReader reader = sqlCommand.ExecuteReader();
                // Data Binding
                DataTable dt = new DataTable();
                dt.Load(reader);

                txtId.Text = dt.Rows[0]["au_id"].ToString();
                txtFName.Text = dt.Rows[0]["au_fname"].ToString();
                txtLName.Text = dt.Rows[0]["au_lname"].ToString();
                txtAddress.Text = dt.Rows[0]["address"].ToString();
                txtId.Enabled = false;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=LAPTOP-789NDEKK\\SQLEXPRESS;Database=pubs;Trusted_Connection=true;TrustServerCertificate=true");

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;

            sqlCommand.CommandText = $"update authors set au_fname=@fname, au_lname=@lname,address=@addressss where au_id=@id";
            sqlCommand.Parameters.AddWithValue("@id", txtId.Text);
            sqlCommand.Parameters.AddWithValue("@fname", txtFName.Text);
            sqlCommand.Parameters.AddWithValue("@lname", txtLName.Text);
            sqlCommand.Parameters.AddWithValue("@addressss", txtAddress.Text);


            sqlCommand.Connection = sqlConnection;

            try
            {
                sqlConnection.Open();
                lblRes.Text = $"{sqlCommand.ExecuteNonQuery()} rows affected";

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Are you sure to delete {txtFName.Text}","Warning!!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SqlConnection sqlConnection = new SqlConnection("Server=LAPTOP-789NDEKK\\SQLEXPRESS;Database=pubs;Trusted_Connection=true;TrustServerCertificate=true");

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.CommandText = "delete from authors where au_id=@id";
                sqlCommand.Parameters.AddWithValue("@id", txtId.Text);



                sqlCommand.Connection = sqlConnection;

                try
                {
                    sqlConnection.Open();
                    lblRes.Text = $"{sqlCommand.ExecuteNonQuery()} rows affected";

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    sqlConnection.Close();
                    FillAuthorsToComboBox();
                }
            }
        }
    }
}
