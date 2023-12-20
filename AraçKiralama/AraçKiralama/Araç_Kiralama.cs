using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraçKiralama
{
    internal class Araç_Kiralama
    {
        SqlConnection bağlantı = new SqlConnection("Data Source=Batuhan;Initial Catalog=AraçKiralama;Integrated Security=True");
        DataTable tablo;
        public void ekle_sil_güncelle(SqlCommand komut,string sorgu)
        {
            bağlantı.Open();
            komut.Connection = bağlantı;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            bağlantı.Close();

        }
      
        public DataTable listele(SqlDataAdapter adtr,string sorgu)
        {
            tablo=new DataTable();
            adtr = new SqlDataAdapter(sorgu, bağlantı);
            adtr.Fill(tablo);
            bağlantı.Close();
            return tablo;
        }
        public void Boş_Araçlar(ComboBox combo,string sorgu)
        {
            bağlantı.Open ();
            SqlCommand komut = new SqlCommand(sorgu,bağlantı);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                combo.Items.Add(reader["plaka"].ToString());
            }
            bağlantı.Close ();
        }
        public void TC_Ara(TextBox tcara,TextBox tc,TextBox adsoyad, TextBox telefon ,string sorgu) // Değiştirdik TextBox tcara
        {
            bağlantı.Open();


            SqlCommand komut2 = new SqlCommand(sorgu, bağlantı);
            SqlDataReader reader = komut2.ExecuteReader();
            while (reader.Read())
            {
                tc.Text = reader["tc"].ToString();
                adsoyad.Text = reader["adsoyad"].ToString();
                telefon.Text= reader["telefon"].ToString();
            }
            bağlantı.Close();
        }
        public void Ücret_Hesapla(ComboBox combokiraşekli,TextBox txtücret ,string sorgu)
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand(sorgu, bağlantı);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (combokiraşekli.SelectedIndex == 0) txtücret.Text = (int.Parse(reader["kiraücreti"].ToString()) * 1).ToString();
                if (combokiraşekli.SelectedIndex == 1) txtücret.Text = (int.Parse(reader["kiraücreti"].ToString())* 0.80).ToString();
                if (combokiraşekli.SelectedIndex == 2) txtücret.Text = (int.Parse(reader["kiraücreti"].ToString()) * 0.70).ToString();
            }
            bağlantı.Close();
        }
        public void Combodan_Getir(ComboBox araçlar,TextBox marka, TextBox seri, TextBox modelyıl,TextBox renk, string sorgu)
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand(sorgu, bağlantı);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                marka.Text = reader["marka"].ToString();    
                seri.Text = reader["seri"].ToString();
                modelyıl.Text = reader["modelyıl"].ToString();
                renk.Text = reader["renk"].ToString();
            }
            bağlantı.Close();
        }
      
       
        public void Satış_Hesapla( Label lbl)
        {
            bağlantı.Open ();
            SqlCommand komut = new SqlCommand("select sum(tutar) from [Satış]",bağlantı);
            lbl.Text = "Toplam Tutar="+ komut.ExecuteScalar()+"₺";
            bağlantı.Close ();
        }
    }
}
