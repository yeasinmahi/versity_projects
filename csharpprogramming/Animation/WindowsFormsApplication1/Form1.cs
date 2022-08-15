using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Bee bee = null;
        public Form1()
        {
            InitializeComponent();
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bee == null)
            {
                bee = new Bee()
                {
                    Location = pictureBox1.Location,
                    destination = pictureBox2.Location
                };
                Controls.Add(bee);
            }
            else
            {
                Controls.Remove(bee);
                bee = null;
            }
           
        }
    }
}
