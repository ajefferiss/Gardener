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
    public partial class PlantInfo : Form
    {
        public PlantInfo()
        {
            InitializeComponent();
        }
        
        public void gatherinfo(string name, string species)
        {
            // Need to make this Path a const somewhere, or config item...it really should live in a user writable directory
            // like:
            //     var dirPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Gardener");
            //     var filePath = Path.Combine(dirPath, "gardening.db");
            //
            string Path = @"D:\Gardener\gardening.db";
            SQLiteConnection Connection = new SQLiteConnection("Data Source = " + Path + "; Version=3;");
            string select = "select * from plants where name='" + name + "' and species='" + species + "';";

            using (SQLiteConnection connection = new SQLiteConnection(Connection))
            {
                SQLiteCommand command = new SQLiteCommand(select, connection);
                connection.Open();

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    IDataRecord data = (IDataRecord)reader;
                    lbltest1.Text = name;
                    label2.Text = species;
                }
            }
        }
    }
}
