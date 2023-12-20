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
    public partial class FrmSatış : Form
    {
        public FrmSatış()
        {
            InitializeComponent();
        }

        Araç_Kiralama araç = new Araç_Kiralama();

        private void FrmSatış_Load(object sender, EventArgs e)
        {
            Göster();
        }

        private void Göster()
        {
            string sorgu2 = "select * from Satış";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = araç.listele(adtr2, sorgu2);
            araç.Satış_Hesapla(label1);
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            // Kullanıcının silmeyi onaylamasını isteyelim.
            DialogResult result = MessageBox.Show("Satışı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Seçili satırın olup olmadığını kontrol edelim.
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    int tarih = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["SatışID"].Value); // Varsayılan olarak "SatışID" sütunu kullanıldı, gerekirse değiştirin.

                    // Veritabanı bağlantısı ve komutu oluşturalım.
                    string connectionString = "Data Source=Batuhan;Initial Catalog=AraçKiralama;Integrated Security=True"; // Veritabanı bağlantı dizesini burada belirtin.
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sorgu2 = "DELETE FROM Satış WHERE SatışID = @SatışID";
                        using (SqlCommand command = new SqlCommand(sorgu2, connection))
                        {
                            command.Parameters.AddWithValue("@SatışID", tarih);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Yeniden gösterim ve hesaplama işlemlerini gerçekleştirelim.
                    Göster();
                    araç.Satış_Hesapla(label1);
                }
                else
                {
                    MessageBox.Show("Lütfen önce bir satır seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
