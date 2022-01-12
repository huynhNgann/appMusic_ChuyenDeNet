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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        int startPos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPos += 1;
            myProgress.Value = startPos;
            lblPhamtram.Text = startPos + "%";
            if (myProgress.Value == 100)
            {
                myProgress.Value = 0;
                timer1.Stop();
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.reportViewer1.RefreshReport();
        }
    }
}
