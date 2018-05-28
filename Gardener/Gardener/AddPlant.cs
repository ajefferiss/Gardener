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
    public partial class AddPlant : Form
    {
        public AddPlant()
        {
            InitializeComponent();
        }

        private void btnAddPlant_Click(object sender, EventArgs e)
        {
            string Path = @"D:\Gardener\gardening.db";
            SQLiteConnection Connection = new SQLiteConnection("Data Source = " + Path + "; Version=3;");
            String Insert = "Insert into plants(Name, Species, Description, SowingTime) values('" + tbName.Text + "','" + tbSpecies.Text + "','" + tbDescription + "','" + tbSowStart + "' - '" + tbSowEnd + "')";
            SQLiteCommand Qeury = new SQLiteCommand(Insert, Connection);
            
            try
            {
                Connection.Open();
                Qeury.ExecuteNonQuery();
                Connection.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show("'"+ex+"'");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
