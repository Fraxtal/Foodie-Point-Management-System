using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using System.Collections;
using System.Configuration;

namespace Foodie_Point_Management_System.Employee_Login
{
    public class Employee
    {
        protected int id;
        protected string username;
        protected string fullname;
        protected string role;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Role { get => role; set => role = value; }

        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Employee(int ei, string eu, string ef, string er)
        {
            Id = ei;
            Username = eu;
            Fullname = ef;
            Role = er;
        }

        public string EmpLogin(string Eq, string EpN, string Einput, string Ep)
        {
            try
            {
                connect.Open();

                using (SqlCommand cmd = new SqlCommand(Eq, connect))
                {
                    cmd.Parameters.AddWithValue(EpN, Einput.Trim());
                    cmd.Parameters.AddWithValue("@password", Ep.Trim());

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Id = Convert.ToInt32(reader["EmployeeID"]);
                            Username = reader["Username"].ToString();
                            Fullname = reader["Fullname"].ToString();
                            Role = reader["Role"].ToString();

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

        public bool EmployeeProfileCheck(string checkusername, string checkemail)
        {
            string qEmployeeCheck = "SELECT COUNT(EmployeeID) FROM Employee WHERE (Username = @username OR Email = @email) AND EmployeeID != @employeeID";

            try
            {
                using (SqlCommand cmdEC = new SqlCommand(qEmployeeCheck, connect))
                {
                    cmdEC.Parameters.AddWithValue("@employeeID", Id);
                    cmdEC.Parameters.AddWithValue("@username", checkusername.Trim());
                    cmdEC.Parameters.AddWithValue("@email", checkemail.Trim());

                    int matches = (int)cmdEC.ExecuteScalar();

                    return matches <= 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void EmployeeProfileUpdate(List<string> newinfo)
        {
            string qProfileUpdate =
                "UPDATE Employee SET Username = @Username, FullName = @fullname, Email = @email, Password = @password " +
                "WHERE EmployeeID = @employeeID";
            try
            {
                connect.Open();

                if (!EmployeeProfileCheck(newinfo[0], newinfo[2]))
                {
                    MessageBox.Show("Username or email is already taken.");
                }
                else
                {
                    using (SqlCommand cmdPU = new SqlCommand(qProfileUpdate, connect))
                    {
                        cmdPU.Parameters.AddWithValue("@employeeID", Id);
                        cmdPU.Parameters.AddWithValue("@username", newinfo[0].Trim());
                        cmdPU.Parameters.AddWithValue("@fullname", newinfo[1].Trim());
                        cmdPU.Parameters.AddWithValue("@email", newinfo[2].TrimEnd());
                        cmdPU.Parameters.AddWithValue("@password", newinfo[3].Trim());

                        int changes = cmdPU.ExecuteNonQuery();
                        if (changes != 0)
                        {
                            Username = newinfo[0];
                            Fullname = newinfo[1];
                            MessageBox.Show("Account details sucessfully updated.");
                        }
                        else
                        {
                            MessageBox.Show($"No changes made to account with ID: {id}");
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
        }

        public List<string> EmployeeLoad()
        {
            List<string> emInfo = new List<string>();
            emInfo.Add(Username);
            try
            {
                connect.Open();

                string qEmployeeLoad = "SELECT FullName, Email, Password, Role FROM Employee WHERE EmployeeID = @employeeID";

                using (SqlCommand cmdEL = new SqlCommand(qEmployeeLoad, connect))
                {
                    cmdEL.Parameters.AddWithValue("@employeeID", Id.ToString().Trim());

                    using (SqlDataReader readerEL = cmdEL.ExecuteReader())
                    {
                        if (readerEL.Read())
                        {
                            emInfo.Add(readerEL["Fullname"].ToString());    
                            emInfo.Add(readerEL["Email"].ToString());
                            emInfo.Add(readerEL["Password"].ToString());
                            emInfo.Add(readerEL["Role"].ToString());
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
            return emInfo;
        }

        public string EmpWelcome(string eUser)
        {
            Random rnd = new Random();
            int variant = rnd.Next(1, 5);

            switch (variant)
            {
                case 1:
                    return $"Greetings, {eUser}. \nHave a nice day!";

                case 2:
                    return $"Hello, {eUser}. \nLet's get started!";

                case 3:
                    return $"A good day to you, {eUser}. \nRemember to take a breather when ever you can!";

                default:
                    return $"Welcome back, {eUser}. \nReady to get started again?";
            }


        }
    }
}
