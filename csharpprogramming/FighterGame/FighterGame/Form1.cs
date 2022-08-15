using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FighterGame
{
    public partial class Form1 : Form
    {
        Rectangle rec;
        Player player;
        
        Timer timer;
        Random rand;
        Enemy[] enemyArr;
       
        public Form1()
        {
            InitializeComponent();
            rec = new Rectangle(77, 57, 400, 137);
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            player = new Player(pictureBox1);
            enemyArr = new Enemy[2];
            enemyArr[0] = new Bat(pictureBox2);
            enemyArr[1] = new Ghost(pictureBox3);
            this.progressBar1.Value = 100;
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += timer_Tick;
            timer.Enabled = true;
            timer.Start();
            rand = new Random();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Enemy();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.Move(Direction.RIGHT,rec);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Move(Direction.LEFT,rec);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Move(Direction.DOWN,rec);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.Move(Direction.UP,rec);
        }
        private void Enemy()
        {
            int tmp = rand.Next(10);
            if (tmp > 6)
            {
                foreach (Enemy e in enemyArr)
                {
                    e.Move(player.currentPoint);
                    if (e.Attack(player.currentPoint))
                    {

                        if (progressBar1.Value - 10 >= 0)
                        {
                            this.progressBar1.Value -= 10;
                        }
                        else
                        {
                            timer.Stop();
                            timer.Enabled = false;
                            MessageBox.Show("You Die");
                        }
                    }
                }
            }
        }
    }
}
