using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FighterGame
{
    class Ghost : Enemy 
    {
        private PictureBox pic;
        private int moverate;
        private int range;

        public Ghost(PictureBox pic)
        {
            this.pic = pic;
            this.moverate = 5;
            range = 40;
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
