using System;
using System.Windows.Forms;

namespace DxBall2
{
    public partial class MainUi : Form
    {
        public MainUi()
        {
            InitializeComponent();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            GameUi gameUi = new GameUi {Visible = true};
            Visible = false;

        }

        private void instruction_Click(object sender, EventArgs e)
        {
            InstructionUi instructionUi = new InstructionUi();
            instructionUi.Visible = true;
            Visible = false;
        }

        private void about_Click(object sender, EventArgs e)
        {
            AboutUi aboutUi = new AboutUi();
            aboutUi.Visible = true;
            Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
