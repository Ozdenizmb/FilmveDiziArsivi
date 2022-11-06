using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _102.ORN.Film_Arsivi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminSayfasi Admn = new AdminSayfasi();
            Admn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciPaneli klnc = new KullaniciPaneli();
            klnc.Show();
        }
    }
}
