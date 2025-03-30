using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Foodie_Point_Management_System.Employee_Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Foodie_Point_Management_System.Admin
{
    public class emAdmin : Employee
    {

        static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public emAdmin(int ei, string eu, string ef, string er) : base(ei, eu, ef, er) { }

        public DataTable LoadDatatable(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                connect.Open();

                SqlDataAdapter da = new SqlDataAdapter(query, connect);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error");
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }

        public List<string> ShowFeedbackContent(string FId)
        {
            List<string> returner = new List<string>();

            returner.Add("T");

            try
            {
                connect.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT Content FROM Feedback WHERE FeedbackID = @fid", connect))
                {
                    cmd.Parameters.AddWithValue("@fid", FId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            returner.Add((reader["Content"].ToString()));
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("UPDATE Feedback SET ReadStatus = @RS WHERE FeedbackID = @fid ", connect))
                {
                    cmd.Parameters.AddWithValue("@RS", "Read");
                    cmd.Parameters.AddWithValue("@fid", FId);

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                returner.Add("Error" + ex.Message);
                returner[0] = "F";
            }
            finally
            {
                connect.Close();
            }
            return returner;
        }


        //check the user exists or not
        public bool UserExists(string username, string email, string table)
        {
            try
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM {table} WHERE Username = @username", connect))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        return true;
                    }
                }

                using (SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM {table} WHERE Email = @email", connect))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connect.Close();
            }
            return false;
        }


        //Add new user
        public string AddUser(string table, string username, string fullname, string email, string password, string role = null)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(username) || !email.Contains("@"))
                    return "Invalid username or email format!";
                else if (UserExists(username, email, table))
                    return "User exists!";
                else
                {
                    connect.Open();

                    string query = $"INSERT INTO {table} (Username, Fullname, Email, Password, RegistrationDate" + (table == "Employee" ? ", Role)" : ")") +
                                       " VALUES (@Username, @Fullname, @Email, @Password, @RegistrationDate" + (table == "Employee" ? ", @Role)" : ")");
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Fullname", fullname);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);
                        if (table == "Employee") cmd.Parameters.AddWithValue("@Role", role);

                        cmd.ExecuteNonQuery();

                        return "User had been added!";
                    }
                }
            }
            catch (Exception ex)
            {
                return ($"Error: {ex.Message}");
            }
            finally
            {
                connect.Close();
            }
        }

        //Update new user
        public string UpdateUser(string table, string id, string username, string fullname, string email, string password, string role = null)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(username) || !email.Contains("@"))
                    return "Invalid username or email format!";
                else
                {
                    connect.Open();

                    using (SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM {table} WHERE {(table == "Customer" ? "CustomerID != @id" : "EmployeeID != @id")} AND (Username = @username OR Email = @email)", connect))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@id", id);
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            return "User with email or username already exist!";
                        }
                    }

                    string query = $"UPDATE {table} SET Fullname = @Fullname, Email = @Email, Password = @Password" +
                                       (table == "Employee" ? ", Role = @Role" : "") + " WHERE " + (table == "Customer" ? "CustomerID = @id" : "EmployeeID = @id");
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Fullname", fullname);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@id", id);
                        if (table == "Employee")
                            cmd.Parameters.AddWithValue("@Role", role);

                        cmd.ExecuteNonQuery();
                        return $"User updated successfully!";
                    }
                }
            }
            catch (Exception ex)
            {
                return ($"Error: {ex.Message}");
            }
            finally
            {
                connect.Close();

            }
        }

        // Delete user
        public string DeleteUser(string table, string id)
        {
            try
            {
                connect.Open();

                string query = $"DELETE FROM {table} WHERE " + (table == "Customer" ? "CustomerID = @id" : "EmployeeID = @id");

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@table", table);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    return "User Deletion Succesful!";
                }

            }
            catch (Exception ex)
            {
                return ($"Error: {ex.Message}");
            }
            finally
            {
                connect.Close();
            }

        }

        //sales report
        public DataTable LoadSalesReport(string year, string category)
        {
            DataTable dt = new DataTable();
            string query = "";

            string yearFilter = "";
            if (year != "All Years")
                yearFilter = " WHERE YEAR(ot.DateOrdered) = @Year ";

            if (category == "Month")
            {
                query = query = @"
                SELECT 
                YEAR(ot.DateOrdered) AS Year, 
                DATENAME(MONTH, ot.DateOrdered) AS Month, 
                SUM(i.Total) AS TotalSales
                FROM Invoice i
                LEFT JOIN OrderTable ot ON i.OrderID = ot.OrderID
                " + yearFilter + @"
                GROUP BY YEAR(ot.DateOrdered), MONTH(ot.DateOrdered), DATENAME(MONTH, ot.DateOrdered)
                ORDER BY YEAR(ot.DateOrdered) ASC, MONTH(ot.DateOrdered) ASC;
";
            }
            else if (category == "Employee")
            {
                query = @"
                    SELECT 
                        e.FullName as 'Employee', 
                        SUM(i.Total) as 'TotalSales'
                    FROM Invoice i
                    LEFT JOIN OrderTable ot ON i.OrderID = ot.OrderID
                    LEFT JOIN Employee e ON ot.EmployeeID = e.EmployeeID
                    " + yearFilter + @"
                    GROUP BY e.FullName
                    ORDER BY e.FullName ASC;";
            }
            
            
            else if (category == "PaymentMethod")
            {
                query = @"
                    SELECT 
                        i.PaymentMethod as 'Payment Method', 
                        SUM(i.Total) as 'TotalSales'
                    FROM Invoice i
                    LEFT JOIN OrderTable ot ON i.OrderID = ot.OrderID
                    " + yearFilter + @"
                    GROUP BY i.PaymentMethod
                    ORDER BY i.PaymentMethod ASC;";
            }

            using (SqlCommand command = new SqlCommand(query, connect))
            {
                if (year != "All Years")
                    command.Parameters.AddWithValue("@Year", Convert.ToInt32(year));

                try
                {
                    connect.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching sales report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            return dt;
        }

    }
}
    