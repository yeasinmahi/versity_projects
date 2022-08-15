using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Bee : PictureBox 
    {
        private const int moveRate = 3;
        public Point destination;
        private Point location;
        Timer timer;
        private int tmp = 0;

        public Bee()
        {
            BackgroundImage = Properties.Resources.Bee_animation_1;
            BackgroundImageLayout = ImageLayout.Zoom;
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = true;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            
            tmp++;
            switch (tmp)
            {
                case 1:
                    BackgroundImage = Properties.Resources.Bee_animation_1;
                    break;
                case 2:
                    BackgroundImage = Properties.Resources.Bee_animation_2;
                    break;
                case 3:
                    BackgroundImage = Properties.Resources.Bee_animation_3;
                    break;
                case 4:
                    BackgroundImage = Properties.Resources.Bee_animation_4;
                    break;
                default:
                    BackgroundImage = Properties.Resources.Bee_animation_1;
                    tmp = 0;
                    break;
            }
            location = Location;
            BringToFront();
            MoveToFlower();

        }
        private void MoveToFlower()
        {
            if (Math.Abs(destination.X - Location.X) <= moveRate && Math.Abs(destination.Y - Location.Y) <= moveRate)
            {
                timer.Stop();
                timer.Enabled = false;
            }
            else
            {
                if (destination.X > Location.X)
                    location.X += moveRate;
                else if (destination.X < Location.X)
                    location.X -= moveRate;
                if (destination.Y > Location.Y)
                    location.Y += moveRate;
                else if (destination.Y < Location.Y)
                    location.Y -= moveRate;
            }
            Location = location;
        }
        protected override void Dispose(bool disposing)
        {
            timer.Stop();
            timer.Enabled = false;
        }
    }
}
