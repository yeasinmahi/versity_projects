using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace FighterGame
{
    abstract class Enemy
    {
        public abstract void Move(Point p);
        public abstract bool Attack(Point p);
    }
}
