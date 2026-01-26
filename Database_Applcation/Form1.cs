


using LunchManagementSystem.Helpers;
using System.Data;
using System.Data.SqlClient;

namespace Database_Applcation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userName = usernameTxtBox.Text.Trim();
            string inputPassword = passwordTextBox.Text;

            string connstring =
                @"Data Source=LAPTOP-MUQ2LAHR\SQL22;
          Initial Catalog=LunchManagementSystem;
          User ID=sa;
          Password=123";

            string query = @"SELECT PasswordHash, PasswordSalt
                     FROM Users
                     WHERE UserName = @UserName";

            using (SqlConnection con = new SqlConnection(connstring))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@UserName", userName);

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        byte[] storedHash = (byte[])reader["PasswordHash"];
                        Guid storedSalt = (Guid)reader["PasswordSalt"];

                        byte[] inputHash =
                            PasswordHelper.HashPassword(inputPassword, storedSalt);

                        if (storedHash.SequenceEqual(inputHash))
                        {
                            MessageBox.Show("Login successful");
                            // Open dashboard form here
                        }
                        else
                        {
                            MessageBox.Show("Invalid password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found");
                    }
                }
            }
        }
    }
}