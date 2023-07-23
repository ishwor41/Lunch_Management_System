


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
            string userName = usernameTxtBox.Text;
            string pass = passwordTextBox.Text;
            String query = "select * from Users where User_ID = '"+userName+"' and password = '"+pass+"'";
        }
    }
}