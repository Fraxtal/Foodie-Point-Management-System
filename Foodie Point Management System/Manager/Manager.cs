using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodie_Point_Management_System.Manager
{
    public class EmManager
    {
        static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public object HallTable(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public List<int> HallIDList()
        {
            List<int> halls = new List<int>();
            string hallcheck = "SELECT HallID FROM Hall";
            try
            {
                connect.Open();
                using (SqlCommand cmd1 = new SqlCommand(hallcheck, connect))
                {
                    using (SqlDataReader readerHID = cmd1.ExecuteReader())
                    {
                        while (readerHID.Read())
                        {
                            halls.Add(readerHID.GetInt32(0));
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return halls;
        }

        public void HallAdd(int pax, string partyType)
        {
            string Add = "INSERT INTO Hall (Pax, PartyType) VALUES (@pax, @type)";

            try
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand(Add, connect))
                {
                    cmd.Parameters.AddWithValue("@pax", pax);
                    cmd.Parameters.AddWithValue("@type", partyType.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        MessageBox.Show("Hall added successfully!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        public void HallEdit(int hallId, int pax, string partyType)
        {
            string updateQuery = "UPDATE Hall SET Pax = @pax, PartyType = @type WHERE HallID = @id";

            try
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@pax", pax);
                    cmd.Parameters.AddWithValue("@type", partyType.Trim());
                    cmd.Parameters.AddWithValue("@id", hallId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        MessageBox.Show("Hall updated!");
                    else
                        MessageBox.Show("No hall found with this ID.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}");
            }
            finally
            {
                connect.Close();
            }
        }

        public void HallDelete(int hallId)
        {
            string deleteQuery = "DELETE FROM Hall WHERE HallID = @hallID";

            try
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@hallID", hallId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Hall deleted successfully!");
                    else
                        MessageBox.Show("No hall found with this ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        public DataTable HallSearch(string searchTerm)
        {
            string searchQuery = @"SELECT * FROM Hall WHERE HallID LIKE @search OR PartyType LIKE @search OR CAST(Pax AS VARCHAR(10)) LIKE @search";

            DataTable result = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand(searchQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@search", $"%{searchTerm}%");
                    connect.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}");
            }
            finally
            {
                connect.Close();
            }
            return result;
        }

        public void FoodAdd(string name, string cuisineType, decimal price)
        {
            string addQuery = "INSERT INTO FoodMenu (Name, CuisineType, Price) VALUES (@name, @type, @price)";

            try
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand(addQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@name", name.Trim());
                    cmd.Parameters.AddWithValue("@type", cuisineType.Trim());
                    cmd.Parameters.AddWithValue("@price", price);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        MessageBox.Show("Menu item added successfully!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        public void FoodEdit(int foodId, string name, string cuisineType, decimal price)
        {
            string updateQuery = "UPDATE FoodMenu SET Name = @name, CuisineType = @type, Price = @price WHERE FoodID = @id";

            try
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@name", name.Trim());
                    cmd.Parameters.AddWithValue("@type", cuisineType.Trim());
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@id", foodId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        MessageBox.Show("Menu item updated!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        public void FoodDelete(int foodId)
        {
            string deleteQuery = "DELETE FROM FoodMenu WHERE FoodID = @id";

            try
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@id", foodId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Menu item deleted!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        public DataTable FoodSearch(string searchTerm)
        {
            string searchQuery = @"SELECT * FROM FoodMenu WHERE FoodID LIKE @search OR CuisineType LIKE @search OR Name LIKE @search OR CAST(Price AS VARCHAR(10)) LIKE @search";

            DataTable result = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand(searchQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@search", $"%{searchTerm}%");
                    connect.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}");
            }
            finally
            {
                connect.Close();
            }
            return result;
        }

        public DataTable LoadReservationReport()
        {

            DataTable dt = new DataTable();
            try
            {
                connect.Open();
                string query = @"
                    SELECT 
                        r.ReservationID,
                        r.DateTime AS ReservationDateTime,
                        r.Pax,
                        r.ReservationStatus,
                        c.CustomerID,
                        c.FullName AS CustomerName,
                        c.Email AS CustomerEmail,
                        h.HallID,
                        h.PartyType,
                        h.Pax AS HallCapacity,
                        rm.CustomerMsg AS CustomerMessage,
                        rm.RCReply AS CoordinatorReply,
                        o.OrderID,
                        o.TotalAmount AS OrderTotal,
                        o.OrderStatus,
                        i.InvoiceID,
                        i.Total AS InvoiceTotal,
                        i.PaymentMethod,
                        e.EmployeeID AS AssignedEmployeeID,
                        e.FullName AS AssignedEmployeeName,
                        e.Role AS EmployeeRole
                    FROM 
                        Reservations r
                    JOIN 
                        Customer c ON r.CustomerID = c.CustomerID
                    JOIN 
                        Hall h ON r.HallID = h.HallID
                    LEFT JOIN 
                        ReservationMessage rm ON r.ReservationID = rm.ReservationID
                    LEFT JOIN 
                        OrderTable o ON r.CustomerID = o.CustomerID 
                        AND CAST(o.DateOrdered AS DATE) = CAST(r.DateTime AS DATE)
                    LEFT JOIN 
                        Invoice i ON o.OrderID = i.OrderID
                    LEFT JOIN 
                        Employee e ON o.EmployeeID = e.EmployeeID
                    ORDER BY 
                        r.DateTime DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable dataTable = new DataTable();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reservation report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close( );
            }
            return dt;
        }

    }
}