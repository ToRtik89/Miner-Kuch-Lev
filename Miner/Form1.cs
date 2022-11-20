using Miner.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void new_game_Click(object sender, EventArgs e)
        {
            Game formGame = new Game();
            formGame.ShowDialog();

            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
