using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Race
{
    public partial class Form1 : Form
    {
        Dog[] dogArr;
        Timer timer;
        Guy[] guyArr;
        Guy selectedGuy;
        Bet bet;
        int count=0;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 30;
            timer.Tick += new EventHandler(timer_Tick);
            dogArr = new Dog[4];
            dogArr[0] = new Dog(pictureBox1);
            dogArr[1] = new Dog(pictureBox2);
            dogArr[2] = new Dog(pictureBox3);
            dogArr[3] = new Dog(pictureBox4);
            guyArr = new Guy[3];
            guyArr[0] = new Guy("Joe", radioButton1, 100, label5);
            guyArr[1] = new Guy("Bob", radioButton2, 90, label6);
            guyArr[2] = new Guy("AL", radioButton3, 220, label7);
            selectedGuy = guyArr[0];
            bet = new Bet();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            int dogNo = 1;
            foreach (Dog d in dogArr)
            {
                if (d.Run())
                {
                    timer.Stop();
                    timer.Enabled = false;
                    MessageBox.Show(dogNo.ToString("Dog no "+dogNo+" is winner"));

                    if (guyArr[0].dogn == dogNo)
                    {
                        guyArr[0].Cash += 2*guyArr[0].amountn;
                        //MessageBox.Show(dogNo.ToString("Congratulation!!!\nDog no " + dogNo + " is winner\nYou got "+2*guyArr[0].amountn+" taka price money."));
                        radioButton1.Text = guyArr[0].UpdateLabels();
                    }
                    else
                    {
                        guyArr[0].Cash -= guyArr[0].amountn;
                        radioButton1.Text = guyArr[0].UpdateLabels();
                    }
                    if (guyArr[1].dogn == dogNo)
                    {
                        guyArr[1].Cash += 2 * guyArr[1].amountn;
                       // MessageBox.Show(dogNo.ToString("Congratulation!!!\nDog no " + dogNo + " is winner\nYou got " + 2 * guyArr[1].amountn + " taka price money."));
                        radioButton2.Text = guyArr[1].UpdateLabels();
                    }
                    else
                    {
                        guyArr[1].Cash -= guyArr[1].amountn;
                        radioButton2.Text = guyArr[1].UpdateLabels();
                    }
                    if (guyArr[2].dogn == dogNo)
                    {
                        guyArr[2].Cash += 2 * guyArr[2].amountn;
                       // MessageBox.Show(dogNo.ToString("Congratulation!!!\nDog no " + dogNo + " is winner\nYou got " + 2 * guyArr[2].amountn + " taka price money."));
                        radioButton3.Text = guyArr[2].UpdateLabels();
                    }
                    else
                    {
                        guyArr[2].Cash -= guyArr[2].amountn;
                        radioButton3.Text = guyArr[2].UpdateLabels();
                    }
                    foreach(Guy g in guyArr)
                    {
                        g.ClearBet();
                    }
                    
                    break;
                }
               
               
               // this.Refresh();
                dogNo++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Dog d in dogArr)
            {
                d.TakeStartingPosition();
            }
            timer.Enabled = true;
            timer.Start();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            selectedGuy = guyArr[0];
            label2.Text = selectedGuy.Name;
            count = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            selectedGuy = guyArr[1];
            label2.Text = selectedGuy.Name;
            count = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            selectedGuy = guyArr[2];
            label2.Text = selectedGuy.Name;
            count = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(numericUpDown1.Value);
            int dog = Convert.ToInt32(numericUpDown2.Value);

            switch (count)
            {
                case 1:
                    guyArr[0].PlaceBet(amount,dog); 
                   // label5.Text = guyArr[0].UpdateLabels2();
                    radioButton1.Text = guyArr[0].UpdateLabels();
                    break;
                case 2:
                    guyArr[1].PlaceBet(amount,dog);
                   // label6.Text = guyArr[1].UpdateLabels2();
                    radioButton2.Text = guyArr[1].UpdateLabels();
                    break;
                case 3:
                    guyArr[2].PlaceBet(amount,dog);
                    //label7.Text = guyArr[2].UpdateLabels2();
                    radioButton3.Text = guyArr[2].UpdateLabels();
                    break;

            }

        }

    }
}
