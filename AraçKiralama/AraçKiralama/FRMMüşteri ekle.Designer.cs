namespace AraçKiralama
{
    partial class FRMMüşteri_ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMMüşteri_ekle));
            this.btniptal = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.btnekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.DarkGray;
            this.btniptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btniptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btniptal.ImageIndex = 1;
            this.btniptal.ImageList = this.ımageList1;
            this.btniptal.Location = new System.Drawing.Point(261, 343);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(110, 60);
            this.btniptal.TabIndex = 34;
            this.btniptal.Text = "İptal";
            this.btniptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Ekle.png");
            this.ımageList1.Images.SetKeyName(1, "İptal.png");
            // 
            // lbladres
            // 
            this.lbladres.BackColor = System.Drawing.Color.Transparent;
            this.lbladres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbladres.Location = new System.Drawing.Point(105, 293);
            this.lbladres.Name = "lbladres";
            this.lbladres.Size = new System.Drawing.Size(76, 21);
            this.lbladres.TabIndex = 32;
            this.lbladres.Text = "Adres";
            this.lbladres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltelefon
            // 
            this.lbltelefon.BackColor = System.Drawing.Color.Transparent;
            this.lbltelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltelefon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltelefon.Location = new System.Drawing.Point(105, 159);
            this.lbltelefon.Name = "lbltelefon";
            this.lbltelefon.Size = new System.Drawing.Size(76, 21);
            this.lbltelefon.TabIndex = 30;
            this.lbltelefon.Text = "Telefon";
            this.lbltelefon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblemail
            // 
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblemail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblemail.Location = new System.Drawing.Point(105, 226);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(76, 21);
            this.lblemail.TabIndex = 31;
            this.lblemail.Text = "E-mail";
            this.lblemail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.BackColor = System.Drawing.Color.Transparent;
            this.lbladsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladsoyad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbladsoyad.Location = new System.Drawing.Point(105, 92);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(76, 21);
            this.lbladsoyad.TabIndex = 29;
            this.lbladsoyad.Text = "Ad Soyad";
            this.lbladsoyad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltc
            // 
            this.lbltc.BackColor = System.Drawing.Color.Transparent;
            this.lbltc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltc.Location = new System.Drawing.Point(105, 25);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(76, 21);
            this.lbltc.TabIndex = 28;
            this.lbltc.Text = "TC";
            this.lbltc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(187, 292);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(184, 22);
            this.txtadres.TabIndex = 27;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(187, 225);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(184, 22);
            this.txtemail.TabIndex = 26;
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(187, 158);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(184, 22);
            this.txttelefon.TabIndex = 25;
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(187, 91);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(184, 22);
            this.txtadsoyad.TabIndex = 24;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(187, 24);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(184, 22);
            this.txttc.TabIndex = 23;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.DarkGray;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnekle.ImageIndex = 0;
            this.btnekle.ImageList = this.ımageList1;
            this.btnekle.Location = new System.Drawing.Point(132, 343);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(115, 60);
            this.btnekle.TabIndex = 33;
            this.btnekle.Text = "Ekle";
            this.btnekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click_1);
            // 
            // FRMMüşteri_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AraçKiralama.Properties.Resources.Arka_Plan_Araba3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 479);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnekle);
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
            this.Name = "FRMMüşteri_ekle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnekle;
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
        private System.Windows.Forms.ImageList ımageList1;
    }
}