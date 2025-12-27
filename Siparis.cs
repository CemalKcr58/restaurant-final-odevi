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
    public partial class Siparis : Form
    {
        int toplam = 0;
        public Siparis()
        {
            InitializeComponent();
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
           
            string urunler = "";
            foreach (var item in listBox1.Items)
            {
                urunler += item.ToString() + ", ";
            }

            
            string tamSatir = this.Text + " - Ürünler: " + urunler.TrimEnd(',', ' ') + " - Fiyat: " + lblToplam.Text;
            System.IO.File.AppendAllLines("siparis.txt", new[] { tamSatir });

            
            MessageBox.Show("Sipariş arşive eklendi!");
            listBox1.Items.Clear();
            lblToplam.Text = "TOPLAM: 0 TL"; 
            this.Close();

            if (toplam == 0)
            {
                MessageBox.Show("Ürün Seçmedin!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            MessageBox.Show("Sipariş Alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            toplam = 0;
            lblToplam.Text = "TOPLAM: 0TL";
            listBox1.Items.Clear();


            
            string satir = string.Format("{0} - Ürünler: {1} - Toplam: {2} TL", this.Text, string.Join(", ", listBox1.Items.Cast<string>()), lblToplam.Text);

            // Bu satırı dosyaya ekler
            System.IO.File.AppendAllLines("siparis.txt", new[] { satir });



        }

        private void chkLahmacun_CheckedChanged(object sender, EventArgs e)
        {
            int fiyat = 100;


            listBox1.Items.Add("Lahmacun" + fiyat + "TL");

            toplam += fiyat;
            lblToplam.Text = toplam + "TL";
        }

        private void chkPizza_CheckedChanged(object sender, EventArgs e)
        {
            int fiyat = 115;


            listBox1.Items.Add("Pizza" + fiyat + "TL");

            toplam += fiyat;
            lblToplam.Text = toplam + "TL";
        }

        private void chkAdana_CheckedChanged(object sender, EventArgs e)
        {
            int fiyat = 200;


            listBox1.Items.Add("Adana Kebap" + fiyat + "TL");

            toplam += fiyat;
            lblToplam.Text = toplam + "TL";
        }

        private void chkKebap_CheckedChanged(object sender, EventArgs e)
        {
            int fiyat = 185;


            listBox1.Items.Add("Şiş Kebap" + fiyat + "TL");

            toplam += fiyat;
            lblToplam.Text = toplam + "TL";
        }

        private void chkHamburger_CheckedChanged(object sender, EventArgs e)
        {
            int fiyat = 75;


            listBox1.Items.Add("Hamburger" + fiyat + "TL");

            toplam += fiyat;
            lblToplam.Text = toplam + "TL";
        }

        private void chkDurum_CheckedChanged(object sender, EventArgs e)
        {
            int fiyat = 90;


            listBox1.Items.Add("Dürüm" + fiyat + "TL");

            toplam += fiyat;
            lblToplam.Text = toplam + "TL";
        }

        private void chkAyran_CheckedChanged(object sender, EventArgs e)
        {
            int fiyat = 35;


            listBox1.Items.Add("Ayran" + fiyat + "TL");

            toplam += fiyat;
            lblToplam.Text = toplam + "TL";
        }

        private void chkKola_CheckedChanged(object sender, EventArgs e)
        {
            int fiyat = 40;


            listBox1.Items.Add("Kola" + fiyat + "TL");

            toplam += fiyat;
            lblToplam.Text = toplam + "TL";
        }

        private void chkCay_CheckedChanged(object sender, EventArgs e)
        {
            int fiyat = 10;


            listBox1.Items.Add("Çay" + fiyat + "TL");

            toplam += fiyat;
            lblToplam.Text = toplam + "TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            kyd gecmisEkranı = new kyd();

            
            string dosyaYolu = "siparis.txt";

            if (System.IO.File.Exists(dosyaYolu))
            {
                
                string[] veriler = System.IO.File.ReadAllLines(dosyaYolu);

                foreach (string satir in veriler)
                {
                    
                    gecmisEkranı.lstVeri.Items.Add(satir);
                }

                
                gecmisEkranı.Show();
            }
            else
            {
                MessageBox.Show("Henüz hiçbir sipariş kaydedilmemiş!");
            }
           
            string urunler = "";
            foreach (var item in listBox1.Items)
            {
                urunler += item.ToString() + ", ";
            }

            
            string tamSatir = this.Text + " - Ürünler: " + urunler.TrimEnd(',', ' ') + " - Toplam: " + lblToplam.Text;

            System.IO.File.AppendAllLines("siparis.txt", new[] { tamSatir });
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            DialogResult secenek = MessageBox.Show("Siparişi iptal etmek istediğinize emin misiniz?", "İptal Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (secenek == DialogResult.Yes)
            {
               
                listBox1.Items.Clear();
                lblToplam.Text = "TOPLAM: 0 TL";

                MessageBox.Show("Sipariş iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}
