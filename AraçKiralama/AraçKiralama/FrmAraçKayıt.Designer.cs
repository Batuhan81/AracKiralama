namespace AraçKiralama
{
    partial class FrmAraçKayıt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAraçKayıt));
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.combomarka = new System.Windows.Forms.ComboBox();
            this.comboseri = new System.Windows.Forms.ComboBox();
            this.txtmodelyılı = new System.Windows.Forms.TextBox();
            this.txtrenk = new System.Windows.Forms.TextBox();
            this.txtkm = new System.Windows.Forms.TextBox();
            this.txtkiraücreti = new System.Windows.Forms.TextBox();
            this.comboyakıt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnresimekle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnİptal = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnKayıt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtplaka
            // 
            this.txtplaka.Location = new System.Drawing.Point(155, 47);
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.Size = new System.Drawing.Size(192, 22);
            this.txtplaka.TabIndex = 0;
            // 
            // combomarka
            // 
            this.combomarka.FormattingEnabled = true;
            this.combomarka.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fiat",
            "Ford",
            "Mercedes",
            "Volvo",
            "Toyota"});
            this.combomarka.Location = new System.Drawing.Point(155, 87);
            this.combomarka.Name = "combomarka";
            this.combomarka.Size = new System.Drawing.Size(192, 24);
            this.combomarka.TabIndex = 1;
            this.combomarka.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboseri
            // 
            this.comboseri.FormattingEnabled = true;
            this.comboseri.Location = new System.Drawing.Point(155, 129);
            this.comboseri.Name = "comboseri";
            this.comboseri.Size = new System.Drawing.Size(192, 24);
            this.comboseri.TabIndex = 2;
            // 
            // txtmodelyılı
            // 
            this.txtmodelyılı.Location = new System.Drawing.Point(155, 171);
            this.txtmodelyılı.Name = "txtmodelyılı";
            this.txtmodelyılı.Size = new System.Drawing.Size(192, 22);
            this.txtmodelyılı.TabIndex = 3;
            // 
            // txtrenk
            // 
            this.txtrenk.Location = new System.Drawing.Point(155, 211);
            this.txtrenk.Name = "txtrenk";
            this.txtrenk.Size = new System.Drawing.Size(192, 22);
            this.txtrenk.TabIndex = 4;
            this.txtrenk.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtkm
            // 
            this.txtkm.Location = new System.Drawing.Point(155, 251);
            this.txtkm.Name = "txtkm";
            this.txtkm.Size = new System.Drawing.Size(192, 22);
            this.txtkm.TabIndex = 5;
            // 
            // txtkiraücreti
            // 
            this.txtkiraücreti.Location = new System.Drawing.Point(155, 333);
            this.txtkiraücreti.Name = "txtkiraücreti";
            this.txtkiraücreti.Size = new System.Drawing.Size(192, 22);
            this.txtkiraücreti.TabIndex = 6;
            // 
            // comboyakıt
            // 
            this.comboyakıt.FormattingEnabled = true;
            this.comboyakıt.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+Lpg"});
            this.comboyakıt.Location = new System.Drawing.Point(155, 291);
            this.comboyakıt.Name = "comboyakıt";
            this.comboyakıt.Size = new System.Drawing.Size(192, 24);
            this.comboyakıt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(63, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = " Plaka";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(63, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = " Marka";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(63, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seri No";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(63, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Model Yılı";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(63, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Renk";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(63, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = " Araç Km";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(63, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Yakıt";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(63, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = " Kira Ücreti";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnresimekle
            // 
            this.btnresimekle.BackColor = System.Drawing.Color.DarkGray;
            this.btnresimekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnresimekle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnresimekle.ImageIndex = 17;
            this.btnresimekle.ImageList = this.ımageList1;
            this.btnresimekle.Location = new System.Drawing.Point(505, 272);
            this.btnresimekle.Name = "btnresimekle";
            this.btnresimekle.Size = new System.Drawing.Size(185, 77);
            this.btnresimekle.TabIndex = 20;
            this.btnresimekle.Text = " Resim Ekle";
            this.btnresimekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnresimekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnresimekle.UseVisualStyleBackColor = false;
            this.btnresimekle.Click += new System.EventHandler(this.btnresimekle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Araç Değiştir.png");
            this.ımageList1.Images.SetKeyName(1, "Araç Değiştir2.png");
            this.ımageList1.Images.SetKeyName(2, "Araç Kayıt.png");
            this.ımageList1.Images.SetKeyName(3, "Araç Listele.png");
            this.ımageList1.Images.SetKeyName(4, "Araç Teslim.png");
            this.ımageList1.Images.SetKeyName(5, "Çıkış.png");
            this.ımageList1.Images.SetKeyName(6, "Dosya Ekle.png");
            this.ımageList1.Images.SetKeyName(7, "Ekle.png");
            this.ımageList1.Images.SetKeyName(8, "Güncell1.jpg");
            this.ımageList1.Images.SetKeyName(9, "Hesapla İkonu3.png");
            this.ımageList1.Images.SetKeyName(10, "Hesapla ikonu4.png");
            this.ımageList1.Images.SetKeyName(11, "İptal.png");
            this.ımageList1.Images.SetKeyName(12, "Müşteri Ekle 3.png");
            this.ımageList1.Images.SetKeyName(13, "Müşteri Ekle2.png");
            this.ımageList1.Images.SetKeyName(14, "Müşteri Ekle4.png");
            this.ımageList1.Images.SetKeyName(15, "Müşteri Listele.png");
            this.ımageList1.Images.SetKeyName(16, "Resim Değiştirme.png");
            this.ımageList1.Images.SetKeyName(17, "Resim Ekle2.png");
            this.ımageList1.Images.SetKeyName(18, "Sepet İkonu 2.png");
            this.ımageList1.Images.SetKeyName(19, "Sil.png");
            this.ımageList1.Images.SetKeyName(20, "Sözleşme.png");
            this.ımageList1.Images.SetKeyName(21, "Sözleşmeyi Yenile.png");
            this.ımageList1.Images.SetKeyName(22, "Yenile İkonu2.png");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.Color.DarkGray;
            this.btnİptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnİptal.ImageIndex = 0;
            this.btnİptal.ImageList = this.ımageList2;
            this.btnİptal.Location = new System.Drawing.Point(228, 392);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(149, 78);
            this.btnİptal.TabIndex = 19;
            this.btnİptal.Text = "İptal";
            this.btnİptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnİptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "İptal.png");
            this.ımageList2.Images.SetKeyName(1, "Arka Plan Araba.jpg");
            // 
            // btnKayıt
            // 
            this.btnKayıt.BackColor = System.Drawing.Color.DarkGray;
            this.btnKayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKayıt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayıt.ImageIndex = 2;
            this.btnKayıt.ImageList = this.ımageList1;
            this.btnKayıt.Location = new System.Drawing.Point(66, 392);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(153, 78);
            this.btnKayıt.TabIndex = 18;
            this.btnKayıt.Text = "Ekle";
            this.btnKayıt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKayıt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKayıt.UseVisualStyleBackColor = false;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(412, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAraçKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 506);
            this.Controls.Add(this.btnresimekle);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboyakıt);
            this.Controls.Add(this.txtkiraücreti);
            this.Controls.Add(this.txtkm);
            this.Controls.Add(this.txtrenk);
            this.Controls.Add(this.txtmodelyılı);
            this.Controls.Add(this.comboseri);
            this.Controls.Add(this.combomarka);
            this.Controls.Add(this.txtplaka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmAraçKayıt";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kayıt işlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtplaka;
        private System.Windows.Forms.ComboBox combomarka;
        private System.Windows.Forms.ComboBox comboseri;
        private System.Windows.Forms.TextBox txtmodelyılı;
        private System.Windows.Forms.TextBox txtrenk;
        private System.Windows.Forms.TextBox txtkm;
        private System.Windows.Forms.TextBox txtkiraücreti;
        private System.Windows.Forms.ComboBox comboyakıt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnresimekle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList ımageList2;
    }
}