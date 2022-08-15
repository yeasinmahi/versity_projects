using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DxBall2
{
    public partial class InstructionUi : Form
    {
        public InstructionUi()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainUi formGame = new MainUi();
            formGame.Visible = true;
            Visible = false;
            Close();
        }

    }
}
