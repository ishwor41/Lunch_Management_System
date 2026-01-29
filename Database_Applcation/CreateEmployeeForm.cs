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
    public partial class CreateEmployeeForm : Form
    {
        public CreateEmployeeForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            int age = int.Parse(textBox2.Text.Trim());
            string position = textBox3.Text.Trim();
            string department = textBox4.Text.Trim();

            string connectionString =
                @"Data Source=LAPTOP-MUQ2LAHR\SQL22;
          Initial Catalog=LunchManagementSystem;
          User ID=sa;
          Password=123";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Employees (Name, Age, Position, Department)
                         VALUES (@Name, @Age, @Position, @Department)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Position", position);
                    cmd.Parameters.AddWithValue("@Department", department);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Employee inserted successfully");


    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
