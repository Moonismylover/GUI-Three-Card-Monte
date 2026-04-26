using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using GUI___Three_Card_Monte.Properties;

namespace GUI___Three_Card_Monte
{
    public partial class FormHome : Form
    {
        SoundPlayer music;
        bool musicOn;

        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            music = new SoundPlayer(Resources.Music);
            music.PlayLooping();
        }

        private void btninstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Three Card Monte! \nThe goal of the game is to find the ACE amongst three given cards. \nClick on one of the three cards to make your guess. \nOnce you press PLAY, you will have to make a bet. Your bank balance is $500. \nIf you find the ACE, you win the bet, otherwise you lose!", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to quit?", "QUIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
            else
            {
                return;
            }


        }

        private void btnmusic_Click(object sender, EventArgs e)
        {
            if (musicOn)
            {
                music.Stop();
                musicOn = false;
            }
            else
            {
                music.PlayLooping();
                musicOn = true;
            }
        }

        private void btneasy_Click(object sender, EventArgs e)
        {
            FormEasy game = new FormEasy();
            game.Show();
            this.Hide();
        }

        private void btnmedium_Click(object sender, EventArgs e)
        {
            FormMedium game = new FormMedium();
            game.Show();
            this.Hide();
        }

        private void btnhard_Click(object sender, EventArgs e)
        {
            FormHard game = new FormHard();
            game.Show();
            this.Hide();
        }
    }
}

