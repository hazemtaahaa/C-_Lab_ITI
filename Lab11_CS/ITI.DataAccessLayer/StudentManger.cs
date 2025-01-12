using Microsoft.Data.SqlClient;
using System.Data;

namespace ITI.DataAccessLayer
{
    public class StudentManger
    {
        // disConnected mode
        public static DataTable ExecuteQuery(string query)
        {
           
            string connectionString = "Server=.;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True;";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, sqlConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            return dt;


        }

        // connected mode
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
           
            string connectionString = "Server=.;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddRange(parameters);

            int affected = -1;
            try
            {
                sqlConnection.Open();
                affected = sqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }

            return affected;

        }

    }
}
