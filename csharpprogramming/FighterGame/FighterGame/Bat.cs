using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FighterGame
{
    class Bat  : Enemy
    {
        private PictureBox pic;
        private int moverate;
        private int range;

        public Bat(PictureBox pic)
        {
            this.pic = pic;
            this.moverate = 3;
            range = 20;
        }
        public override void Move(Point player)
        {
            Point p = pic.Location;
            int x = pic.Location.X;
            int y = pic.Location.Y;
            if (player.X < pic.Location.X)
            {
                x -= moverate;
            }
            else if (player.X > pic.Location.X)
            {
                x += moverate;
            }
            if (player.Y < pic.Location.Y)
            {
                y -= moverate;
            }
            else if (player.Y > pic.Location.Y)
            {
                y += moverate;
            }
            pic.Location = new Point(x, y);
        }
        public override bool Attack(Point player)
        {
            if (Math.Abs(player.X - pic.Location.X) <= range && Math.Abs(player.Y - pic.Location.Y) <= range)
                return true;
            else
                return false;
        }
    }
}
