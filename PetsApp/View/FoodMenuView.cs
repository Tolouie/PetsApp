using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsApp.View
{
    public partial class FoodMenuView : Form
    {
        public string Food { get; set; }

        public FoodMenuView()
        {
            InitializeComponent();
        }

        private void baconSnackBtn_Click(object sender, EventArgs e)
        { 
            this.Food = "Bacon Snack";
            this.Visible = false;
        }

        private void dryDogFoodBtn_Click(object sender, EventArgs e)
        {
            this.Food = "Dry Dog Food";
            this.Visible = false;
        }

        private void tunaBtn_Click(object sender, EventArgs e)
        {
            this.Food = "Tuna";
            this.Visible = false;
        }

        private void dryCatFoodBtn_Click(object sender, EventArgs e)
        {
            this.Food = "Dry Cat Food";
            this.Visible = false;
        }

        private void waterBtn_Click(object sender, EventArgs e)
        {
            this.Food = "Water";
            this.Visible = false;
        }

        private void plantFoodBtn_Click(object sender, EventArgs e)
        {
            this.Food = "Plant Food";
            this.Visible = false;
        }

        private void fishFoodBtn_Click(object sender, EventArgs e)
        {
            this.Food = "Fish Food";
            this.Visible = false;
        }
    }
}
