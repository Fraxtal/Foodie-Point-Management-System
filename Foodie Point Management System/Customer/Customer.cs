using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using System.Collections;
using System.Configuration;
using System.Security.Cryptography;
using System.Net.Configuration;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace Foodie_Point_Management_System.Customer
{
    public class Customer
    {
        private int id;
        private string username;


        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public int? CurrentOrderId { get; set; }


        static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
    
        public Customer(int? i = null, string u = null) 
        {
            Id = i ?? 0;
            Username = u;
        }

        public bool IsValidEmail(string email)
        {
            // Basic regex pattern for email validation
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        public string Auth_Login(string q, string pN, string input, string p)
        {
            try
            {
                connect.Open();

                using (SqlCommand cmd = new SqlCommand(q, connect))
                {
                    cmd.Parameters.AddWithValue(pN, input.Trim());
                    cmd.Parameters.AddWithValue("@password", p.Trim());

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Id = Convert.ToInt32(reader["CustomerID"]);
                            Username = reader["username"].ToString();

                            return ("Login Successful!");
                        }
                        else
                        {
                            return ("Incorrect Credentials");
                        }
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

        public string Auth_Register(string u, string e, string p)
        {
            try
            {
                connect.Open();

                string selectUsername = "SELECT COUNT(CustomerID) FROM Customer WHERE Username = @user";
                string selectEmail = "SELECT COUNT(CustomerID) FROM Customer WHERE Email = @email";

                using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                {
                    checkUser.Parameters.AddWithValue("@user", u);
                    int countU = (int)checkUser.ExecuteScalar();

                    if (countU >= 1)
                    {
                        return (u + " is already taken");
                    }
                }

                using (SqlCommand checkEmail = new SqlCommand(selectEmail, connect))
                {
                    checkEmail.Parameters.AddWithValue("@email", e);
                    int countE = (int)checkEmail.ExecuteScalar();

                    if (countE >= 1)
                    {
                        return (e + " is already taken");
                    }
                }

                DateTime today = DateTime.Today;

                string insertData = "INSERT INTO Customer " +
                        "(Username, FullName, Email, Password, RegistrationDate) " +
                        "VALUES(@username, NULL, @email, @password, @RegDate)";

                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                {
                    cmd.Parameters.AddWithValue("@username", u);
                    cmd.Parameters.AddWithValue("@email", e);
                    cmd.Parameters.AddWithValue("@password", p);
                    cmd.Parameters.AddWithValue("@RegDate", today);

                    cmd.ExecuteNonQuery();

                    return ("Registered Successfully!");
                }
            }
            catch (Exception ex)
            {
                return ("Error: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        public List<string> LoadInfo()
        {
            List<string> result = new List<string>();
            result.Add(Username);
            try
            {
                connect.Open();

                string query = "SELECT FullName, Email, Password, RegistrationDate FROM Customer WHERE CustomerID = @id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@id", Id.ToString().Trim());

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result.Add(reader["FullName"].ToString());
                            result.Add(reader["Email"].ToString());
                            result.Add(reader["Password"].ToString());
                            result.Add(Convert.ToDateTime(reader["RegistrationDate"]).ToString("dd-MM-yyyy"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nThe Application will restart to prevent this error from happening", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }
            finally
            {
                connect.Close();
            }
            return result;
        }

        public bool CheckCustomerInfo(string username, string email)
        {
            try
            {
                connect.Open();

                string query = "SELECT COUNT(CustomerID) FROM Customer WHERE (Username = @username OR Email = @email) AND CustomerID != @id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@id", Id);

                    int count = (int)cmd.ExecuteScalar();

                    return count <= 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connect.Close();
            }
        }

        public string UpdateCustomerInfo(List <string> updated_userinfo)
        {
            string output = "";

            if (!CheckCustomerInfo(updated_userinfo[0], updated_userinfo[2]))
            {
                output = "Your account has not been updated due to having the same values of username and email of other existing account information!";
            }
            else
            {
                try
                {
                    connect.Open();
                
                    string query = "UPDATE Customer SET Username = @username, Fullname = @fullname, Email = @email, Password = @password WHERE CustomerID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", updated_userinfo[0]);
                        cmd.Parameters.AddWithValue("@fullname", updated_userinfo[1]);
                        cmd.Parameters.AddWithValue("@email", updated_userinfo[2]);
                        cmd.Parameters.AddWithValue("@password", updated_userinfo[3]);
                        cmd.Parameters.AddWithValue("@id", Id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            output = "Your account information has been updated successfully!";
                        }
                        else
                        {
                            output = "No changes were made.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    output = "Error: " + ex.Message;
                }
                finally
                {
                    connect.Close();
                }
            }
            
            return output;
        }

        public string SubmitReservationRequest(DateTime dt, int pax)
        {
            try
            {
                connect.Open();

                int reservID = 0;

                string query = @"
                    INSERT INTO Reservations (CustomerID, DateTime, Pax, HallID, ReservationStatus)
                    VALUES (@id, @dt, @pax, NULL, 'Pending') 
                    SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@dt", dt);
                    cmd.Parameters.AddWithValue("@pax", pax);

                    reservID = Convert.ToInt32(cmd.ExecuteScalar());
                }

                string txt = Microsoft.VisualBasic.Interaction.InputBox("Any Remarks for the Reservation Request?","Remark Notification","").Trim();

                query = @"INSERT INTO ReservationMessage (ReservationID, CustomerMsg, RCReply) VALUES (@ReservationID, @CustMsg, NULL)";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", reservID);
                    cmd.Parameters.AddWithValue("@CustMsg", txt);

                    cmd.ExecuteNonQuery();
                }

                return ("Reservation Request Successfully Submitted!");

            }
            catch (Exception ex)
            {
                return ("Error: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        public string SubmitFeedback(int rating, string content)
        {
            try
            {
                connect.Open();

                string query = "INSERT INTO Feedback " +
                    "(Rating, Content, CustomerID) " +
                    "VALUES (@rating, @content, @CustomerID)";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@rating", rating);
                    cmd.Parameters.AddWithValue("@content", content);
                    cmd.Parameters.AddWithValue("@CustomerID", Id);

                    cmd.ExecuteNonQuery();

                }
                return ("Feedback Successfully Submitted!");
            }
            catch (Exception ex)
            {
                return ("Error: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }

        }


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

        public string AddFood_OrderList(string Fid, int q)
        {
            string query;
            int quant = 0;
            try
            {
                connect.Open();

                // Check if there is an existing order with NULL status
                query = "SELECT OrderID FROM OrderTable WHERE CustomerID = @CustomerID AND OrderStatus IS NULL";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", Id);
                    var result = cmd.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                    {
                        DateTime Today = DateTime.Now;

                        // Create a new order if none exists
                        query = "INSERT INTO OrderTable (CustomerID, TotalAmount, DateOrdered, OrderStatus) VALUES (@CustomerID, 0, @dt, NULL); SELECT SCOPE_IDENTITY();";
                        using (SqlCommand insertCmd = new SqlCommand(query, connect))
                        {
                            insertCmd.Parameters.AddWithValue("@CustomerID", Id);
                            insertCmd.Parameters.AddWithValue("@dt", Today);
                            CurrentOrderId = Convert.ToInt32(insertCmd.ExecuteScalar());
                        }
                    }
                    else
                    {
                        CurrentOrderId = Convert.ToInt32(result);
                    }
                }

                // Check if the food item already exists in the order
                query = "SELECT Quantity FROM OrderDetail WHERE OrderID = @OrderID AND FoodID = @FoodID";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@OrderID", CurrentOrderId);
                    cmd.Parameters.AddWithValue("@FoodID", Fid);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            quant = int.Parse(reader["Quantity"].ToString()) + q;
                        }
                    }
                }

                if (quant > q)
                {
                    query = "INSERT INTO OrderDetail (OrderID, FoodID, Quantity) VALUES (@OrderID, @FoodID, @quantity)";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", CurrentOrderId);
                        cmd.Parameters.AddWithValue("@FoodID", Fid);
                        cmd.Parameters.AddWithValue("@quantity", quant);

                        int count = cmd.ExecuteNonQuery();

                        return ($"Order Added!");
                    }
                }
                else
                {
                    query = "UPDATE OrderDetail SET Quantity = @quantity WHERE OrderID = @OrderID AND FoodID = @FoodID";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", CurrentOrderId);
                        cmd.Parameters.AddWithValue("@FoodID", Fid);
                        cmd.Parameters.AddWithValue("@quantity", quant);

                        cmd.ExecuteNonQuery();

                        return ($"Order Added!");
                    }
                }
            }
            catch (Exception ex)
            {
                return ("Error: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }


        public string OrderListUpdater(string Oid, int q, string r)
        {
            string msg = "";
            try
            {
                connect.Open();

                if (q <= 0)
                {
                    // Delete the order detail if quantity is 0
                    string query = "DELETE FROM OrderDetail WHERE OrderDetailID = @Oid";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@Oid", Oid);

                        int count = cmd.ExecuteNonQuery();

                        if (count > 0)
                        {
                            msg = "Order Successfully Removed!";
                        }
                    }
                }
                else
                {
                    // Update the quantity in the order detail
                    string query = "UPDATE OrderDetail SET Quantity = @quantity, Remarks = @remarks WHERE OrderDetailID = @Oid";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@quantity", q);
                        cmd.Parameters.AddWithValue("@remarks", r);
                        cmd.Parameters.AddWithValue("@Oid", Oid);

                        int count = cmd.ExecuteNonQuery();

                        if (count > 0)
                        {
                            msg = "Order Successfully Updated!";
                        }
                        else
                        {
                            msg = "Nothing was Changed!";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                msg = "Error: " + ex.Message;
            }
            finally
            {
                connect.Close();
            }
            return msg;
        }


        public decimal PaymentTotal()
        {
            decimal total = 0;
            try
            {
                connect.Open();
                string query = "SELECT SUM(fm.Price * od.Quantity) AS TotalPrice FROM OrderDetail od JOIN FoodMenu fm ON od.FoodID = fm.FoodID JOIN OrderTable ot ON od.OrderID = ot.OrderID WHERE ot.CustomerID = @CustomerID AND ot.OrderStatus IS NULL";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@CustomerID", Id);
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        total = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            return total;
        }

        public string PaymentProcess(decimal total, string method)
        {
            string msg = "";
            try
            {
                connect.Open();

                if (total == 0) 
                {
                    //Delete Everything Order session , order id , details, ordertable (due to cascading delete, thus it just delete with one deletion of orderid)

                    string query = "DELETE FROM OrderTable WHERE OrderID = @oid";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@oid", CurrentOrderId);
                        cmd.ExecuteNonQuery();
                    }

                    CurrentOrderId = null;

                    msg = "Due to having none in your total, thus you are immediately transfered to your main dashboard!";

                }
                else 
                {
                    string query = "UPDATE OrderTable SET OrderStatus = @status WHERE CustomerID = @CustomerID AND OrderStatus IS NULL";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "In Queue");
                        cmd.Parameters.AddWithValue("@CustomerID", Id);

                        cmd.ExecuteNonQuery();
                    }

                    query = "INSERT INTO Invoice(CustomerID, Total, PaymentMethod) VALUES(@CustomerID, @total, @pMethod)";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", Id);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.Parameters.AddWithValue("@pMethod", method);

                        cmd.ExecuteNonQuery();
                    }
                    msg = "Payment Successful!";

                }
            }
            catch (Exception ex)
            {
                msg = "Error: " + ex.Message;
            }
            finally
            {
                connect.Close();
            }
            return msg;
        }

        public string ShowMessageReservationReply(string id)
        {
            try
            {
                string query = "SELECT CustomerMsg, RCReply FROM ReservationMessage WHERE ReservationID = @ReservationID";

                connect.Open();

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string customerMessage = reader["CustomerMsg"].ToString();
                            string rcReply = reader["RCReply"].ToString();

                            string responseMessage = $"Customer's Message:\n{customerMessage}\n\nReservation Coordinator's Reply:\n{rcReply}";

                            return responseMessage;
                        }
                        else
                        {
                            return "No reservation message found for the given Reservation ID.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
            finally
            {
                connect.Close();
            }
        }

    }
}
