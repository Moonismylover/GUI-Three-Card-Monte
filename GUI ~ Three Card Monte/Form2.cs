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
    public partial class FormEasy : Form
    {
        public FormEasy()
        {
            InitializeComponent();
        }

        private void lblcard_Click(object sender, EventArgs e)
        {
            lblcard.Text = "C\nH\nO\nO\nS\nE\n \nA\nC\nA\nR\nD";
        }
    }
}
