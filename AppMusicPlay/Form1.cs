using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMusicPlay
{
    public partial class Form1 : Form
    {
        private MusicPlayer msplayer = new MusicPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            msplayer.Play();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            msplayer.Stop();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd=new OpenFileDialog())
            {
                ofd.Filter = "MP3 File|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    {
                        msplayer.open(ofd.FileName);
                    }

                }

            }
        }
    }
}
