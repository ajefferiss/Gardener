using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Gardener.Users
{
    public partial class register : Form
    {
               
        public register()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbUserName.TextLength < 3)
            {
                MessageBox.Show("Username to short 3 characters mimumin.");
                tbUserName.Text = "";
            }
            else
            {
                string Path = @"D:\Gardener\gardening.db";
                SQLiteConnection Connection = new SQLiteConnection("Data Source = " + Path + "; Version=3;");

                Connection.Open();

                String selectcount = "select count (*) from user where username = '" + tbUserName.Text + "'";

                SQLiteCommand cmd = new SQLiteCommand(selectcount, Connection);
                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                
                if(count >0)
                {
                    MessageBox.Show("Username already in use");
                    tbUserName.Text = "";
                }
                else
                {
                    string UserName = tbUserName.Text;
                    adduser(UserName);
                } 
            }
        }
        private void adduser(string userName)
        {
            string Path = @"D:\Gardener\gardening.db";
            SQLiteConnection Connection = new SQLiteConnection("Data Source = " + Path + "; Version=3;");
            String Insert = "Insert into user (username) values('" + userName + "')";
            SQLiteCommand Qeury = new SQLiteCommand(Insert, Connection);

            try
            {
                Connection.Open();
                Qeury.ExecuteNonQuery();
                Connection.Clone();
                createUserTable(userName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("'" + ex + "'");
            }
        }

        private void createUserTable(string userName)
        {
            string Path = @"D:\Gardener\userdata.db";
            SQLiteConnection Connection = new SQLiteConnection("Data Source = " + Path + "; Version=3;");

            string table = "create table '" + userName + "' (id int, date varchar(255), posts varchar(255), journal varchar(255), plants varchar(255), jobs varchar(255))";

            SQLiteCommand CreateTable = new SQLiteCommand(table, Connection);

            try
            {
                Connection.Open();
                CreateTable.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("'"+ex+"'");
            }
        }
    }
}
