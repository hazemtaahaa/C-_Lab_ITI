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
    public partial class frmSelectV2 : Form
    {
        public frmSelectV2()
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
            sqlCommand.CommandText = $"select t.* from titles t, authors a, titleauthor ta where a.au_id = ta.au_id and ta.title_id = t.title_id and a.au_id = '{id}'";

            sqlCommand.Connection = sqlConnection;
            try
            {
                sqlConnection.Open();
                // container 
                SqlDataReader reader = sqlCommand.ExecuteReader();
                // Data Binding
                DataTable dt = new DataTable();
                dt.Load(reader);
                gridAuthors.DataSource = dt;
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
