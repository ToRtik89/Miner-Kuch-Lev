using System.IO;
using System.Windows.Forms;

namespace Miner.Controllers
{
    public partial class InputUsernameForm : Form
    {
        private int score = 0;

        private string name;

        public int Score
        {
            set { score = value; }

            get { return score; }
        }

        public string Name
        {
            private set { name = value; }

            get { return name; }
        }

        public InputUsernameForm()
        {
            InitializeComponent();
        }

        private void submitNameButton_Click(object sender, System.EventArgs e)
        {

            name = inputNameTextBox.Text;

            if (name == "")
            {
                MessageBox.Show("Вы не ввели имя!");
                return;
            }

            WriteLeaderBoardUser();

            FormsClass.InputUsernameForm.Hide();
            FormsClass.MainForm.Show();

        }

        private async void WriteLeaderBoardUser()
        {
            string path = "leaders.txt";

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                await writer.WriteLineAsync($"{name};{score}");
            }
        }

        private void InputUsernameForm_FormClosed(object sender, FormClosedEventArgs e) => FormsClass.MainForm.Show();
    }
}
