using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    class Sound
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Sound(String loc)
        {
            player.SoundLocation = loc;
        }
        public void backgroudMusic()
        {
            player.PlayLooping();
        }
        
        public void singleMusic()
        {
            player.Play();
        }

        public void MusicOff()
        {
            player.Stop();
        }
    }
}
