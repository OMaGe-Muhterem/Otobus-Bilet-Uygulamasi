namespace OtobusBiletUygulaması
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
            this.label1 = new System.Windows.Forms.Label();
            this.tB_adsoyad = new System.Windows.Forms.TextBox();
            this.tB_nereden = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_nereye = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dT_tarih = new System.Windows.Forms.DateTimePicker();
            this.lB_saat = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bilet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı";
            // 
            // tB_adsoyad
            // 
            this.tB_adsoyad.Location = new System.Drawing.Point(134, 36);
            this.tB_adsoyad.Name = "tB_adsoyad";
            this.tB_adsoyad.Size = new System.Drawing.Size(155, 22);
            this.tB_adsoyad.TabIndex = 1;
            // 
            // tB_nereden
            // 
            this.tB_nereden.Location = new System.Drawing.Point(134, 92);
            this.tB_nereden.Name = "tB_nereden";
            this.tB_nereden.Size = new System.Drawing.Size(155, 22);
            this.tB_nereden.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nereden";
            // 
            // tB_nereye
            // 
            this.tB_nereye.Location = new System.Drawing.Point(134, 141);
            this.tB_nereye.Name = "tB_nereye";
            this.tB_nereye.Size = new System.Drawing.Size(155, 22);
            this.tB_nereye.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nereye";
            // 
            // dT_tarih
            // 
            this.dT_tarih.Location = new System.Drawing.Point(134, 200);
            this.dT_tarih.Name = "dT_tarih";
            this.dT_tarih.Size = new System.Drawing.Size(200, 22);
            this.dT_tarih.TabIndex = 6;
            // 
            // lB_saat
            // 
            this.lB_saat.FormattingEnabled = true;
            this.lB_saat.ItemHeight = 16;
            this.lB_saat.Items.AddRange(new object[] {
            "10.00",
            "11:00",
            "12:00"});
            this.lB_saat.Location = new System.Drawing.Point(134, 248);
            this.lB_saat.Name = "lB_saat";
            this.lB_saat.Size = new System.Drawing.Size(120, 84);
            this.lB_saat.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Bilet Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 9;
            // 
            // bilet
            // 
            this.bilet.AutoSize = true;
            this.bilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilet.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bilet.Location = new System.Drawing.Point(12, 359);
            this.bilet.Name = "bilet";
            this.bilet.Size = new System.Drawing.Size(40, 24);
            this.bilet.TabIndex = 10;
            this.bilet.Text = ".... ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 450);
            this.Controls.Add(this.bilet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lB_saat);
            this.Controls.Add(this.dT_tarih);
            this.Controls.Add(this.tB_nereye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_nereden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_adsoyad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_adsoyad;
        private System.Windows.Forms.TextBox tB_nereden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_nereye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dT_tarih;
        private System.Windows.Forms.ListBox lB_saat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bilet;
    }
}

