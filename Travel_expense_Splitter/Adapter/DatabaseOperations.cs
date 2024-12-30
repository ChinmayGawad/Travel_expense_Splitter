using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Travel_expense_Splitter.Adapter;

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
                    while (reader.Read())
                    {
                        ExpenseAdapter member = new ExpenseAdapter
                        {
                            member_name = reader["Member_Name"].ToString(),
                            Payer_id = Convert.ToInt32(reader["Member_ID"])
                        };
                        members.Add(member);
                    }
                }
            }
            return members;
        }

        public static List<(int MemberId, string MemberName)> GetMemberCheckBoxes()
        {
            List<(int MemberId, string MemberName)> members = new List<(int MemberId, string MemberName)>();
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = "SELECT Member_ID, Member_Name FROM Members";
                using (SqlDataReader reader = dbHelper.ExecuteReader(query))
                {
                    while (reader.Read())
                    {
                        members.Add((reader.GetInt32(0), reader.GetString(1)));
                    }
                }
            }
            return members;
        }

        public static int AddExpense(string expense_name, string amount, int memberid, DateTime dateTime, string checkedMembers, int loginId, int tripId)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = "INSERT INTO Expense (Description, Amount, Payer_ID, Date, CheckedMembers, Login_ID, Trip_ID) VALUES (@expense_name, @amount, @memberid, @dateTime, @checkedMembers, @loginId, @tripId)";
                using (SqlCommand cmd = new SqlCommand(query, dbHelper.Connection))
                {
                    cmd.Parameters.AddWithValue("@expense_name", expense_name);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@memberid", memberid);
                    cmd.Parameters.AddWithValue("@dateTime", dateTime);
                    cmd.Parameters.AddWithValue("@checkedMembers", checkedMembers);
                    cmd.Parameters.AddWithValue("@loginId", loginId);
                    cmd.Parameters.AddWithValue("@tripId", tripId);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<(int MemberId, string MemberName, string ExpenseName, int Amount, string CheckedMembers, string Username)> GetExpenseDetails(int tripId)
        {
            List<(int MemberId, string MemberName, string ExpenseName, int Amount, string CheckedMembers, string Username)> expenses = new List<(int MemberId, string MemberName, string ExpenseName, int Amount, string CheckedMembers, string Username)>();
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = @"SELECT mb.Member_ID, mb.Member_Name, Ex.Description, Ex.Amount, Ex.CheckedMembers, lt.username 
                         FROM Members mb 
                         JOIN Expense Ex ON Ex.Payer_ID = mb.Member_ID
                         JOIN login_table lt ON Ex.Login_ID = lt.Login_ID
                         WHERE Ex.Trip_ID = @tripId";
                using (SqlCommand cmd = new SqlCommand(query, dbHelper.Connection))
                {
                    cmd.Parameters.AddWithValue("@tripId", tripId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            expenses.Add((reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.IsDBNull(4) ? string.Empty : reader.GetString(4), reader.GetString(5)));
                        }
                    }
                }
            }
            return expenses;
        }


        public static List<(int TripId, string TripName)> GetTrips()
        {
            List<(int TripId, string TripName)> trips = new List<(int TripId, string TripName)>();
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = "SELECT Trip_ID, Trip_Name FROM Trip";
                using (SqlDataReader reader = dbHelper.ExecuteReader(query))
                {
                    while (reader.Read())
                    {
                        trips.Add((reader.GetInt32(0), reader.GetString(1)));
                    }
                }
            }
            return trips;
        }

        public static int AddTrip(string tripName)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = "INSERT INTO Trip (Trip_Name) VALUES (@tripName)";
                using (SqlCommand cmd = new SqlCommand(query, dbHelper.Connection))
                {
                    cmd.Parameters.AddWithValue("@tripName", tripName);
                    return cmd.ExecuteNonQuery();
                }
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
                using (SqlDataReader reader = dbHelper.ExecuteReader(query))
                {
                    List<string> memberNames = new List<string>();
                    while (reader.Read())
                    {
                        memberNames.Add(reader.GetString(0));
                    }
                    return string.Join(", ", memberNames);
                }
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

        public static int AddMember(string name, string email, string phone, int tripId)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = "INSERT INTO Members (Member_Name, Email_ID, Phone, Trip_ID) VALUES (@name, @Email, @Phone, @TripId)";
                using (SqlCommand cmd = new SqlCommand(query, dbHelper.Connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@TripId", tripId);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<ExpenseAdapter> GetMembersByTrip(int tripId)
        {
            List<ExpenseAdapter> members = new List<ExpenseAdapter>();

            string query = "SELECT Member_ID, Member_Name FROM Members WHERE Trip_ID = @TripId";

            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                using (SqlCommand command = new SqlCommand(query, dbHelper.Connection))
                {
                    command.Parameters.AddWithValue("@TripId", tripId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ExpenseAdapter member = new ExpenseAdapter
                            {
                                Payer_id = reader.GetInt32(0),
                                member_name = reader.GetString(1)
                            };
                            members.Add(member);
                        }
                    }
                }
            }

            return members;
        }

        public static string GetUsername(int loginId)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper())
            {
                string query = "SELECT Username FROM login_table WHERE Login_ID = @loginId";
                using (SqlCommand cmd = new SqlCommand(query, dbHelper.Connection))
                {
                    cmd.Parameters.AddWithValue("@loginId", loginId);
                    return cmd.ExecuteScalar()?.ToString();
                }
            }
        }

    }
}
