using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestoranrFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btbGirisYap_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre kontrolü (Opsiyonel)
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (kullaniciAdi == "admin" && sifre == "1234")
            {
                // Form2'den bir nesne oluşturuyoruz
                Masalar masalarFormu = new Masalar();

                // Form2'yi göster
                masalarFormu.Show();

                // Mevcut formu (Form1) gizle
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }
    }
}
