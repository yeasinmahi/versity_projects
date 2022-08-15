using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace TicTacToe
{
    class xmlWriter
    {
        XmlDocument doc = new XmlDocument();
        XmlNode mynode;
        Sound sound = new Sound("location");
        public xmlWriter()
        {
            
            
        }
        public bool check()
        {
            doc.Load("Config.xml");
            mynode = doc.SelectSingleNode("Sound/sound");
            string snd = mynode.InnerText;
            doc.Save("Config.xml");
            if ("1".Equals(snd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SoundOnOff()
        {
            if (check())
            {
                sound.backgroudMusic();
            }
            else
            {
                sound.MusicOff();
            }
            
        }
    }
}
