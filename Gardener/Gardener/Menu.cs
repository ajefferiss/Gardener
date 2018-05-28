using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gardener
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAddPlant_Click(object sender, EventArgs e)
        {
            AddPlant addPlant = new AddPlant();
            addPlant.Show();
        }

        private void btnListPlants_Click(object sender, EventArgs e)
        {
            ListPlants listPlants = new ListPlants();
            listPlants.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Users.register register = new Users.register();
            register.Show();
        }
    }
}
