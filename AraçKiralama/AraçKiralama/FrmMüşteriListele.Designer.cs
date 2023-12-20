namespace AraçKiralama
{
    partial class FrmMüşteriListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMüşteriListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btniptal = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btngüncelle = new System.Windows.Forms.Button();
            this.lbladres = new System.Windows.Forms.Label();
            this.lbltelefon = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tcaratxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 377);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.DarkGray;
            this.btniptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btniptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btniptal.ImageIndex = 0;
            this.btniptal.ImageList = this.ımageList1;
            this.btniptal.Location = new System.Drawing.Point(172, 356);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(133, 60);
            this.btniptal.TabIndex = 22;
            this.btniptal.Text = "İptal";
            this.btniptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "İptal.png");
            this.ımageList1.Images.SetKeyName(1, "Sil.png");
            this.ımageList1.Images.SetKeyName(2, "Yenile İkonu2.png");
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.DarkGray;
            this.btngüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btngüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngüncelle.ImageIndex = 2;
            this.btngüncelle.ImageList = this.ımageList1;
            this.btngüncelle.Location = new System.Drawing.Point(12, 356);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(154, 60);
            this.btngüncelle.TabIndex = 21;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // lbladres
            // 
            this.lbladres.BackColor = System.Drawing.Color.Transparent;
            this.lbladres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbladres.Location = new System.Drawing.Point(18, 307);
            this.lbladres.Name = "lbladres";
            this.lbladres.Size = new System.Drawing.Size(86, 21);
            this.lbladres.TabIndex = 20;
            this.lbladres.Text = "Adres";
            this.lbladres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltelefon
            // 
            this.lbltelefon.BackColor = System.Drawing.Color.Transparent;
            this.lbltelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltelefon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltelefon.Location = new System.Drawing.Point(18, 173);
            this.lbltelefon.Name = "lbltelefon";
            this.lbltelefon.Size = new System.Drawing.Size(86, 21);
            this.lbltelefon.TabIndex = 18;
            this.lbltelefon.Text = "Telefon";
            this.lbltelefon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblemail
            // 
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblemail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblemail.Location = new System.Drawing.Point(18, 240);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(86, 21);
            this.lblemail.TabIndex = 19;
            this.lblemail.Text = "E-mail";
            this.lblemail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.BackColor = System.Drawing.Color.Transparent;
            this.lbladsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladsoyad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbladsoyad.Location = new System.Drawing.Point(18, 106);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(86, 21);
            this.lbladsoyad.TabIndex = 17;
            this.lbladsoyad.Text = "Ad Soyad";
            this.lbladsoyad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltc
            // 
            this.lbltc.BackColor = System.Drawing.Color.Transparent;
            this.lbltc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltc.Location = new System.Drawing.Point(18, 39);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(86, 21);
            this.lbltc.TabIndex = 16;
            this.lbltc.Text = "TC";
            this.lbltc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(110, 306);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(184, 22);
            this.txtadres.TabIndex = 15;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(110, 239);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(184, 22);
            this.txtemail.TabIndex = 14;
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(110, 172);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(184, 22);
            this.txttelefon.TabIndex = 13;
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(110, 105);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(184, 22);
            this.txtadsoyad.TabIndex = 12;
            // 
            // txttc
            // 
            this.txttc.Enabled = false;
            this.txttc.Location = new System.Drawing.Point(110, 38);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(184, 22);
            this.txttc.TabIndex = 11;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.DarkGray;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.ImageIndex = 1;
            this.btnsil.ImageList = this.ımageList1;
            this.btnsil.Location = new System.Drawing.Point(120, 435);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(104, 60);
            this.btnsil.TabIndex = 23;
            this.btnsil.Text = "Sil";
            this.btnsil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(489, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "TC Ara";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tcaratxt
            // 
            this.tcaratxt.Location = new System.Drawing.Point(612, 11);
            this.tcaratxt.Name = "tcaratxt";
            this.tcaratxt.Size = new System.Drawing.Size(184, 22);
            this.tcaratxt.TabIndex = 24;
            this.tcaratxt.TextChanged += new System.EventHandler(this.tcaratxt_TextChanged);
            // 
            // FrmMüşteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AraçKiralama.Properties.Resources.Arka_Plan_Araba4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcaratxt);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.lbladres);
            this.Controls.Add(this.lbltelefon);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbladsoyad);
            this.Controls.Add(this.lbltc);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "FrmMüşteriListele";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listele";
            this.Load += new System.EventHandler(this.FrmMüşteriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Label lbladres;
        private System.Windows.Forms.Label lbltelefon;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tcaratxt;
        private System.Windows.Forms.ImageList ımageList1;
    }
}