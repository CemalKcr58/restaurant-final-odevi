using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranrFinal
{
    public partial class Masalar : Form
    {
        public Masalar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Siparis s1 = new Siparis(); 
            s1.Text = "MASA 1";          
            pictureBox1.BackColor = Color.Red;
            s1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Siparis s2 = new Siparis(); 
            s2.Text = "MASA 2";          
            pictureBox2.BackColor = Color.Red;
            s2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Siparis s3 = new Siparis(); 
            s3.Text = "MASA 3";          
            pictureBox3.BackColor = Color.Red;
            s3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Siparis s4 = new Siparis(); 
            s4.Text = "MASA 4";          
            pictureBox4.BackColor = Color.Red;
            s4.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Siparis s5 = new Siparis(); 
            s5.Text = "MASA 5";          
            pictureBox5.BackColor = Color.Red;
            s5.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Siparis s6 = new Siparis(); 
            s6.Text = "MASA 6";          
            pictureBox6.BackColor = Color.Red;
            s6.Show();
        }
    }
}
