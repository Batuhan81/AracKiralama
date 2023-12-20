using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraçKiralama
{
    public partial class FRMMüşteri_ekle : Form
    {
        Araç_Kiralama arac_kiralama=new Araç_Kiralama();
        public FRMMüşteri_ekle()
        {
            InitializeComponent();
        }
        SqlConnection bağlantı = new SqlConnection("Data Source = Batuhan; Initial Catalog = AraçKiralama; Integrated Security = True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        bool durum;

        private void btnekle_Click_1(object sender, EventArgs e)
        {
            durum = true;
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Müşteri ", bağlantı);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (txttc.Text == reader["tc"].ToString())
                {
                    durum = false;
                    
                }
            }bağlantı.Close();

            if (durum==true)
            {
                 if (txttc.Text.Length != 11)
                 {
                MessageBox.Show("TC numarası 11 haneli olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                 }
                 if (txttelefon.Text.Length != 11)
                 {
                    MessageBox.Show("Telefon numarası 11 haneli olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                 }
                 else
                 {
                     if (txttc.Text==""&&  txtadsoyad.Text==""&&   txtemail.Text ==""&& txtadres.Text == "")
                     {
                    MessageBox.Show("Lütfen Bilgileri Eksiksiz Girdğinizden Emin Olun");
                     }
                     else
                     {
                        string cümle = "insert into Müşteri(tc,adsoyad,telefon,email,adres)Values(@tc,@adsoyad,@telefon,@email,@adres) ";
                        SqlCommand komut2 = new SqlCommand();
                        komut2.Parameters.AddWithValue("@tc",txttc.Text);
                        komut2.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
                        komut2.Parameters.AddWithValue("@telefon", txttelefon.Text);
                        komut2.Parameters.AddWithValue("@email", txtemail.Text);
                        komut2.Parameters.AddWithValue("@adres", txtadres.Text);            
                        arac_kiralama.ekle_sil_güncelle(komut2, cümle);
                         foreach(Control item in Controls) if (item is TextBox)
                         {
                            item.Text = "";
                         }
                        MessageBox.Show("Müşteri Bİlgileri Kayıt Edildi");
                     }
                 }
            }
            else 
            { 
                MessageBox.Show("Böyle Bir Müşteri Zaten Var", "Uyarı"); 
                foreach(Control item in Controls) 
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
            }
           
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
