using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement
{
    public partial class HomePageMDIParent : Form
    {
        private int childFormNumber = 0;

        public HomePageMDIParent()
        {
            InitializeComponent();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
            user.Show();
        }
    }
}
