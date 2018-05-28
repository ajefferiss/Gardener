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

namespace Gardener
{
    public partial class ListPlants : Form
    {
        public static string[] passthrough;

        public ListPlants()
        {
            InitializeComponent();
            loadlist();
        }


        private void loadlist()
        {
            string Path = @"D:\Gardener\gardening.db";
            SQLiteConnection Connection = new SQLiteConnection("Data Source = " + Path + "; Version=3;");
            string select = "select * from plants";

            using (SQLiteConnection connection = new SQLiteConnection(Connection))
            {
                SQLiteCommand command = new SQLiteCommand(select, connection);
                connection.Open();

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    showlist((IDataRecord)reader);
                }
            }
        }
        private void showlist(IDataRecord record)
        {
            listBox1.Items.Add(record[1] + "-" + record[2]);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //strings the selected listbox items name 
            string selected = listBox1.SelectedItem.ToString();
            passthrough = selected.Split('-');             

            PlantInfo plantInfo = new PlantInfo();
            plantInfo.Show();

        

        }
       
    }
}
        
