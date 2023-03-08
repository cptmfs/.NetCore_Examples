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

namespace BankManagementWF
{
    public partial class AccountMenu : Form
    {
        SqlConnection connection;
        SqlCommand command;

        SqlDataAdapter adapter;
        public AccountMenu()
        {
            InitializeComponent();

        }
        public void HesapOzeti()
        {
            
            connection=new SqlConnection("Data source=(localdb)\\MSSQLLocalDB;initial catalog=bankDb;integrated security=true");
            connection.Open();
            adapter = new SqlDataAdapter("Select userName,accountType,accountNumber,cardNumber,balance From bankData where ID=" + connection);  //Select * from tabloadi id=)+id;
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dgwDetail.DataSource = tablo;   
            connection.Close();
        }

        private void AccountMenu_Load(object sender, EventArgs e)
        {
            dataBase data = new dataBase();

            //data.UserControl();
            HesapOzeti();
        }
    }
}
