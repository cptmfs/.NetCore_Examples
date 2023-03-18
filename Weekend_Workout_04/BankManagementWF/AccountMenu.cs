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
        public void BankStatement()
        {
            LoginForm loginForm = new LoginForm();
            connection = new SqlConnection(@"Data source=(localdb)\MSSQLLocalDB;initial catalog=bankDb;integrated security=true");
            connection.Open();
            adapter = new SqlDataAdapter("Select userName,accountType,accountNumber,cardNumber,balance From bankData where userId='" + userId + "'", connection);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dgwDetail.DataSource = tablo;

            connection.Close();
        }

        private void AccountMenu_Load(object sender, EventArgs e)
        {
            BankStatement();

        }


        private void btnDeposit_Click(object sender, EventArgs e)
        {
            int amount, euAmount, balance;
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            if (rdbTL.Checked)
            {
                amount = int.Parse(txtDeposit.Text);
                euAmount = amount / 20;
                command = new SqlCommand("Update bankData set balance=balance+@p1 where userId=@p2", connection);
                command.Parameters.AddWithValue("@p1", euAmount);
                command.Parameters.AddWithValue("@p2", userId);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("TL Deposit Transaction Successfully Completed (Converted to Euro)", "Deposit", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (rdbEuro.Checked)
            {
                amount = int.Parse(txtDeposit.Text);
                command = new SqlCommand("Update bankData set balance=balance+@p1 where userId=@p2", connection);
                command.Parameters.AddWithValue("@p1", amount);
                command.Parameters.AddWithValue("@p2", userId);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Euro Deposit Transaction Successfully Completed", "Deposit", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Please select the type of money for Deposit/Withdraw", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BankStatement();
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            int amount, euAmount, balance;
            balance = int.Parse(dgwDetail.CurrentRow.Cells[4].Value.ToString());

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            amount = int.Parse(txtWithdraw.Text);


            if (rdbTL2.Checked)
            {
                euAmount = amount / 20;
                if (balance >= euAmount)
                {
                    command = new SqlCommand("Update bankData set balance=balance-@p1 where userId=@p2", connection);
                    command.Parameters.AddWithValue("@p1", euAmount);
                    command.Parameters.AddWithValue("@p2", userId);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("TL Withdraw Transaction Successfully Completed (Converted to Euro)", "Withdraw", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    InsufficentBalance();
                }


            }
            else if (rdbEuro2.Checked)
            {
                if (balance >= amount)
                {
                    command = new SqlCommand("Update bankData set balance=balance-@p1 where userId=@p2", connection);
                    command.Parameters.AddWithValue("@p1", amount);
                    command.Parameters.AddWithValue("@p2", userId);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Euro Withdraw Transaction Successfully Completed", "Withdraw", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    InsufficentBalance();
                }

            }
            else
            {
                MessageBox.Show("Please select the type of money for Deposit/Withdraw", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            BankStatement();
        }

        private void dgwDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDeposit.Text = dgwDetail.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtWithdraw.Text = dgwDetail.Rows[e.RowIndex].Cells[4].Value.ToString();

        }
        private void InsufficentBalance()
        {
            MessageBox.Show("Insufficient Account Balance!", "Balance Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }
    }


}

