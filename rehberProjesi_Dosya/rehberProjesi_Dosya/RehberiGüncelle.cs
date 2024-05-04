using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rehberProjesi_Dosya
{
    public partial class RehberiGüncelle : Form
    {
        public RehberiGüncelle()
        {
            InitializeComponent();
        }

        string[,] rehberListesi = new string[100, 3];
        private void RehberiGüncelle_Load(object sender, EventArgs e)
        {
            if (File.Exists(".\\rehber.ntp2") == true)
            {

                try
                {
                    StreamReader rehberOkuyucu = new StreamReader(".\\rehber.ntp2");
                    int i = 0;
                    while (rehberOkuyucu.EndOfStream == false)
                    {
                        string[] kisiBilgileri = rehberOkuyucu.ReadLine().Split('#');
                        cmbBx_AdListesi.Items.Add(kisiBilgileri[0]);
                        rehberListesi[i, 0] = kisiBilgileri[0];
                        rehberListesi[i, 1] = kisiBilgileri[1];
                        rehberListesi[i, 2] = kisiBilgileri[2];
                        i++;
                    }
                    rehberOkuyucu.Close();
                    if (i == 0)
                    {
                        MessageBox.Show("Rehber Listesi Boş", "Kayıt Yok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Rehber Kayıt Dosyasına Ulaşılamıyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void cmbBx_AdListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBx_Ad.Text = rehberListesi[cmbBx_AdListesi.SelectedIndex, 0];
            txtBx_Soyad.Text = rehberListesi[cmbBx_AdListesi.SelectedIndex, 1];
            txtBx_Tel.Text = rehberListesi[cmbBx_AdListesi.SelectedIndex, 2];
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (cmbBx_AdListesi.SelectedIndex > -1)
            {
                if (txtBx_Ad.Text.Length > 0 && txtBx_Soyad.Text.Length > 0 && txtBx_Tel.Text.Length > 0)
                {
                    DialogResult dr = MessageBox.Show("Adı = " + txtBx_Ad.Text + "\nSoyadı = " + txtBx_Soyad.Text + "\nNumarası = " + txtBx_Tel.Text, "\nSİlmek İstedğine Emin Misin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            StreamWriter rehberYazici = new StreamWriter(".\\rehber.ntp2");
                            for (int i = 0; i < rehberListesi.Length; i++)
                            {
                                if (rehberListesi[i, 0] != null)
                                {
                                    if (i != cmbBx_AdListesi.SelectedIndex)
                                    {
                                        rehberYazici.WriteLine(rehberListesi[i, 0] + "#" + rehberListesi[i, 1] + "#" + rehberListesi[i, 2]);
                                    }
                                    else
                                    {
                                        rehberYazici.WriteLine(txtBx_Ad.Text + "#" + txtBx_Soyad.Text + "#" + txtBx_Tel.Text);
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                            rehberYazici.Close();
                            MessageBox.Show("Güncelleme İşlemi  Tamamlandı ", "Başarıılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            Close();
                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show(hata.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }

            else
            {
                MessageBox.Show("Lütfen Açılır Menüden Bir İsim Seçiniz", "Hata İsim Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Vazgec_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
