using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace rehberProjesi_Dosya
{
    public partial class RehbereEkle : Form
    {
        public RehbereEkle()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if(txtBx_Ad.Text.Length > 0 && txtBx_Soyad.Text.Length > 0 && txtBx_Tel.Text.Length > 0)
            {
                try
                {
                    StreamWriter rehberYazici = new StreamWriter(".\\rehber.ntp2", true);
                    rehberYazici.WriteLine(txtBx_Ad.Text+"#"+txtBx_Soyad.Text+"#"+txtBx_Tel.Text);
                    rehberYazici.Close();
                    DialogResult sonuc = MessageBox.Show("Yeni Kişi Eklemek İster Misiniz", "Başarılı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.OK)
                    {
                        txtBx_Ad.Text = "";
                        txtBx_Soyad.Text = "";
                        txtBx_Tel.Text = "";
                    }
                    else
                    {
                        Close();
                    }

                }
                catch (Exception hata)
                {
                    MessageBox.Show("Ekleme Yapılırken Bir Hata Oluştu = " + hata.Message, "HATAAAA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Ad Soyad Telefon Kısımları Boş Olamaz ", " Hata ", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btn_Vazgec_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
