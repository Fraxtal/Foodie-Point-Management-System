using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.NetworkInformation;
using System.Data.SqlTypes;
using System.Configuration;
using Foodie_Point_Management_System.Employee_Login;

namespace Foodie_Point_Management_System.Chef
{
    public class EmChef : Employee
    {
        private DataTable inventorylist = new DataTable();
        private DataTable vieworderlist = new DataTable();

        public EmChef(int ei, string eu, string ef, string er) : base(ei, eu, ef, er) { }

        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public bool InventoryCheckID(string iid)
        {
            string qCheck = "SELECT * FROM Inventory WHERE IngredientID = @ingredientID";
            try
            {
                connect.Open();

                using (SqlCommand cmdC = new SqlCommand(qCheck, connect))
                {
                    cmdC.Parameters.AddWithValue("@ingredientID", iid.Trim());

                    using (SqlDataReader readC = cmdC.ExecuteReader())
                    {   
                        if (readC.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connect.Close();
            }
        }

        public bool InventoryCheckName(string CNnm)
        {
            string qCheckName = "SELECT Name FROM Inventory WHERE Name = @name";
            try
            {
                connect.Open();

                using (SqlCommand cmdCN = new SqlCommand(qCheckName, connect))
                {
                    cmdCN.Parameters.AddWithValue("@name", CNnm.Trim());

                    using (SqlDataReader readCN = cmdCN.ExecuteReader())
                    {
                        if (readCN.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            { 
                connect.Close(); 
            }
        }

        public bool InventoryCheckIDName(string CINid, string CINnm)
        {
            string qCheckIDName = "SELECT Name FROM Inventory WHERE IngredientID = @ingredientid AND Name = @name";
            try
            {
                connect.Open();

                using (SqlCommand cmdCIN = new SqlCommand(qCheckIDName, connect))
                {
                    cmdCIN.Parameters.AddWithValue("@ingredientid", CINid.Trim());
                    cmdCIN.Parameters.AddWithValue("@name", CINnm.Trim());

                    using (SqlDataReader readCN = cmdCIN.ExecuteReader())
                    {
                        if (readCN.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connect.Close();
            }
        }

        public string InventoryAdd (string na, int qn)
        {
            string qIAdd = "INSERT INTO Inventory (Name, Quantity) VALUES (@name, @quantity)";
            try
            {
                connect.Open();

                using (SqlCommand cmdUI = new SqlCommand(qIAdd, connect))
                {
                    cmdUI.Parameters.AddWithValue("@name", na.Trim());
                    cmdUI.Parameters.AddWithValue("@quantity", qn);

                    int updaterows = cmdUI.ExecuteNonQuery();

                    if (updaterows != 0)
                    {
                        return $"New Item Added: \nID: {id} \nName: {na} \nQuantity: {qn}";
                    }
                    else
                    {
                        return "Error: No Records Added.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
            finally
            {
                connect.Close();
            }
        }

        public string InventoryUpdate(int id, string na, int qn)
        {
            string qIUpdate = "UPDATE Inventory SET Name = @name, Quantity = @quantity WHERE IngredientID = @ingredientID";
            try
            {
                connect.Open();

                using (SqlCommand cmdUI = new SqlCommand(qIUpdate, connect))
                {
                    cmdUI.Parameters.AddWithValue("@ingredientID", id);
                    cmdUI.Parameters.AddWithValue("@name", na.Trim());
                    cmdUI.Parameters.AddWithValue("@quantity", qn);

                    int updaterows = cmdUI.ExecuteNonQuery();

                    if (updaterows != 0)
                    {
                        return $"Item Details Updated: \nID: {id} \nName: {na} \nQuantity: {qn}";
                    }
                    else
                    {
                        return "Error: No Changes Made.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
            finally
            {
                connect.Close();
            }
        }

        public string InventoryDelete(string iidD)
        {

            string qDelete = "DELETE FROM Inventory WHERE IngredientID = @ingredientID";

            try
            {
                connect.Open();

                using (SqlCommand cmdD = new SqlCommand(qDelete, connect))
                {
                    cmdD.Parameters.AddWithValue("@ingredientID", iidD.Trim());

                    int deleted = cmdD.ExecuteNonQuery();

                    if (deleted != 0)
                    {
                        return $"Record {iidD} successful deleted.";
                    }
                    else
                    {
                        return "No record deleted. Please enter a valid ID.";             }

                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
            finally
            {
                connect.Close();
            }
        }

        public object InventoryDisplay()
        {
            inventorylist.Clear();
            SqlDataAdapter adapterD = new SqlDataAdapter("SELECT * FROM Inventory", connect);
            adapterD.Fill(inventorylist);
            return inventorylist;
        }

        public object InventorySearch(string input)
        {
            string qSearch = "SELECT * FROM Inventory WHERE IngredientID LIKE @ingredientid OR Name LIKE @name";

            try
            {
                connect.Open();

                using (SqlCommand cmdS = new SqlCommand(qSearch, connect))
                {
                    cmdS.Parameters.Add(new SqlParameter("@ingredientID", SqlDbType.VarChar) { Value = $"%{input.Trim()}%" });
                    cmdS.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar) { Value = $"%{input.Trim()}%" });

                    inventorylist.Clear();
                    SqlDataAdapter adapterS = new SqlDataAdapter(cmdS);
                    adapterS.Fill(inventorylist);
                    return inventorylist;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connect.Close();
            }
        }

        public List<string> DashboardOrderNumbers()
        {
            List<string> ordernum = new List<string>();
            string qUnfulfilled = "SELECT COUNT(OrderDetailID) FROM OrderDetail LEFT JOIN OrderTable ON OrderDetail.OrderID = OrderTable.OrderID WHERE OrderTable.OrderStatus = 'In Queue' OR OrderTable.OrderStatus = 'In Progress'";
            string qFulfilled = "SELECT COUNT(OrderDetailID) FROM OrderDetail LEFT JOIN OrderTable ON OrderDetail.OrderID = OrderTable.OrderID WHERE OrderStatus = 'Completed'";
;

            try
            {
                connect.Open();

                using (SqlCommand cmdUF = new SqlCommand(qUnfulfilled, connect))
                {
                    using (SqlDataReader readUF = cmdUF.ExecuteReader())
                    {
                        if (readUF.Read())
                        {
                            ordernum.Add(readUF.ToString());
                        }
                    }
                        
                }

                using (SqlCommand cmdFF = new SqlCommand(qFulfilled, connect))
                {
                    using (SqlDataReader readFF = cmdFF.ExecuteReader())
                    {
                        if (readFF.Read())
                        {
                            ordernum.Add(readFF.ToString());
                        }
                    }
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
            return ordernum;
        }

        public object ViewOrdersDisplay(string qDisplay)
        {
            vieworderlist.Clear();
            SqlDataAdapter adapterVOD = new SqlDataAdapter(qDisplay, connect);
            adapterVOD.Fill(vieworderlist);
            return vieworderlist;  
        }

        public bool ViewOrderCheck(string orID)
        {
            string qOrderCheck = "SELECT * FROM OrderTable WHERE OrderID = @orderid";

            try
            {
                connect.Open();
                using (SqlCommand cmdOC = new SqlCommand(qOrderCheck, connect))
                {
                    cmdOC.Parameters.AddWithValue("@orderid", orID);

                    using (SqlDataReader readOC = cmdOC.ExecuteReader())
                    {
                        if (readOC.Read())
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Invalid Order ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connect.Close();
            }
        }

        public string ViewOrderUpdate(string oID, string oStatus)
        {
            string qOrderUpdate = "UPDATE OrderTable SET OrderStatus = @orderstatus, EmployeeID = @employeeid WHERE OrderID = @orderid";

            try
            {
                connect.Open();
                
                using (SqlCommand cmdOU = new SqlCommand(qOrderUpdate, connect))                                            
                {                                
                    cmdOU.Parameters.AddWithValue("@orderid", oID);
                    cmdOU.Parameters.AddWithValue("@orderstatus", oStatus);                                
                    cmdOU.Parameters.AddWithValue("@employeeid", Id);
                    
                    using (SqlDataReader readOU = cmdOU.ExecuteReader())
                    {
                        if (readOU.Read())
                        {
                            return $"Order Status Updated: \nOrder ID: {oID} \nNew Status: {oStatus}";
                        }
                        else
                        {
                            return "Order Not Updated.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
            finally
            {
                connect.Close();
            }
        }


    }
}
