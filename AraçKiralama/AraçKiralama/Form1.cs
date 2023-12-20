using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraçKiralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMMüşteri_ekle ekle = new FRMMüşteri_ekle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMüşteriListele listele=new FrmMüşteriListele();
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAraçKayıt kayıt=new FrmAraçKayıt();
            kayıt.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAraçLİsteleme Listele= new FrmAraçLİsteleme();
            Listele.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FRMSözleşme sözleşme =new FRMSözleşme();
            sözleşme.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmSatış satış =new FrmSatış();
            satış.ShowDialog();
        }
    }
}
