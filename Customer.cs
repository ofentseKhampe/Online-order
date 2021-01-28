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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb).;Initial Catalog=OrderSystem;Integrated Security=True");//connecting to client

            //Insert logic
            con.Open();
            SqlCommand cmd = new SqlCommand(@"
INSERT INTO [dbo].[Customer]
           ([OrderNumber]
           ,[Date]
           ,[Description]
           ,[TotalAmount]
           ,[Customer])
     VALUES
           (<OrderNumber, int,>
           ,<Date, date,>
           ,<Description, varchar(50),>
           ,<TotalAmount, money,>
           ,<Customer, varchar(50),>)
GO", con);

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
