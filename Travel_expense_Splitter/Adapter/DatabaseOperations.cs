using System;
using System.Data.SqlClient;
using Travel_expense_Splitter.Adapter;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;

namespace Travel_expense_Splitter
{
    public static class DatabaseOperations
    {
        public static int GetUserCount(string username, string password)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = "SELECT COUNT(*) FROM login_table WHERE (username = @username or Email = @username) AND pass = @password";
                using (SqlCommand command = new SqlCommand(query, dbHelper.Connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public static int GetTotalMembers()
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = "SELECT COUNT(*) FROM Members";
                using (SqlCommand cmd = new SqlCommand(query, dbHelper.Connection))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public static decimal GetTotalExpenses()
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = "SELECT SUM(Amount) FROM Expense";
                using (SqlCommand cmd = new SqlCommand(query, dbHelper.Connection))
                {
                    object result = cmd.ExecuteScalar();
                    if (result == DBNull.Value)
                    {
                        return 0;
                    }
                    else
                    {
                        return Convert.ToDecimal(result);
                    }
                }
            }
        }

        public static int GetLoginId(string username)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = "SELECT Login_ID FROM login_table WHERE Username = @username";
                using (SqlCommand cmd = new SqlCommand(query, dbHelper.Connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public static List<ExpenseAdapter> GetMembers()
        {
            List<ExpenseAdapter> members = new List<ExpenseAdapter>();
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = "SELECT * FROM Members";
                using (SqlDataReader reader = dbHelper.ExecuteReader(query))
                {
                    DataTable ExpenseTable = new DataTable();
                    ExpenseTable.Load(reader);

                    foreach (DataRow row in ExpenseTable.Rows)
                    {
                        ExpenseAdapter member = new ExpenseAdapter
                        {
                            member_name = row["Member_Name"].ToString(),
                            Payer_id = Convert.ToInt32(row["Member_ID"])
                        };
                        members.Add(member);
                    }
                }
            }
            return members;
        }

        public static SqlDataReader GetMemberCheckBoxes()
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = "SELECT Member_ID, Member_Name FROM Members";
                return dbHelper.ExecuteReader(query);
            }
        }

        public static int AddExpense(string expense_name, string amount, int memberid, DateTime dateTime, string checkedMembers, int loginId)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = "INSERT INTO Expense (Description, Amount, Payer_ID, Date, CheckedMembers, Login_ID) VALUES (@expense_name, @amount, @memberid, @dateTime, @checkedMembers, @loginId)";
                using (SqlCommand cmd = new SqlCommand(query, dbHelper.Connection))
                {
                    cmd.Parameters.AddWithValue("@expense_name", expense_name);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@memberid", memberid);
                    cmd.Parameters.AddWithValue("@dateTime", dateTime);
                    cmd.Parameters.AddWithValue("@checkedMembers", checkedMembers);
                    cmd.Parameters.AddWithValue("@loginId", loginId);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static SqlDataReader GetExpenseDetails()
        {

            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = @"SELECT mb.Member_ID, mb.Member_Name, Ex.Amount, Ex.CheckedMembers, lt.username 
                                 FROM Members mb 
                                 JOIN Expense Ex ON Ex.Payer_ID = mb.Member_ID
                                 JOIN login_table lt ON Ex.Login_ID = lt.Login_ID";
                return dbHelper.ExecuteReader(query);
            }
        }

        public static string GetMemberNames(string checkedMembers)
        {
            if (string.IsNullOrEmpty(checkedMembers))
            {
                return "None";
            }
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {

                string[] memberIds = checkedMembers.Split(',');
                string query = "SELECT Member_Name FROM Members WHERE Member_ID IN (" + string.Join(",", memberIds) + ")";
                SqlDataReader reader = dbHelper.ExecuteReader(query);

                List<string> memberNames = new List<string>();
                while (reader.Read())
                {
                    memberNames.Add(reader.GetString(0));
                }

                reader.Close();
                return string.Join(", ", memberNames);
            }
        }


        public static int SignUpUser(string username, string email, string password)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = "INSERT INTO login_table (username, Email, pass) VALUES (@name, @email, @password);";
                using (SqlCommand cmd = new SqlCommand(query, dbHelper.Connection))
                {
                    cmd.Parameters.AddWithValue("@name", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int UpdatePassword(string email, string newPassword)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = "UPDATE login_table SET pass = @password WHERE Email = @Email";
                using (SqlCommand cmd = new SqlCommand(query, dbHelper.Connection))
                {
                    cmd.Parameters.AddWithValue("@password", newPassword);
                    cmd.Parameters.AddWithValue("@Email", email);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int AddMember(string member_name, string mem_email, string phoneNo)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = "INSERT INTO Members (Member_Name, Email_ID, Phone) VALUES (@member_name, @mem_email, @phoneNo)";
                using (SqlCommand cmd = new SqlCommand(query, dbHelper.Connection))
                {
                    cmd.Parameters.AddWithValue("@member_name", member_name);
                    cmd.Parameters.AddWithValue("@mem_email", mem_email);
                    cmd.Parameters.AddWithValue("@phoneNo", phoneNo);

                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }

}

