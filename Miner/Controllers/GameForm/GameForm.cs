using System.Windows.Forms;

namespace Miner.Controllers
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();

            FormsClass.InputUsernameForm = new InputUsernameForm();

            MapController.Init(this);
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormsClass.InputUsernameForm.Visible)
                return;

            FormsClass.MainForm.Show();
        }
    }
}
