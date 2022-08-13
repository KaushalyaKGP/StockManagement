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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void userRegistrationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userRegistrationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stockManagementDataSet);

        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockManagementDataSet.UserRegistration' table. You can move, or remove it, as needed.
            this.userRegistrationTableAdapter.Fill(this.stockManagementDataSet.UserRegistration);

        }
    }
}
