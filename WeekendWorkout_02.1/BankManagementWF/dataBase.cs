using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using BankManagementWF.Entities;

namespace BankManagementWF
{
    public class dataBase
    {
        SqlConnection connection = new SqlConnection(@"Data source=(localdb)\MSSQLLocalDB;initial catalog=bankDb;integrated security=true");
        SqlCommand command;

        SqlDataReader reader;
        public int Id = 0;
        public void UserControl(string _user, string _pass, Form frm1)
        {
             
            command = new SqlCommand("Select *From bankData where userId='" + _user + "'and userPass='" + _pass + "'", connection);
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                
                MessageBox.Show("Giriş Başarılı", "Hesap İşlemlerine Geçebilirsiniz.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm loginForm = new LoginForm();
                frm1.Hide();
                loginForm.Show();

                Id = reader.GetInt32(0);
            }
            else
            {
                frm1.BackColor = Color.Red;
                MessageBox.Show("Hatalı Giriş!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frm1.BackColor = Color.White;
            }
            connection.Close();
            command.Dispose();

        }

        public void Bankstatement()
        {

        }
    }
}
