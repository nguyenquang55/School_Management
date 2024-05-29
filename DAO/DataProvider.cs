using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace test_app.DAO
{
    public  class DataProvider
    {
        private string connectionString = @"Data Source=DESKTOP-2LMB9L0\SQLEXPRESS;Initial Catalog=Student_management;Integrated Security=True;Trust Server Certificate=True;";

        private static DataProvider instance;

        public static DataProvider Instance1
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; }
        }

        public DataTable ExecuteQuery(string query )
        {
            DataTable data = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(data);
                        }
                    }
                    connection.Close();
                }

            }
            catch (SqlException ex)
            {
                
                //MessageBox.Show($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Error: {ex.Message}");
            }

            return data;
        }

        public int ExecuteNonQuery(string query)
        {
            int data = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        connection.Open();
                        data = cmd.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions
                MessageBox.Show($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle other potential exceptions
                MessageBox.Show($"Error: {ex.Message}");
            }

            return data;
        }


        public object ExecuteScalar(string query)
        {
            object data = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        data = cmd.ExecuteScalar();
                    }
                    connection.Close();
                }

            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions
                MessageBox.Show($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle other potential exceptions
                MessageBox.Show($"Error: {ex.Message}");
            }

            return data;
        }
    }
}
