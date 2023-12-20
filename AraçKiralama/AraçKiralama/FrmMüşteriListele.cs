using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraçKiralama
{
    public partial class FrmMüşteriListele : Form
    {
        Araç_Kiralama arackiralama= new Araç_Kiralama();
        public FrmMüşteriListele()
        {
            InitializeComponent();
        }

        private void FrmMüşteriListele_Load(object sender, EventArgs e)
        {
            YenileListele();

        }

        private void YenileListele()
        {
            string cümle = "select *from Müşteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
    
            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "Ad Soyad";
            dataGridView1.Columns[2].HeaderText = "Telefon";
            dataGridView1.Columns[3].HeaderText = "Adres";
            dataGridView1.Columns[4].HeaderText = "E-mail";
        }

      

        private void tcaratxt_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select *from Müşteri where tc like '%"+tcaratxt.Text+"%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
         
            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txttc.Text = satır.Cells[0].Value.ToString();
            txtadsoyad.Text = satır.Cells[1].Value.ToString();
            txttelefon.Text = satır.Cells[2].Value.ToString();
            txtadres.Text = satır.Cells[3].Value.ToString();
            txtemail.Text = satır.Cells[4].Value.ToString();

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update Müşteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc";
            SqlCommand komut2 = new SqlCommand(); 
            komut2.Parameters.AddWithValue("@tc", txttc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut2.Parameters.AddWithValue("@email", txtemail.Text);
            komut2.Parameters.AddWithValue("@adres", txtadres.Text);
             arackiralama.ekle_sil_güncelle(komut2,cümle);
            foreach (Control item in Controls) if (item is TextBox)
                {
                    item.Text = "";
                }
            YenileListele();
            MessageBox.Show("Bilgiler Güncellendi");
           
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Silmek İstediğinize Emin Misiniz?","Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataGridViewRow satır = dataGridView1.CurrentRow;
                string cümle = "delete from Müşteri where tc= '" + satır.Cells["tc"].Value.ToString() + "'";
                SqlCommand komut2 = new SqlCommand();
                arackiralama.ekle_sil_güncelle(komut2, cümle);
                foreach (Control item in Controls) if (item is TextBox)
                {
                        item.Text = "";
                }

                YenileListele();
            }
            else
            {
                ;
            }
        }
    }
}
