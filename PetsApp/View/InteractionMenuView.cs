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
    public partial class InteractionMenuView : Form
    {
        public string Interaction { get; set; }
        public InteractionMenuView()
        {
            InitializeComponent();
        }

        private void petBtn_Click(object sender, EventArgs e)
        {
            this.Interaction = "Pet";
            this.Visible = false;
        }

        private void rubBellyBtn_Click(object sender, EventArgs e)
        {
            this.Interaction = "Rub Belly";
            this.Visible = false;
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            this.Interaction = "Play";
            this.Visible = false;
        }

        private void ignoreBtn_Click(object sender, EventArgs e)
        {
            this.Interaction = "Ignore";
            this.Visible = false;
        }

        private void scoldBtn_Click(object sender, EventArgs e)
        {
            this.Interaction = "Scold";
            this.Visible = false;
        }

        private void playMusicBtn_Click(object sender, EventArgs e)
        {
            this.Interaction = "Play Music";
            this.Visible = false;
        }

        private void talkToThemBtn_Click(object sender, EventArgs e)
        {
            this.Interaction = "Talk to Them";
            this.Visible = false;
        }

        private void tapOnGlassBtn_Click(object sender, EventArgs e)
        {
            this.Interaction = "Tap on Glass";
            this.Visible = false;
        }
    }
}
