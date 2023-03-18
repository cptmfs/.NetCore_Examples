﻿using System;
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

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();    
            frm.Show();
            this.Close();
        }


        private void btnGiris_Click(object sender, EventArgs e)
        {
            userId = tbxUserId.Text;
            userPass = tbxPass.Text;
            dataBase dataBase = new dataBase();
            dataBase.UserControl(userId, userPass, this);
            this.Close();
        }
    }
}
