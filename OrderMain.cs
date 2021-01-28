using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_order
{
    public partial class OrderMain : Form
    {
        

        public OrderMain()
        {
            InitializeComponent();
        }

        private void OrderMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            //MessageBox.Show("Logout ...thanl"MessageBoxIcon.Information);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order ord = new Order();
            ord.MdiParent = this;
            ord.Show();

        }
    }
 
   
}
