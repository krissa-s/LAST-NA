using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEnroll
{
    public class MySQLConnector
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=student_information_and_enrollment_system;";
        private void ExecuteNonQuery(string query, params (string, object)[] parameters)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Item1, param.Item2);
                        }
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private DataTable ExecuteQuery(string query)
        {
            DataTable table = new DataTable();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return table;
        }





        /*STUDENT*/
        /*INSERT*/
        public void InsertStudent(int stud_id, string first_name, string middle_initial, string last_name, string email_add, string student_type)
        {
            string checkQuery = "SELECT COUNT(*) FROM STUDENT WHERE stud_id = @stud_id";
            string insertQuery = "INSERT INTO STUDENT (stud_id, first_name, middle_initial, last_name, email_add, student_type) " +
                                 "VALUES (@stud_id, @first_name, @middle_initial, @last_name, @email_add, @student_type)";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if student already exists
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@stud_id", stud_id);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Error: STUDENT ID already exists!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }


                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@stud_id", stud_id);
                        insertCmd.Parameters.AddWithValue("@first_name", first_name);
                        insertCmd.Parameters.AddWithValue("@middle_initial", middle_initial);
                        insertCmd.Parameters.AddWithValue("@last_name", last_name);
                        insertCmd.Parameters.AddWithValue("@email_add", email_add);
                        insertCmd.Parameters.AddWithValue("@student_type", student_type);
                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        /*UPDATE*/
        public void UpdateStudent(int stud_id, string first_name, string middle_initial, string last_name, string email_add, string student_type)
        {
            string query = "UPDATE STUDENT SET first_name = @first_name, middle_initial = @middle_initial, last_name = @last_name, email_add = @email_add, student_type = @student_type WHERE stud_id = @stud_id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@stud_id", stud_id);
                        command.Parameters.AddWithValue("@first_name", first_name);
                        command.Parameters.AddWithValue("@middle_initial", middle_initial);
                        command.Parameters.AddWithValue("@last_name", last_name);
                        command.Parameters.AddWithValue("@email_add", email_add);
                        command.Parameters.AddWithValue("@student_type", student_type);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No Student found with the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*DELETE*/
        public void DeleteStudent(int stud_id)
        {
            string query = "DELETE FROM STUDENT WHERE stud_id = @stud_id";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@stud_id", stud_id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*SEARCH*/
        public DataTable SearchStudent(string keyword)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM STUDENT WHERE first_name LIKE @keyword OR middle_name LIKE @keyword OR last_name LIKE @keyword OR email_add LIKE @keyword OR student_type LIKE @keyword";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        /*FETCH*/
        public DataTable FetchStudent()
        {
            string query = "SELECT * FROM STUDENT";
            return ExecuteQuery(query);
        }
    }
}


