namespace AraçKiralama
{
    partial class FrmAraçLİsteleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAraçLİsteleme));
            this.Ekran = new System.Windows.Forms.DataGridView();
            this.comboAraçlar = new System.Windows.Forms.ComboBox();
            this.btnresimekle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboyakıt = new System.Windows.Forms.ComboBox();
            this.txtkiraücreti = new System.Windows.Forms.TextBox();
            this.txtkm = new System.Windows.Forms.TextBox();
            this.txtrenk = new System.Windows.Forms.TextBox();
            this.txtmodelyılı = new System.Windows.Forms.TextBox();
            this.comboseri = new System.Windows.Forms.ComboBox();
            this.combomarka = new System.Windows.Forms.ComboBox();
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ekran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Ekran
            // 
            this.Ekran.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ekran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ekran.Location = new System.Drawing.Point(330, 64);
            this.Ekran.Name = "Ekran";
            this.Ekran.RowHeadersWidth = 51;
            this.Ekran.RowTemplate.Height = 24;
            this.Ekran.Size = new System.Drawing.Size(1221, 472);
            this.Ekran.TabIndex = 0;
            this.Ekran.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ekran_CellDoubleClick);
            // 
            // comboAraçlar
            // 
            this.comboAraçlar.FormattingEnabled = true;
            this.comboAraçlar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boştaki Araçlar",
            "Dolu Araçlar"});
            this.comboAraçlar.Location = new System.Drawing.Point(396, 24);
            this.comboAraçlar.Name = "comboAraçlar";
            this.comboAraçlar.Size = new System.Drawing.Size(169, 24);
            this.comboAraçlar.TabIndex = 1;
            this.comboAraçlar.SelectedIndexChanged += new System.EventHandler(this.comboAraçlar_SelectedIndexChanged);
            // 
            // btnresimekle
            // 
            this.btnresimekle.BackColor = System.Drawing.Color.DarkGray;
            this.btnresimekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnresimekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnresimekle.ImageIndex = 2;
            this.btnresimekle.ImageList = this.ımageList1;
            this.btnresimekle.Location = new System.Drawing.Point(73, 323);
            this.btnresimekle.Name = "btnresimekle";
            this.btnresimekle.Size = new System.Drawing.Size(201, 50);
            this.btnresimekle.TabIndex = 40;
            this.btnresimekle.Text = "Resim Değiştir";
            this.btnresimekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnresimekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnresimekle.UseVisualStyleBackColor = false;
            this.btnresimekle.Click += new System.EventHandler(this.btnresimekle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Araç Değiştir2.png");
            this.ımageList1.Images.SetKeyName(1, "İptal.png");
            this.ımageList1.Images.SetKeyName(2, "Resim Değiştirme.png");
            this.ımageList1.Images.SetKeyName(3, "Sil.png");
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.Color.DarkGray;
            this.btnİptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnİptal.ImageIndex = 1;
            this.btnİptal.ImageList = this.ımageList1;
            this.btnİptal.Location = new System.Drawing.Point(186, 561);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(138, 68);
            this.btnİptal.TabIndex = 39;
            this.btnİptal.Text = "İptal";
            this.btnİptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnİptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.DarkGray;
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGüncelle.ImageIndex = 0;
            this.btnGüncelle.ImageList = this.ımageList1;
            this.btnGüncelle.Location = new System.Drawing.Point(14, 561);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(165, 68);
            this.btnGüncelle.TabIndex = 38;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGüncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(11, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = " Kira Ücreti";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(11, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Yakıt";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = " Araç Km";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Renk";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Model Yılı";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Seri No";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = " Marka";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = " Plaka";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboyakıt
            // 
            this.comboyakıt.FormattingEnabled = true;
            this.comboyakıt.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+Lpg"});
            this.comboyakıt.Location = new System.Drawing.Point(100, 250);
            this.comboyakıt.Name = "comboyakıt";
            this.comboyakıt.Size = new System.Drawing.Size(192, 24);
            this.comboyakıt.TabIndex = 28;
            // 
            // txtkiraücreti
            // 
            this.txtkiraücreti.Location = new System.Drawing.Point(100, 292);
            this.txtkiraücreti.Name = "txtkiraücreti";
            this.txtkiraücreti.Size = new System.Drawing.Size(192, 22);
            this.txtkiraücreti.TabIndex = 27;
            // 
            // txtkm
            // 
            this.txtkm.Location = new System.Drawing.Point(100, 210);
            this.txtkm.Name = "txtkm";
            this.txtkm.Size = new System.Drawing.Size(192, 22);
            this.txtkm.TabIndex = 26;
            // 
            // txtrenk
            // 
            this.txtrenk.Location = new System.Drawing.Point(100, 170);
            this.txtrenk.Name = "txtrenk";
            this.txtrenk.Size = new System.Drawing.Size(192, 22);
            this.txtrenk.TabIndex = 25;
            // 
            // txtmodelyılı
            // 
            this.txtmodelyılı.Location = new System.Drawing.Point(100, 130);
            this.txtmodelyılı.Name = "txtmodelyılı";
            this.txtmodelyılı.Size = new System.Drawing.Size(192, 22);
            this.txtmodelyılı.TabIndex = 24;
            // 
            // comboseri
            // 
            this.comboseri.FormattingEnabled = true;
            this.comboseri.Location = new System.Drawing.Point(100, 88);
            this.comboseri.Name = "comboseri";
            this.comboseri.Size = new System.Drawing.Size(192, 24);
            this.comboseri.TabIndex = 23;
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
            this.combomarka.Location = new System.Drawing.Point(100, 46);
            this.combomarka.Name = "combomarka";
            this.combomarka.Size = new System.Drawing.Size(192, 24);
            this.combomarka.TabIndex = 22;
            this.combomarka.SelectedIndexChanged += new System.EventHandler(this.combomarka_SelectedIndexChanged);
            // 
            // txtplaka
            // 
            this.txtplaka.Enabled = false;
            this.txtplaka.Location = new System.Drawing.Point(100, 6);
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.Size = new System.Drawing.Size(192, 22);
            this.txtplaka.TabIndex = 21;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkGray;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 3;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(1323, 0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(126, 58);
            this.btnSil.TabIndex = 41;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(30, 379);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(262, 176);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // FrmAraçLİsteleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AraçKiralama.Properties.Resources.Arka_Plan_Araba2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1561, 641);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnresimekle);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnGüncelle);
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
            this.Controls.Add(this.comboAraçlar);
            this.Controls.Add(this.Ekran);
            this.Name = "FrmAraçLİsteleme";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Listesi";
            this.Load += new System.EventHandler(this.FrmAraçLİsteleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ekran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Ekran;
        private System.Windows.Forms.ComboBox comboAraçlar;
        private System.Windows.Forms.Button btnresimekle;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboyakıt;
        private System.Windows.Forms.TextBox txtkiraücreti;
        private System.Windows.Forms.TextBox txtkm;
        private System.Windows.Forms.TextBox txtrenk;
        private System.Windows.Forms.TextBox txtmodelyılı;
        private System.Windows.Forms.ComboBox comboseri;
        private System.Windows.Forms.ComboBox combomarka;
        private System.Windows.Forms.TextBox txtplaka;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}