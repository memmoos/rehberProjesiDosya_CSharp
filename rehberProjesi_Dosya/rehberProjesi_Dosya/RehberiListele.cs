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
using System.Data.SqlClient;

namespace rehberProjesi_Dosya
{
    public partial class RehberiListele : Form
    {
        public RehberiListele()
        {
            InitializeComponent();
        }

        private void RehberiListele_Load(object sender, EventArgs e)
        {
            if (File.Exists(".\\rehber.ntp2") == true)
            {

                try
                {
                    StreamReader rehberOkuyucu = new StreamReader(".\\rehber.ntp2");
                    int i = 0;
                    while (rehberOkuyucu.EndOfStream == false)
                    {
                        dataGridView1.Rows.Add();
                        string[] kisiBilgileri = rehberOkuyucu.ReadLine().Split('#');
                        dataGridView1[0, i].Value = kisiBilgileri[0];
                        dataGridView1[1, i].Value = kisiBilgileri[1];
                        dataGridView1[2, i].Value = kisiBilgileri[2];
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
    }
}
