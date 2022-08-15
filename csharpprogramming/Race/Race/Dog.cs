using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Race
{

    class Dog
    {
        public int StartingPosition; // Where my PictureBox starts 
        public int RacetrackLength; // How long the racetrack is 
        public PictureBox MyPictureBox = null; // My PictureBox object 
        public int Location = 0; // My Location on the racetrack 
        public Random Randomizer; // An instance of Random 

        public Dog(PictureBox pic)
        {
            this.MyPictureBox = pic;
            this.StartingPosition = 30;
            this.RacetrackLength = 481;
        }
        public bool Run()
        {
            Randomizer = new Random();
            int tmp = Randomizer.Next(1, 10);
            Point p = MyPictureBox.Location;
            p.X += tmp;
            MyPictureBox.Location = p;
            if (p.X >= RacetrackLength)
                return true;
            else
                return false;
        }
        public void TakeStartingPosition()
        {
            // Reset my location to the start line 
            Point p = MyPictureBox.Location;
            p.X = StartingPosition;
            MyPictureBox.Location = p;
        }
    } 
}
