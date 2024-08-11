using Engine1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        public SuperAdventure()
        {
            InitializeComponent();

            Location location = new Location(1, "Home", "This is your house");

            // Creating a player object 
            _player = new Player(10,10,20,0,1);

            // Adding the values to the screen for the player to see
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {

        }

        private void btnNorth_Click(object sender, EventArgs e)
        {

        }

        private void btnEast_Click(object sender, EventArgs e)
        {

        }

        private void btnSouth_Click(object sender, EventArgs e)
        {

        }

        private void btnWest_Click(object sender, EventArgs e)
        {

        }
    }
}
