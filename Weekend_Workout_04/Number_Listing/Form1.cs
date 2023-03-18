using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Listing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {
                cbx1.Items.Add(i);
            }
            cbx1.SelectedIndex = 0;
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx2.Items.Clear();
            for (int x = (int)cbx1.SelectedItem; x <= (int)cbx1.SelectedItem + 10; x++)
            {
                cbx2.Items.Add(x);
            }
            cbx2.SelectedIndex = 0;
        }
    }
}
