namespace Personel_Takip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.y_adi = new System.Windows.Forms.Label();
            this.y_parola = new System.Windows.Forms.Label();
            this.txt_yadi = new System.Windows.Forms.TextBox();
            this.txt_yparola = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.y_girishakki = new System.Windows.Forms.Label();
            this.lbl_hak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // y_adi
            // 
            this.y_adi.AutoSize = true;
            this.y_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y_adi.Location = new System.Drawing.Point(66, 81);
            this.y_adi.Name = "y_adi";
            this.y_adi.Size = new System.Drawing.Size(134, 25);
            this.y_adi.TabIndex = 0;
            this.y_adi.Text = "Yönetici Adı:";
            // 
            // y_parola
            // 
            this.y_parola.AutoSize = true;
            this.y_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y_parola.Location = new System.Drawing.Point(66, 146);
            this.y_parola.Name = "y_parola";
            this.y_parola.Size = new System.Drawing.Size(81, 25);
            this.y_parola.TabIndex = 0;
            this.y_parola.Text = "Paralo:";
            // 
            // txt_yadi
            // 
            this.txt_yadi.Location = new System.Drawing.Point(264, 80);
            this.txt_yadi.Name = "txt_yadi";
            this.txt_yadi.Size = new System.Drawing.Size(248, 26);
            this.txt_yadi.TabIndex = 1;
            // 
            // txt_yparola
            // 
            this.txt_yparola.Location = new System.Drawing.Point(264, 147);
            this.txt_yparola.Name = "txt_yparola";
            this.txt_yparola.Size = new System.Drawing.Size(248, 26);
            this.txt_yparola.TabIndex = 1;
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(255, 245);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(116, 44);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.Btn_giris_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(447, 245);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(110, 44);
            this.btn_cikis.TabIndex = 2;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = true;
            // 
            // y_girishakki
            // 
            this.y_girishakki.AutoSize = true;
            this.y_girishakki.Location = new System.Drawing.Point(77, 316);
            this.y_girishakki.Name = "y_girishakki";
            this.y_girishakki.Size = new System.Drawing.Size(85, 20);
            this.y_girishakki.TabIndex = 3;
            this.y_girishakki.Text = "Giriş Hakkı";
            // 
            // lbl_hak
            // 
            this.lbl_hak.AutoSize = true;
            this.lbl_hak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hak.ForeColor = System.Drawing.Color.Red;
            this.lbl_hak.Location = new System.Drawing.Point(264, 316);
            this.lbl_hak.Name = "lbl_hak";
            this.lbl_hak.Size = new System.Drawing.Size(0, 25);
            this.lbl_hak.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_hak);
            this.Controls.Add(this.y_girishakki);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_yparola);
            this.Controls.Add(this.txt_yadi);
            this.Controls.Add(this.y_parola);
            this.Controls.Add(this.y_adi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label y_adi;
        private System.Windows.Forms.Label y_parola;
        private System.Windows.Forms.TextBox txt_yadi;
        private System.Windows.Forms.TextBox txt_yparola;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label y_girishakki;
        private System.Windows.Forms.Label lbl_hak;
    }
}

