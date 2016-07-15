using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EletricShopManagerUI
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public static int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 10)
            {
                this.Dispose(false);

                login lgn = new login();

                lgn.Show();
            }
        }

        private void start_Load(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
