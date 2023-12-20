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
    public partial class FrmAraçLİsteleme : Form
    {
        Araç_Kiralama araçkiralama=new Araç_Kiralama();
        public FrmAraçLİsteleme()
        {
            InitializeComponent();
        }

        private void Ekran_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = Ekran.CurrentRow;
            txtplaka.Text = satır.Cells["plaka"].Value.ToString();
            combomarka.Text = satır.Cells["marka"].Value.ToString();
            comboseri.Text = satır.Cells["seri"].Value.ToString();
            txtmodelyılı.Text = satır.Cells["modelyıl"].Value.ToString();
            txtrenk.Text = satır.Cells["renk"].Value.ToString();
            txtkm.Text = satır.Cells["km"].Value.ToString();
            comboyakıt.Text = satır.Cells["yakıt"].Value.ToString();
            txtkiraücreti.Text = satır.Cells["kiraücreti"].Value.ToString();
            pictureBox2.ImageLocation= satır.Cells["resim"].Value.ToString();
            
        }

        private void FrmAraçLİsteleme_Load(object sender, EventArgs e)
        {
            AraçlarıYenile();
            try
            {
                comboAraçlar.SelectedIndex = 0;
            }
            catch
            {
                ;
            }

        }

        private void AraçlarıYenile()
        {
            string cümle = "select *from Araç";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            Ekran.DataSource= araçkiralama.listele(adtr2, cümle);

        }

        private void btnresimekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (txtplaka.Text == "" && combomarka.Text == "" && txtmodelyılı.Text == "" && txtrenk.Text == "" && txtkm.Text == "" && comboyakıt.Text == "")
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Girdğinizden Emin Olun");
            }
            else
            {
                String cümle = "Update Araç Set marka=@marka,seri=@seri,modelyıl=@modelyıl,renk=@renk,km=@km,yakıt=@yakıt," +
                        "kiraücreti=@kiraücreti,resim=@resim,tarih=@tarih where plaka=@plaka";
                SqlCommand komut2= new SqlCommand();
                komut2.Parameters.AddWithValue("@plaka", txtplaka.Text);
                komut2.Parameters.AddWithValue("@marka", combomarka.Text);
                komut2.Parameters.AddWithValue("@seri", comboseri.Text);
                komut2.Parameters.AddWithValue("@modelyıl", txtmodelyılı.Text);
                komut2.Parameters.AddWithValue("@renk", txtrenk.Text);
                komut2.Parameters.AddWithValue("@km", txtkm.Text);
                komut2.Parameters.AddWithValue("@yakıt", comboyakıt.Text);
                komut2.Parameters.AddWithValue("@kiraücreti", int.Parse(txtkiraücreti.Text));
                komut2.Parameters.AddWithValue("@resim", pictureBox2.ImageLocation);
                komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut2.Parameters.AddWithValue("@durumu", "Boş");
                araçkiralama.ekle_sil_güncelle(komut2, cümle);
                comboseri.Items.Clear();
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
                pictureBox2.ImageLocation = "";
                AraçlarıYenile();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (txtplaka.Text == "" && combomarka.Text == "" && txtmodelyılı.Text == "" && txtrenk.Text == "" && txtkm.Text == "" && comboyakıt.Text == "")
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Girdğinizden Emin Olun");
            }
            else
            {
                if (result == DialogResult.Yes)
                {
                DataGridViewRow satır = Ekran.CurrentRow;
                string cümle = "delete from Araç Where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
                SqlCommand komut2 = new SqlCommand();
                araçkiralama.ekle_sil_güncelle(komut2, cümle);
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
                pictureBox2.ImageLocation = "";
                AraçlarıYenile();
                }
                else
                {
                    ;
                }
            }
        }

        private void combomarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboseri.Items.Clear();
                if (combomarka.SelectedItem.ToString() == "Opel")
                {
                    comboseri.Items.Add("Astra");
                    comboseri.Items.Add("Vectra");
                    comboseri.Items.Add("Corsa");
                }
                else if (combomarka.SelectedIndex == 1)
                {
                    comboseri.Items.Add("Megan");
                    comboseri.Items.Add("Clio");
                }
                else if (combomarka.SelectedIndex == 2)
                {
                    comboseri.Items.Add("Linea");
                    comboseri.Items.Add("Megane");

                }
                else if (combomarka.SelectedIndex == 3)
                {
                    comboseri.Items.Add("Fiesta");
                    comboseri.Items.Add("Focus");

                }
            }
            catch
            {
                ;
            }
        }

        private void comboAraçlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboAraçlar.SelectedIndex==0)
                { AraçlarıYenile();}
                if (comboAraçlar.SelectedIndex == 1)
                {
                    string cümle = "select * from Araç where durumu='BOŞ'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    Ekran.DataSource = araçkiralama.listele(adtr2, cümle);
                }
                if (comboAraçlar.SelectedIndex == 2)
                {
                    string cümle = "select * from Araç where durumu='DOLU'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    Ekran.DataSource = araçkiralama.listele(adtr2, cümle);
                }
            }
            catch 
            {
                ;  
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
