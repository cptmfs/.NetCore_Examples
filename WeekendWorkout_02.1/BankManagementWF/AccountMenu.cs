using BankManagementWF.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankManagementWF
{
    public partial class AccountMenu : Form
    {
        public string userId;

        SqlConnection connection;
        SqlCommand command;

        SqlDataAdapter adapter;
        public AccountMenu()
        {
            InitializeComponent();

        }
        public void HesapOzeti()
        {
            LoginForm loginForm = new LoginForm();
            connection =new SqlConnection("Data source=(localdb)\\MSSQLLocalDB;initial catalog=bankDb;integrated security=true");
            connection.Open();
            adapter = new SqlDataAdapter("Select *From bankData",connection);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dgwDetail.DataSource = tablo;

            connection.Close();
        }

        private void AccountMenu_Load(object sender, EventArgs e)
        {
            HesapOzeti();
        }

        private void tbxDeposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            int balance = 0;
            dataBase db = new dataBase();
            Users users = new Users();

            if (db.Id==1)
            {
                users.balance = balance;
            }
            int tlAmount, euAmount;
            tlAmount = Convert.ToInt32(tbxDeposit.TabIndex);
            euAmount = tlAmount / 20;
            balance += euAmount;    
            
        }

        private void dgwDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxDeposit.Text= dgwDetail.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbxWithdraw.Text = dgwDetail.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
