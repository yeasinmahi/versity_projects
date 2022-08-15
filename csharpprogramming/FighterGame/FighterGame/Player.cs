using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FighterGame
{
    class Player
    {
        private PictureBox pic;
        private int moveRate;
        private int attackPoint;
        public Point currentPoint;
        public int life
        {
            get;
            set;
        }
        private int range;

        public Player(PictureBox pic)
        {
            this.pic = pic;
            moveRate = 6;
            currentPoint = pic.Location;

        }
        public void Move(Direction d,Rectangle rec)
        {
            pic.BringToFront();
            Point p;
            int tmp;
            switch (d)
            {
                case Direction.RIGHT:
                    if (pic.Location.X + moveRate <= rec.Right)
                    {
                        p = this.pic.Location;
                        tmp = p.X + moveRate;
                        this.pic.Location = new Point(tmp, p.Y);
                    }
                    break;
                case Direction.DOWN:
                    if (pic.Location.Y + moveRate <= rec.Bottom)
                    {
                        p = this.pic.Location;
                        tmp = p.Y + moveRate;
                        this.pic.Location = new Point(p.X, tmp);
                    }
                    break;
                case Direction.LEFT:
                    if (pic.Location.X - moveRate >= rec.Left)
                    {
                        p = this.pic.Location;
                        tmp = p.X - moveRate;
                        this.pic.Location = new Point(tmp, p.Y);
                    }
                    break;
                case Direction.UP:
                    if (pic.Location.Y - moveRate >= rec.Top)
                    {
                        p = this.pic.Location;
                        tmp = p.Y - moveRate;
                        this.pic.Location = new Point(p.X, tmp);
                    }
                    break;

            }
            currentPoint = pic.Location;
        }
    }
}
