using Miner.Controllers;
using System;
using System.Windows.Forms;

namespace Miner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void new_game_Click(object sender, EventArgs e)
        {
            FormsClass.GameForm = new GameForm();

            Hide();
            FormsClass.GameForm.ShowDialog();
        }

        private void leadersButton_Click(object sender, EventArgs e)
        {

            Hide();
            FormsClass.LeadersForm = new LeadersForm();
            FormsClass.LeadersForm.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
