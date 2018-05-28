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
    public partial class PlantInfo : Form
    {
     
        public PlantInfo()
        {
            InitializeComponent();
            LoadPlantInfo();
        }
        private void LoadPlantInfo()
        {
            string name, species;
            name = ListPlants.passthrough[0].ToString();
            species = ListPlants.passthrough[1].ToString();

            lbltest1.Text = name;
            label2.Text = "(" + species + ")";
        }

    }
}
