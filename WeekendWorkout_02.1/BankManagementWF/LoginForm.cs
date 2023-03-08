using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementWF
{
    public partial class LoginForm : Form
    {

        public string userId, userPass;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            tbxPass.PasswordChar = '*';
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            userId = tbxUserId.Text;
            userPass = tbxPass.Text;
            dataBase dataBase = new dataBase();
            dataBase.UserControl(userId, userPass, this);
            BankMenu bankMenu = new BankMenu();
            bankMenu.Show();
            this.Close();

            AccountMenu menu = new AccountMenu();
            menu.userId= this.userId;
            menu.ShowDialog();
        }
    }
}
