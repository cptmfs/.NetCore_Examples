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
    public partial class BankMenu : Form
    {
        public BankMenu()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AccountMenu accountMenu = new AccountMenu();
            accountMenu.Show();
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            BankMenu bankMenu= new BankMenu();

            bankMenu.Close();
        }
    }
}
