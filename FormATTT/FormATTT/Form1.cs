using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormATTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ceasarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caesar frm = new Caesar();
            frm.Show();
        }

        private void thayThếĐơnBảngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thaythe frm = new Thaythe ();
            frm.Show();
        }

        private void playfairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Playfair frm = new Playfair();
            frm.Show();
        }

        private void hoánVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoanvi frm = new Hoanvi();
            frm.Show();
        }

        private void vigenereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vigenere frm = new Vigenere();
            frm.Show();
        }

        private void affineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affine frm = new Affine();
            frm.Show();
        }

        private void hillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hill frm = new Hill();
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RSA frm = new RSA();
            frm.Show();
        }

        private void diffieHellmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diffie_Hellman frm = new Diffie_Hellman();
            frm.Show();
        }
    }
}
