using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Foodie_Point_Management_System.ReservationCoordinator
{
    internal class ReservationCoordinator
    {
        static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        //display reservation list in table
        public object ReservationTable(string input)
        {
            SqlDataAdapter reservationlist = new SqlDataAdapter(input, connect);
            DataTable RTable = new DataTable();
            reservationlist.Fill(RTable);
            return RTable;
        }

        public List<string> ReservationCount()
        {
            List<string> allreservations = new List<string>();

            string pending = "SELECT COUNT(ReservationID) FROM Reservations WHERE ReservationStatus = 'Pending'";
            string confirmed = "SELECT COUNT(ReservationID) FROM Reservations WHERE ReservationStatus = 'Confirmed'";
            string cancelled = "SELECT COUNT(ReservationID) FROM Reservations WHERE ReservationStatus = 'Cancelled'";

            connect.Open();
            SqlCommand cmd1 = new SqlCommand(pending, connect);
            SqlCommand cmd2 = new SqlCommand(confirmed, connect);
            SqlCommand cmd3 = new SqlCommand(cancelled, connect);

            int countpending = Convert.ToInt32(cmd1.ExecuteScalar());
            int countconfirmed = Convert.ToInt32(cmd2.ExecuteScalar());
            int countcancelled = Convert.ToInt32(cmd3.ExecuteScalar());//return the first column of the first row

            allreservations.Add(countpending.ToString());
            allreservations.Add(countconfirmed.ToString());
            allreservations.Add(countcancelled.ToString());

            connect.Close();
            return allreservations;
        }

        public object ReservationSearch(string customerid, string status, DateTime datetime, int pax)
        {
            string Search = "SELECT * FROM Reservations WHERE (CustomerID=@id AND ReservationStatus=@rstatus) AND DateTime=@datetime AND Pax=@numguest";

            try
            {
                connect.Open();
                using (SqlCommand cmd4 = new SqlCommand(Search, connect))
                {
                    cmd4.Parameters.AddWithValue("@id", customerid);
                    cmd4.Parameters.AddWithValue("@rstatus", status);
                    cmd4.Parameters.AddWithValue("@datetime", datetime);
                    cmd4.Parameters.AddWithValue("@numguest", pax);

                    SqlDataAdapter resSearch = new SqlDataAdapter(cmd4);
                    DataTable reservationSearch = new DataTable();
                    resSearch.Fill(reservationSearch);
                    return reservationSearch;
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

        public string ReservationAdd(string customerid, string status, string hallid, DateTime datetime, int pax)
        {
            string Add = "INSERT INTO Reservations (CustomerID, ReservationStatus, HallID, DateTime, Pax) VALUES(@id, @rstatus, @hallid, @datetime, @numguest)";

            try
            {
                connect.Open();
                using (SqlCommand cmd5 = new SqlCommand(Add, connect))
                {
                    cmd5.Parameters.AddWithValue("@id", customerid.Trim());
                    cmd5.Parameters.AddWithValue("@rstatus", status.Trim());
                    cmd5.Parameters.AddWithValue("@hallid", hallid.Trim());
                    cmd5.Parameters.AddWithValue("@datetime", datetime);
                    cmd5.Parameters.AddWithValue("@numguest", (pax.ToString()).Trim());

                    int resAdd = cmd5.ExecuteNonQuery();
                    {
                        if (resAdd != 0)
                        {
                            return ("Successfully added new reservation.");
                        }
                        else
                        {
                            return ("New reservation not added.");
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

        public string ReservationDelete(int resID)
        {
            string delete = "DELETE FROM Reservations WHERE ReservationID=@reservationID";

            try
            {
                connect.Open();
                using (SqlCommand cmd6 = new SqlCommand(delete, connect))
                {
                    cmd6.Parameters.AddWithValue("@reservationid", resID);

                    int resDelete = cmd6.ExecuteNonQuery();

                    if (resDelete != 0)
                    {
                        return("Reservation successfully deleted.");
                    }
                    else
                    {
                        return("Deletion was unsuccessful.");
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

        public string ReservationEdit(string customerid, string status, string hallid, DateTime datetime, int pax, int resID)
        {
            string edit = "UPDATE Reservations SET CustomerID=@id, ReservationStatus=@rstatus, HallID=@hallid, DateTime=@datetime, Pax=@numguest WHERE ReservationID=@reservationid";

            try
            {
                connect.Open();
                using (SqlCommand cmd7 = new SqlCommand(edit, connect))
                {
                    cmd7.Parameters.AddWithValue("@id", customerid.Trim());
                    cmd7.Parameters.AddWithValue("@rstatus", status.Trim());
                    cmd7.Parameters.AddWithValue("@hallid", hallid.Trim());
                    cmd7.Parameters.AddWithValue("@datetime", datetime);
                    cmd7.Parameters.AddWithValue("@numguest", pax);
                    cmd7.Parameters.AddWithValue("@reservationid", resID);

                    int resEdit = cmd7.ExecuteNonQuery();

                    if (resEdit != 0)
                    {
                        return ("Reservation updated.");
                    }
                    else
                    {
                        return("Reservation not updated.");
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

        public string RCRequests(string msgID, string rcReply)
        {
            string requests = "UPDATE ReservationMessage SET RCReply=@rcReply WHERE MessageID=@msgID";

            try
            {
                connect.Open();
                using (SqlCommand cmd8 = new SqlCommand(requests, connect))
                {
                    cmd8.Parameters.AddWithValue("@rcReply", rcReply.Trim());
                    cmd8.Parameters.AddWithValue("@msgID", Convert.ToInt32(msgID));

                    int resRequests = cmd8.ExecuteNonQuery();

                    if (resRequests != 0)
                    {
                        return "Reply submitted.";
                    }
                    else
                    {
                        return "ID not found.";
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

        public int AssignHall(int pax, DateTime reservationdate)
        {
            int assignedHallID = -1; // Default if no hall is found
            string query = "SELECT TOP 1 Hall.HallID FROM Hall WHERE Pax >= @pax AND HallID NOT IN (SELECT HallID FROM Reservations WHERE DateTime = @reservationdate) ORDER BY Pax ASC";

            try
            {
                connect.Open();
                using (SqlCommand cmd9 = new SqlCommand(query, connect))
                {
                    cmd9.Parameters.AddWithValue("pax", pax);
                    cmd9.Parameters.AddWithValue("@reservationdate", reservationdate);

                    object result = cmd9.ExecuteScalar();
                    if (result != null)
                    {
                        assignedHallID = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error assigning hall: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            return assignedHallID;
        }
    }
}
