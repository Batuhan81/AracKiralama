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
    public partial class FrmAraçKayıt : Form
    {
        Araç_Kiralama arackiralama = new Araç_Kiralama();
        public FrmAraçKayıt()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnresimekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboseri.Items.Clear();
                if(combomarka.SelectedItem.ToString() == "Opel")
                {
                    comboseri.Items.Add("Astra");
                    comboseri.Items.Add("Vectra");
                    comboseri.Items.Add("Corsa");
                }
                else if(combomarka.SelectedIndex == 1)
                {
                    comboseri.Items.Add("Megan");
                    comboseri.Items.Add("Clio");
                }    
                else if(combomarka.SelectedIndex == 2)
                {
                    comboseri.Items.Add("Linea");
                    comboseri.Items.Add("Egea");
                    comboseri.Items.Add("Fiorino");

                }
                else if(combomarka.SelectedIndex == 3)
                {
                    comboseri.Items.Add("Fiesta");
                    comboseri.Items.Add("Focus");

                }
                else if (combomarka.SelectedIndex == 4)
                {
                    comboseri.Items.Add("C 180");
                    comboseri.Items.Add("Vito");

                }
                else if (combomarka.SelectedIndex == 5)
                {
                    comboseri.Items.Add("S 60");
                    comboseri.Items.Add("XC 90");
                }
                else if (combomarka.SelectedIndex == 6)
                {
                    comboseri.Items.Add("Corolla");
                    comboseri.Items.Add("Auris");
                }
             

            }
            catch
            {
                ;
            }
            
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            if (txtplaka.Text=="" &&  combomarka.Text == "" && txtmodelyılı.Text == "" && txtrenk.Text == "" && txtkm.Text == "" && comboyakıt.Text=="")
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Girdğinizden Emin Olun");

            }
            else
            {
                string cümle = "insert  into Araç(plaka,marka,seri,modelyıl,renk,km,yakıt,kiraücreti,resim,tarih,durumu)Values(@plaka,@marka,@seri,@modelyıl,@renk,@km,@yakıt,@kiraücreti,@resim,@tarih,@durumu)";
            SqlCommand komut2=new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka",txtplaka.Text);
            komut2.Parameters.AddWithValue("@marka", combomarka.Text);
            komut2.Parameters.AddWithValue("@seri", comboseri.Text);
            komut2.Parameters.AddWithValue("@modelyıl",txtmodelyılı.Text);
            komut2.Parameters.AddWithValue("@renk", txtrenk.Text);
            komut2.Parameters.AddWithValue("@km", txtkm.Text);
            komut2.Parameters.AddWithValue("@yakıt", comboyakıt.Text);
            komut2.Parameters.AddWithValue("@kiraücreti",int.Parse(txtkiraücreti.Text));
            komut2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@durumu", "Boş");
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            comboseri.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.ImageLocation = "";
            }
        }
    }
}
