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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            cmbCustName.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb).;Initial Catalog=OrderSystem;Integrated Security=True");//connecting to client

            //Insert logic
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Order]
           ([ItemId]
           ,[Name]
           ,[Quantity]
           ,[Cost]
           ,[Total])
     VALUES
           (< ItemId, int,>
           ,< Name, varchar(50),>
           ,< Quantity, float,>
           ,< Cost, money,>
           ,< Total, money,>)", con);




            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbCustName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
