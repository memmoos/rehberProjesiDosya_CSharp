using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rehberProjesi_Dosya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            RehbereEkle rEkle = new RehbereEkle();
            rEkle.StartPosition = FormStartPosition.CenterParent;
            rEkle.ShowDialog();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            RehberdenSil rSil = new RehberdenSil();
            rSil.StartPosition = FormStartPosition.CenterParent;
            rSil.ShowDialog();
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            RehberiGüncelle rGuncel = new RehberiGüncelle();
            rGuncel.StartPosition = FormStartPosition.CenterParent;
            rGuncel.ShowDialog();
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            RehberiListele rListe = new RehberiListele();
            rListe.StartPosition = FormStartPosition.CenterParent;
            rListe.ShowDialog();
        }
    }
}
