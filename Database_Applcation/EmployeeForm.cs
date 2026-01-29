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
    public partial class EmployeeForm : Form
    {
        SqlDataAdapter da;
        DataTable dt;

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string connectionString =
                @"Data Source=LAPTOP-MUQ2LAHR\SQL22;
              Initial Catalog=LunchManagementSystem;
              User ID=sa;
              Password=123";

            SqlConnection conn = new SqlConnection(connectionString);

            da = new SqlDataAdapter(
                "SELECT Id, Name, Age, Position, Department FROM Employees", conn);

            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            da.Update(dt);
            MessageBox.Show("Data updated successfully");
        }

        private void add_Btn_Click(object sender, EventArgs e)
        {
            CreateEmployeeForm frm = new CreateEmployeeForm();
            frm.Show();
        }
    }

}
