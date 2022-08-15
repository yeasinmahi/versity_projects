using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private xmlWriter xml = new xmlWriter();
        private About aboutForm;
        private Instruction instructionForm;
        ButtonTextChanger ysn;
        Button[] btnArr;
        Button sendBt;
        Label lb;
        bool sendBo= false;
        public Form1()
        {
            InitializeComponent();
            btnArr = new Button[9] { this.button1, this.button2, this.button3, this.button4, this.button5, this.button6, this.button7, this.button8, this.button9 };

            lb = label1;
            lb.Text = "Player 1";
            
            foreach (Button b in btnArr)
            {
                b.BackColor =Color.LightSlateGray;
            }
            ysn = new ButtonTextChanger(btnArr);
        }

        private void action(int btnNum)
        {
            if (btnArr[btnNum].BackColor == Color.LightSlateGray)
            {
                sendBt = btnArr[btnNum];
                sendBo = ysn.degn(sendBt, sendBo, lb);
                ysn.win();
                btnArr[btnNum].BackColor = Color.SlateGray;
            }
        }
                    
        private void button1_Click(object sender, EventArgs e)
        {
            action(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            action(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            action(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            action(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            action(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            action(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            action(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            action(7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            action(8);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            reset();   
        }
        private void reset()
        {
            foreach (Button bt in btnArr)
            {
                bt.BackColor = Color.LightSlateGray;
                bt.Text = "";
                sendBo = false;
                lb.Text = "Player 1";
            }
        }
        
       /* private void Form1_Resize(object sender, EventArgs e)
        {
            FormH = this.Size.Height - form_current_height;
            FormW = this.Size.Width - form_current_width;
            form_current_width = this.Size.Width;
            form_current_height = this.Size.Height;

            resize_panel();
            foreach(Button b in btnArr)
            {
                resize(b);
            }
        }

        private void resize(Button bt)
        {
            int btnW = bt.Size.Width + (int)(FormW / 25);
            bt.Size = new System.Drawing.Size(btnW, btnW);
        }
        private void resize_panel()
        {
            label1.Size = new System.Drawing.Size(label1.Size.Width + FormW / 2, label1.Size.Height + FormH / 2);
            button10.Size = new System.Drawing.Size(button10.Size.Width + FormW / 16, button10.Size.Height + FormH / 20);
            panel1.Size = new System.Drawing.Size(panel1.Size.Width + FormW / 10, panel1.Size.Height + FormH / 3);
        }*/

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm = new About();
            aboutForm.Show();
        }

        private void instructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            instructionForm = new Instruction();
            instructionForm.Show();
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            onToolStripMenuItem.Checked = !onToolStripMenuItem.Checked;
            offToolStripMenuItem.Checked = !onToolStripMenuItem.Checked;
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            onToolStripMenuItem.Checked = !onToolStripMenuItem.Checked;
            offToolStripMenuItem.Checked = !offToolStripMenuItem.Checked;
        }
       
    }
}
