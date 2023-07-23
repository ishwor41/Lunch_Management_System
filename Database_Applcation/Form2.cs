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
                string connstring = "Data Source = LAPTOP-LP7JVVRA\\SQL22; Initial Catalog = DMS; User ID=sa; Password=#$W@$/K753#*D@/@!B@$E#";
                SqlConnection con = new SqlConnection(connstring);
                SqlDataAdapter adapter = new SqlDataAdapter();
                con.Open();
                string query = "insert into Users(FULLNAME, USERNAME, PASSWORD) values('" + fullName + "', '" + userName + "', '" + pass + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                adapter.InsertCommand = new SqlCommand(query, con);
                adapter.InsertCommand.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("The user has registered sccessfully");
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
