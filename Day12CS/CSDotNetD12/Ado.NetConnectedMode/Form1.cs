
using System.Data;
using Microsoft.Data.SqlClient;

namespace Ado.NetConnectedMode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // get all authors from data base
            FillAuthorsToGridView();
        }
        private void FillAuthorsToGridView()
        {
            // 1,2,3 [Connection String] [Connection Obj]
            SqlConnection sqlConnection = new SqlConnection("Server=LAPTOP-789NDEKK\\SQLEXPRESS;Database=pubs;Trusted_Connection=true;TrustServerCertificate=true");

            // 4- Command
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;  // by def Text
            sqlCommand.CommandText = "select * from authors";

            // Link Command to Connection
            sqlCommand.Connection = sqlConnection;

            //sqlConnection.Open();
            //// Exeption
            //sqlConnection.Close();
            try
            {
                sqlConnection.Open();
                // exec res set via data reader
                //SqlDataReader dr = new SqlDataReader();
                SqlDataReader dr = sqlCommand.ExecuteReader();

                // data Binding
                DataTable dt = new DataTable();
                dt.Load(dr);

                // Data Table has no GUI
                gridAuthors.DataSource = dt;
            }
            catch(Exception)
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
