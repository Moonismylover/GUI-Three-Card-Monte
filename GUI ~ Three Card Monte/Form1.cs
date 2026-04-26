using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI___Three_Card_Monte
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

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

        }
    }
}

