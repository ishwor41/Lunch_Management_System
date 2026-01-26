using LunchManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Applcation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {


            string fullName = nameTextBox.Text;
            string userName = userNameTextBox.Text;
            string pass = passTextBox.Text;
            string conPass = confirmPassTextBox.Text;
            if (pass == conPass)
            {
                string connstring =
                @"Data Source=LAPTOP-MUQ2LAHR\SQL22;
          Initial Catalog=LunchManagementSystem;
          User ID=sa;
          Password=123";

                Guid salt = Guid.NewGuid();
                byte[] hash = PasswordHelper.HashPassword(pass, salt);

                string query = @"INSERT INTO Users
                     (FullName, UserName, PasswordHash, PasswordSalt)
                     VALUES
                     (@FullName, @UserName, @PasswordHash, @PasswordSalt)";

                using (SqlConnection con = new SqlConnection(connstring))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@PasswordHash", hash);
                    cmd.Parameters.AddWithValue("@PasswordSalt", salt);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User registered successfully");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                passValidation.Text = "Please check your password and try again";

            }




        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmPassTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passValidation_Click(object sender, EventArgs e)
        {

        }
    }
}
