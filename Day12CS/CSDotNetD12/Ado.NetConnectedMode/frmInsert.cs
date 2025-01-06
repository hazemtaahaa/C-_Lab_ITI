using System.Data;
using Microsoft.Data.SqlClient;

namespace Ado.NetConnectedMode
{
    public partial class frmInsert : Form
    {
        public frmInsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=LAPTOP-789NDEKK\\SQLEXPRESS;Database=pubs;Trusted_Connection=true;TrustServerCertificate=true");

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            //sqlCommand.CommandText = $"insert into authors (au_id, au_fname, au_lname,address) values ('{txtId.Text}','{txtFName.Text}','{txtLName.Text}', '{txtAddress.Text}')";
            sqlCommand.CommandText = "insert into authors (au_id, au_fname, au_lname,address) values (@id, @fname, @lname, @address)";
            sqlCommand.Parameters.AddWithValue("@id", txtId.Text);
            sqlCommand.Parameters.AddWithValue("@fname", txtFName.Text);
            sqlCommand.Parameters.AddWithValue("@lname", txtLName.Text);
            sqlCommand.Parameters.AddWithValue("@address", txtAddress.Text);

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
    }
}
