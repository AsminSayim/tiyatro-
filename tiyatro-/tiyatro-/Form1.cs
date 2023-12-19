using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tiyatro_.Resources;

namespace tiyatro_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tiyatro tiyatro;
        List<Tiyatro> tiyatroListesi=new List<Tiyatro>();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            tiyatroListesi.Add(new Tiyatro(1,"12.Gece", "Kağıthane Sadabad Sahnesi",200,new DateTime(2023,9,22),75,true));
            tiyatroListesi.Add(new Tiyatro(2,"Fındıkkıran", "İBB Yenibosna Dr. Enver Ören Kültür Merkezi", 260, new DateTime(2023,10,12),80, false));
            tiyatroListesi.Add(new Tiyatro(3,"Ben Medea Değilim", "Fatih Reşat Nuri Sahnesi", 260, new DateTime(2024,4, 15), 20, true));
            tiyatroListesi.Add(new Tiyatro(4,"Ay, Carmela!", "Harbiye Muhsin Ertuğrul Sahnesi", 100, new DateTime(2024,2,1), 30, false));
            tiyatroListesi.Add(new Tiyatro(5,"Bir Gece Masalı", "Harbiye Cemil Topuzlu Açıkhava Tiyatrosu", 500, new DateTime(2030,1,5), 25, true));
            tiyatroListesi.Add(new Tiyatro(6, "Cadı Kazanı", "Harbiye Cemil Topuzlu Açıkhava Tiyatrosu", 450, new DateTime(2030,12,10),60, true));
            dgvListe.DataSource = tiyatroListesi.ToList();

        }

        private void dgvListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            txtId.Text = dgvListe.CurrentRow.Cells["id"].Value.ToString();
            cmbOyunAdi.Text = dgvListe.CurrentRow.Cells["OyunAdi"].Value.ToString();
            cmbSahne.Text = dgvListe.CurrentRow.Cells["sahne"].Value.ToString();
            txtFiyat.Text = dgvListe.CurrentRow.Cells["fiyat"].Value.ToString();
            dtpTarih.Value = (DateTime)dgvListe.CurrentRow.Cells["tarih"].Value;
            chkMüzikal.Checked = (bool)dgvListe.CurrentRow.Cells["müzikal"].Value;
            nupSüre.Value = (int)dgvListe.CurrentRow.Cells["sure"].Value;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string oyunAdi = cmbOyunAdi.Text;
            string sahne = cmbSahne.Text;
            double fiyat = Convert.ToDouble(txtFiyat.Text);
            DateTime tarih=dtpTarih.Value;
            bool müzikal = chkMüzikal.Checked;
            int sure = Convert.ToInt32(nupSüre.Value);

            Tiyatro yeniTiyatro = new Tiyatro(id, oyunAdi, sahne, fiyat, tarih,sure, müzikal);
            tiyatroListesi.Add(yeniTiyatro);
            dgvListe.DataSource=tiyatroListesi.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvListe.SelectedRows[0];
            Tiyatro secilenTiyatro = secilenSatir.DataBoundItem as Tiyatro;
            DialogResult result = MessageBox.Show("Seçilen tiyatro silinsin mi?", "Tiyatro Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                tiyatroListesi.Remove(secilenTiyatro);
            }
            dgvListe.DataSource = tiyatroListesi.ToList();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvListe.SelectedRows[0];
            Tiyatro secilenTiyatro = secilenSatir.DataBoundItem as Tiyatro;
            int Id = Convert.ToInt32(txtId.Text);
            string oyunAdi = cmbOyunAdi.Text;
            string sahne = cmbSahne.Text;
            double fiyat = Convert.ToDouble(txtFiyat.Text);
            DateTime tarih = dtpTarih.Value;
            bool müzikal = chkMüzikal.Checked;
            int  sure = Convert.ToInt32(nupSüre.Value);

            secilenTiyatro.Id = Id;
            secilenTiyatro.OyunAdi = oyunAdi;
            secilenTiyatro.Tarih = tarih;
            secilenTiyatro.Fiyat=fiyat;
            secilenTiyatro.Müzikal = müzikal;
            secilenTiyatro.Sahne= sahne;
            secilenTiyatro.Sure = sure;
            dgvListe.DataSource = null;
            dgvListe.DataSource = tiyatroListesi.ToList();



        }
    }
}
