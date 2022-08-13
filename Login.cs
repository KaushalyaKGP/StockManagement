using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace StockManagement
{ 
    
    public partial class LoginForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\3rd Year Project\C#\StockManagement\StockManagement.mdf;Integrated Security=True");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            int UPTest = 0;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(@"SELECT * FROM [UserRegistration] WHERE username = '"+loginUsernameTextBox.Text+"' AND password= '"+loginPasswordTextBox.Text+"'",connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            UPTest = Convert.ToInt32(dataTable.Rows.Count.ToString());
            if(UPTest == 0)
            {
                MessageBox.Show("Username & Password does not match.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                this.Hide();
                HomePageMDIParent mDI = new HomePageMDIParent();
                mDI.Show();
            }


        }

    }
}
