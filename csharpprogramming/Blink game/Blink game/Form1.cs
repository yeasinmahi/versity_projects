using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blink_game
{
    public partial class Form1 : Form
    {
        Button[] btnArr;
        Timer timer;
        Random rand;
        int countT = 0, countS =0, mahi=0;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "Score";
            label2.Text = "Total";
            label3.Text = "0";
            label4.Text = "0";
            rand = new Random();
            timer = new Timer();
            timer.Interval = 1000;
            button7.BackColor = Color.Plum;
            timer.Tick += new EventHandler(timer_Tick);
            btnArr = new Button[6] {this.button1, this.button2,this.button3,this.button4,this.button5,this.button6 };
            foreach (Button bt in btnArr)
            {
                bt.BackColor = Color.Red;
            }
            
        }
        void timer_Tick(object sender, EventArgs e)
        {
            mahi = 0;
            if (countT < 20)
            {
                countT++;
                foreach (Button bt in btnArr)
                {
                    bt.BackColor = Color.Red;
                    bt.Text = "";
                }
                int tmp = rand.Next(1, 7);
                switch (tmp)
                {

                    case 1:
                        button1.Text = "☺";
                        button1.BackColor = Color.LightGreen;
                        mahi = 1;
                        break;
                    case 2:
                        button2.Text = "☺";
                        button2.BackColor = Color.LightGreen;
                        mahi = 2;
                        break;
                    case 3:
                        button3.Text = "☺";
                        button3.BackColor = Color.LightGreen;
                        mahi = 3;
                        break;
                    case 4:
                        button4.Text = "☺";
                        button4.BackColor = Color.LightGreen;
                        mahi = 4;
                        break;
                    case 5:
                        button5.Text = "☺";
                        button5.BackColor = Color.LightGreen;
                        mahi = 5;
                        break;
                    case 6:
                        button6.Text = "☺";
                        button6.BackColor = Color.LightGreen;
                        mahi = 6;
                        break;
                }
                
                label4.Text = Convert.ToString(countT);
            }
            else
            {
                timer.Enabled = false;
                timer.Stop();
                foreach (Button bt in btnArr)
                {
                    bt.BackColor = Color.Red;
                    bt.Text = "";
                } MessageBox.Show("Your Final Score Is "+Convert.ToString(countS));
                countS = 0;
                countT = 0;
            }

        }
        

        private void play_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(countS);
            timer.Enabled = true;
            //timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mahi == 1)
            {
                countS += 1;
                label3.Text = Convert.ToString(countS);
                mahi = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mahi == 2)
            {
                countS += 1;
                label3.Text = Convert.ToString(countS);
                mahi = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mahi == 3)
            {
                countS += 1;
                label3.Text = Convert.ToString(countS);
                mahi = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mahi == 4)
            {
                countS += 1;
                label3.Text = Convert.ToString(countS);
                mahi = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (mahi == 5)
            {
                countS += 1;
                label3.Text = Convert.ToString(countS);
                mahi = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (mahi == 6)
            {
                countS += 1;
                label3.Text = Convert.ToString(countS);
                mahi = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Plum;
            button8.BackColor = Color.PowderBlue;
            button9.BackColor = Color.PowderBlue;
            timer.Interval = 1000;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Plum;
            button7.BackColor = Color.PowderBlue;
            button9.BackColor = Color.PowderBlue;
            timer.Interval = 500;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Plum;
            button8.BackColor = Color.PowderBlue;
            button7.BackColor = Color.PowderBlue;
            timer.Interval = 350;
        }
    }
}
