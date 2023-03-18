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
            connection.Open();
            //command = new SqlCommand("Select * From bankData where userId='" + _user + "'and userPass='" + _pass + "'", connection);
            command = new SqlCommand("Select * From bankData where userId=@p1 and userPass=@p2", connection);
            command.Parameters.AddWithValue("@p1", _user);
            command.Parameters.AddWithValue("@p2", _pass);
            reader = command.ExecuteReader();
            if (reader.Read())
            {

                MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Id = reader.GetInt32(0);
                BankMenu bmenu= new BankMenu();
                bmenu.userId = _user;
                bmenu.Show();
            }
            else
            {
                frm1.BackColor = Color.Red;
                MessageBox.Show("Login Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frm1.BackColor = Color.White;
                Form1 fr = new Form1();
                fr.Show();
                
            }
            connection.Close();
            command.Dispose();

        }

    }
}
