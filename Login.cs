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

namespace Online_order
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Clear();
            txtUsername.Focus();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            //TO-DO: check login username & password

            SqlConnection con = new SqlConnection("Data Source=(localdb).;Initial Catalog=OrderSystem;Integrated Security=True");//connecting to client
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
                                                FROM [dbo].[Login] WHERE Username='admin'  and Password='admin@123'", con);

            

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                this.Hide();
                OrderMain main = new OrderMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1_Click(sender, e);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
