using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraçKiralama
{
    public partial class FRMSözleşme : Form
    {
        public FRMSözleşme()
        {
            InitializeComponent();
        }
        Araç_Kiralama araç = new Araç_Kiralama();
        private void FRMSözleşme_Load(object sender, EventArgs e)
        {
            Boş_Araçlar();
            Yenile();

        }
        SqlConnection bağlantı = new SqlConnection("Data Source = Batuhan; Initial Catalog = AraçKiralama; Integrated Security = True");

        private void Boş_Araçlar()
        {
            string sorgu2 = "select * from Araç where durumu='BOŞ'";
            araç.Boş_Araçlar(comboaraçlar, sorgu2);
        }

        private void Yenile()
        {
            string sorgu3 = "select * from Sözleşme";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = araç.listele(adtr2, sorgu3);
        }

        //private void txttc_TextChanged(object sender, EventArgs e)
        //{
        //    if (txttc.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
        //    string sorgu2 = "select * from Müşteri where tc like  '" +tcaratxt.Text + "' ";
        //    araç.TC_Ara(tcaratxt, txttc, txtadsoyad, txttelefon, sorgu2);
        //}// bu yorum satırı 
        
        private void comboaraçlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from Araç where plaka like '" + comboaraçlar.SelectedItem + "'";
            araç.Combodan_Getir(comboaraçlar, txtmarka, txtseri, txtmodelyılı, txtrenk, sorgu2);
        }

        private void combokiraşekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select * from Araç where plaka like '" + comboaraçlar.SelectedItem + "'";
            araç.Ücret_Hesapla(combokiraşekli, txtkiraücreti, sorgu2);
        }
        bool durum;
        private void btnhesapla_Click(object sender, EventArgs e)
        {
            if (txtkiraücreti.Text == "")
            {
                MessageBox.Show("Lütfen Geçerli Bİr Kira Ücreti Giriniz");
                durum = false;
            }
            if (dönüşt.Text == "" || çıkışt.Text == "")
            {

                MessageBox.Show("Lütfen Geçerli Bir Tarih Girdiğinizden Emin Olun");

            }
            else
            {
                if (durum == true)
                {
                    MessageBox.Show("SA");
                }
                else
                {
                    TimeSpan gün = DateTime.Parse(dönüşt.Text) - DateTime.Parse(çıkışt.Text);
                    int gün2 = gün.Days;
                    if (gün2 == 0)
                    {

                        txtgün.Text = gün2.ToString();
                        txttutar.Text = (decimal.Parse(txtkiraücreti.Text)).ToString();
                    }
                    else
                    {
                        txtgün.Text = gün2.ToString();
                        txttutar.Text = (gün2 * decimal.Parse(txtkiraücreti.Text)).ToString();
                    }
                }
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            if (çıkışt.Text == "" && dönüşt.Text == "" && combokiraşekli.Text == "" && txtkiraücreti.Text == "" && txtgün.Text == "" && txttutar.Text == "")
            {
                MessageBox.Show("Silinecek veri bulunamadı");
            }
            else
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }
                }
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }
                }
                çıkışt.Text = DateTime.Now.ToShortDateString();
                dönüşt.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (txttc.Text == "" || txtadsoyad.Text == "" || txttelefon.Text == "" || txtehliyetno.Text == "" || txtetarihi.Text == "" || txteverilidiğiyer.Text == "" || comboaraçlar.Text == "" ||
             txtmarka.Text == "" || txtseri.Text == "" || txtmodelyılı.Text == "" || txtrenk.Text == "" || combokiraşekli.Text == "" || txtkiraücreti.Text == "" || txtgün.Text == "" ||
             txttutar.Text == "" || çıkışt.Text == "" || dönüşt.Text == "")
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Girdğinizden Emin Olun");
            }
            else
            {
                string sorgu2 = "INSERT INTO Sözleşme(tc,adsoyad,telefon,ehliyetno,ehliyettarihi,ehliyetinverildiğiyer,plaka,marka,modelyıl,renk,kirasekli,kiraucreti,gun,tutar,cıkıştarihi,donustarihi,seri) VALUES(@tc,@adsoyad,@telefon,@ehliyetno,@ehliyettarihi,@ehliyetinverildiğiyer,@plaka,@marka,@modelyıl,@renk,@kirasekli,@kiraucreti,@gun,@tutar,@cıkıştarihi,@donustarihi,@seri)";

                SqlCommand komut = new SqlCommand();
                komut.Parameters.AddWithValue("@tc", txttc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
                komut.Parameters.AddWithValue("@ehliyetno", txtehliyetno.Text);
                komut.Parameters.AddWithValue("@ehliyettarihi", txtetarihi.Text);
                komut.Parameters.AddWithValue("@ehliyetinverildiğiyer", txteverilidiğiyer.Text);
                komut.Parameters.AddWithValue("@plaka", comboaraçlar.Text);
                komut.Parameters.AddWithValue("@marka", txtmarka.Text);
                komut.Parameters.AddWithValue("@seri", txtseri.Text);
                komut.Parameters.AddWithValue("@modelyıl", txtmodelyılı.Text);
                komut.Parameters.AddWithValue("@renk", txtrenk.Text);
                komut.Parameters.AddWithValue("@kirasekli", combokiraşekli.Text);
                komut.Parameters.AddWithValue("@kiraucreti", decimal.Parse(txtkiraücreti.Text));
                komut.Parameters.AddWithValue("@gun", int.Parse(txtgün.Text));
                komut.Parameters.AddWithValue("@tutar", decimal.Parse(txttutar.Text));
                komut.Parameters.AddWithValue("@cıkıştarihi", çıkışt.Text);
                komut.Parameters.AddWithValue("@donustarihi", dönüşt.Text);
                araç.ekle_sil_güncelle(komut, sorgu2);

                string sorgu3 = "Update Araç set durumu='DOLU'where plaka='" + comboaraçlar.Text + "'";
                SqlCommand komut3 = new SqlCommand();
                araç.ekle_sil_güncelle(komut3, sorgu3);
                comboaraçlar.Items.Clear();
                Boş_Araçlar();
                Yenile();
                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                comboaraçlar.Text = "";
                Temizle();
                MessageBox.Show("Sözleşme Başarıyla Eklenedi");
            }
        }

        private void tcaratxt_TextChanged(object sender, EventArgs e)
        {
            if (txttcara.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";

            string sorgu2 = "select *from Müşteri where tc like '%" + tcaratxt.Text + "%'";
            araç.TC_Ara(tcaratxt, txttc, txtadsoyad, txttelefon, sorgu2);
        }

        private void btnsözleşmegüncelle_Click(object sender, EventArgs e)
        {

            if (txttc.Text == "" && txtadsoyad.Text == "" && txttelefon.Text == "" && txtehliyetno.Text == "" && txtetarihi.Text == "" &&
                txteverilidiğiyer.Text == "" && comboaraçlar.Text == "" && txtmarka.Text == "" && txtseri.Text == "" && txtmodelyılı.Text == "" &&
                txtrenk.Text == "" && combokiraşekli.Text == "" && txtkiraücreti.Text == "" && txtgün.Text == "" &&
             txttutar.Text == "" && çıkışt.Text == "" && dönüşt.Text == "")
            {

                MessageBox.Show("Lütfen Bilgileri Eksiksiz Girdğinizden Emin Olun");

            }
            else
            {
                string sorgu2 = "UPDATE Sözleşme SET tc=@tc,adsoyad=@adsoyad,telefon=@telefon,ehliyetno=@ehliyetno,ehliyettarihi=@ehliyettarihi," +
                    "ehliyetinverildiğiyer=@ehliyetinverildiğiyer,plaka=@plaka,marka=@marka,modelyıl=@modelyıl,renk=@renk,kirasekli=@kirasekli," +
                    "kiraucreti=@kiraucreti,gun=@gun,tutar=@tutar,cıkıştarihi=@cıkıştarihi,donustarihi=@donustarihi,seri=@seri WHERE plaka=@plaka";
                 SqlCommand komut = new SqlCommand();
                komut.Parameters.AddWithValue("@tc", txttc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
                komut.Parameters.AddWithValue("@ehliyetno", txtehliyetno.Text);
                komut.Parameters.AddWithValue("@ehliyettarihi", txtetarihi.Text);
                komut.Parameters.AddWithValue("@ehliyetinverildiğiyer", txteverilidiğiyer.Text);
                komut.Parameters.AddWithValue("@plaka", comboaraçlar.Text);
                komut.Parameters.AddWithValue("@marka", txtmarka.Text);
                komut.Parameters.AddWithValue("@seri", txtseri.Text);
                komut.Parameters.AddWithValue("@modelyıl", txtmodelyılı.Text);
                komut.Parameters.AddWithValue("@renk", txtrenk.Text);
                komut.Parameters.AddWithValue("@kirasekli", combokiraşekli.Text);
                komut.Parameters.AddWithValue("@kiraucreti", decimal.Parse(txtkiraücreti.Text));
                komut.Parameters.AddWithValue("@gun", int.Parse(txtgün.Text));
                komut.Parameters.AddWithValue("@tutar", decimal.Parse(txttutar.Text));
                komut.Parameters.AddWithValue("@cıkıştarihi", çıkışt.Text);
                komut.Parameters.AddWithValue("@donustarihi", dönüşt.Text);

                araç.ekle_sil_güncelle(komut, sorgu2);

                comboaraçlar.Items.Clear();
                Boş_Araçlar();
                Yenile();
                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                comboaraçlar.Text = "";
                Temizle();
                MessageBox.Show("Sözleşme Başarıyla Güncellendi");
            }
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow satır = dataGridView1.Rows[e.RowIndex];
                txttc.Text = satır.Cells[0].Value.ToString();
                txtadsoyad.Text = satır.Cells[1].Value.ToString();
                txttelefon.Text = satır.Cells[2].Value.ToString();
                txtehliyetno.Text = satır.Cells[3].Value.ToString();
                txtetarihi.Text = satır.Cells[4].Value.ToString();
                txteverilidiğiyer.Text = satır.Cells[5].Value.ToString();
                comboaraçlar.Text = satır.Cells[6].Value.ToString();
                txtmarka.Text = satır.Cells[7].Value.ToString();
                txtmodelyılı.Text = satır.Cells[8].Value.ToString();
                txtrenk.Text = satır.Cells[9].Value.ToString();
                combokiraşekli.Text = satır.Cells[10].Value.ToString();
                txtkiraücreti.Text = satır.Cells[11].Value.ToString();
                txtgün.Text = satır.Cells[12].Value.ToString();
                txttutar.Text = satır.Cells[13].Value.ToString();
                çıkışt.Text = satır.Cells[14].Value.ToString();
                dönüşt.Text = satır.Cells[15].Value.ToString();
                txtseri.Text = satır.Cells[16].Value.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            //Gün FAkrını hesaplama
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime dönüş = DateTime.Parse(satır.Cells["donustarihi"].Value.ToString());
            int ucret = int.Parse(satır.Cells["kiraucreti"].Value.ToString());
            TimeSpan gunfarkı = bugün - dönüş;
            int _gunfarkı = gunfarkı.Days;
            int ucretfarkı;
            //ücret farkını bulma
            ucretfarkı = _gunfarkı * ucret;
            txtEkstra.Text = ucretfarkı.ToString();
        }


        private void btnaraçteslim_Click(object sender, EventArgs e)
        {
            if (txtEkstra.Text != "")
            {
                DataGridViewRow satır = dataGridView1.CurrentRow;
                DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
                int ucret = int.Parse(satır.Cells["kiraucreti"].Value.ToString());
                int tutar = int.Parse(satır.Cells["tutar"].Value.ToString());
                DateTime çıkış = DateTime.Parse(satır.Cells["cıkıştarihi"].Value.ToString());
                TimeSpan gün = bugün - çıkış;
                int _gün = gün.Days;
                int toplamtutar = _gün * ucret;

                //toplamtutar,_gun ve ucret sarış tablosuna aktarılacak
                string sorgu1 = "delete from Sözleşme where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
                SqlCommand komut = new SqlCommand();
                araç.ekle_sil_güncelle(komut, sorgu1);
                string sorgu2 = "Update Araç set durumu='BOŞ' where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
                SqlCommand komut3 = new SqlCommand();
                araç.ekle_sil_güncelle(komut3, sorgu2);


                string sorgu3 = "INSERT INTO Satış(tc,adsoyad,plaka,marka,seri,yil,renk,gun,fiyat,tutar,tarih1,tarih2) VALUES(@tc,@adsoyad,@plaka,@marka,@seri,@yil,@renk,@gun,@fiyat,@tutar,@tarih1,@tarih2)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@tc", satır.Cells["tc"].Value.ToString());
                komut2.Parameters.AddWithValue("@adsoyad", satır.Cells["adsoyad"].Value.ToString());
                komut2.Parameters.AddWithValue("@plaka", satır.Cells["plaka"].Value.ToString());
                komut2.Parameters.AddWithValue("@marka", satır.Cells["marka"].Value.ToString());
                komut2.Parameters.AddWithValue("@seri", satır.Cells["seri"].Value.ToString());
                komut2.Parameters.AddWithValue("@yil", satır.Cells["modelyıl"].Value.ToString());
                komut2.Parameters.AddWithValue("@renk", satır.Cells["renk"].Value.ToString());
                komut2.Parameters.AddWithValue("@gun", _gün);
                komut2.Parameters.AddWithValue("@tutar", toplamtutar);
                komut2.Parameters.AddWithValue("@tarih1", satır.Cells["cıkıştarihi"].Value.ToString());
                komut2.Parameters.AddWithValue("@tarih2", DateTime.Now.ToShortDateString());
                komut2.Parameters.AddWithValue("@fiyat", ucret);

                araç.ekle_sil_güncelle(komut2, sorgu3);
                MessageBox.Show("Araç Teslim Edildi");
                comboaraçlar.Items.Clear();
                txtEkstra.Text = "";
                Boş_Araçlar();
                Yenile();
                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                comboaraçlar.Text = "";
                Temizle();
                txtEkstra.Text = "";
            }
            else if (txtEkstra.Text == "")
            {
                MessageBox.Show("Lütfen Seçim Yapınız", "Uyarı");
            }
        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
