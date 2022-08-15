using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace button_move
{
    public partial class Form1 : Form
    {
        public Random rand;
        
        
        public Form1()
        {
            InitializeComponent();
            rand = new Random();
            
        }

        public void button1_MouseHover(object sender, EventArgs e)
        {
            act();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
        public void act()
        {
            Point p = button1.Location;
            int tmp = rand.Next(1, 4);
            switch (tmp)
            {
                case 1:
                    p.X += 30;
                    p.Y += 30;
                    break;
                case 2:
                    p.X += 30;
                    p.Y -= 30;
                    break;
                case 3:
                    p.X -= 30;
                    p.Y += 30;
                    break;
                case 4:
                    p.X -= 30;
                    p.Y -= 30;
                    break;
            }
            
            if (p.X < 20)
                p.X = 500;
            if (p.X > 520)
                p.X = 40;
            if (p.Y < 20)
                p.Y = 370;
            if (p.Y > 390)
                p.Y = 40;
            button1.Location = p;
        }
        public void area()
        {
            
        }

    }
}
