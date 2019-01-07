namespace LINQ
{
    partial class Form1
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
            this.btn_AllOrders = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_AllNames = new System.Windows.Forms.Button();
            this.btn_AllNumbers = new System.Windows.Forms.Button();
            this.btn_Negatif = new System.Windows.Forms.Button();
            this.btn_Pozitif = new System.Windows.Forms.Button();
            this.btn_Cıft = new System.Windows.Forms.Button();
            this.btn_Tek = new System.Windows.Forms.Button();
            this.btn_EnKucuk = new System.Windows.Forms.Button();
            this.btn_EnBuyuk = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_KacTane = new System.Windows.Forms.Button();
            this.btn_Alfabetik = new System.Windows.Forms.Button();
            this.btn_AlfabetikTers = new System.Windows.Forms.Button();
            this.btn_Uzunluklar = new System.Windows.Forms.Button();
            this.btn_tBarındıran = new System.Windows.Forms.Button();
            this.btn_cileBaslayan = new System.Windows.Forms.Button();
            this.btn_SadeceTarihler = new System.Windows.Forms.Button();
            this.btn_Son5 = new System.Windows.Forms.Button();
            this.btn_Ilk5 = new System.Windows.Forms.Button();
            this.btn_YangWang = new System.Windows.Forms.Button();
            this.btn_SiparisSayisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AllOrders
            // 
            this.btn_AllOrders.Location = new System.Drawing.Point(12, 70);
            this.btn_AllOrders.Name = "btn_AllOrders";
            this.btn_AllOrders.Size = new System.Drawing.Size(117, 23);
            this.btn_AllOrders.TabIndex = 0;
            this.btn_AllOrders.Text = "Tüm Siparişler";
            this.btn_AllOrders.UseVisualStyleBackColor = true;
            this.btn_AllOrders.Click += new System.EventHandler(this.btn_AllOrders_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(175, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(385, 227);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_AllNames
            // 
            this.btn_AllNames.Location = new System.Drawing.Point(12, 41);
            this.btn_AllNames.Name = "btn_AllNames";
            this.btn_AllNames.Size = new System.Drawing.Size(117, 23);
            this.btn_AllNames.TabIndex = 2;
            this.btn_AllNames.Text = "Tüm İsimler";
            this.btn_AllNames.UseVisualStyleBackColor = true;
            this.btn_AllNames.Click += new System.EventHandler(this.btn_AllNames_Click);
            // 
            // btn_AllNumbers
            // 
            this.btn_AllNumbers.Location = new System.Drawing.Point(12, 12);
            this.btn_AllNumbers.Name = "btn_AllNumbers";
            this.btn_AllNumbers.Size = new System.Drawing.Size(117, 23);
            this.btn_AllNumbers.TabIndex = 3;
            this.btn_AllNumbers.Text = "Tüm Sayılar";
            this.btn_AllNumbers.UseVisualStyleBackColor = true;
            this.btn_AllNumbers.Click += new System.EventHandler(this.btn_AllNumbers_Click);
            // 
            // btn_Negatif
            // 
            this.btn_Negatif.Location = new System.Drawing.Point(135, 12);
            this.btn_Negatif.Name = "btn_Negatif";
            this.btn_Negatif.Size = new System.Drawing.Size(63, 23);
            this.btn_Negatif.TabIndex = 4;
            this.btn_Negatif.Text = "Negatif";
            this.btn_Negatif.UseVisualStyleBackColor = true;
            this.btn_Negatif.Click += new System.EventHandler(this.btn_Negatif_Click);
            // 
            // btn_Pozitif
            // 
            this.btn_Pozitif.Location = new System.Drawing.Point(204, 12);
            this.btn_Pozitif.Name = "btn_Pozitif";
            this.btn_Pozitif.Size = new System.Drawing.Size(63, 23);
            this.btn_Pozitif.TabIndex = 5;
            this.btn_Pozitif.Text = "Pozitif";
            this.btn_Pozitif.UseVisualStyleBackColor = true;
            this.btn_Pozitif.Click += new System.EventHandler(this.btn_Pozitif_Click);
            // 
            // btn_Cıft
            // 
            this.btn_Cıft.Location = new System.Drawing.Point(273, 12);
            this.btn_Cıft.Name = "btn_Cıft";
            this.btn_Cıft.Size = new System.Drawing.Size(37, 23);
            this.btn_Cıft.TabIndex = 6;
            this.btn_Cıft.Text = "Çift";
            this.btn_Cıft.UseVisualStyleBackColor = true;
            this.btn_Cıft.Click += new System.EventHandler(this.btn_Cıft_Click);
            // 
            // btn_Tek
            // 
            this.btn_Tek.Location = new System.Drawing.Point(316, 12);
            this.btn_Tek.Name = "btn_Tek";
            this.btn_Tek.Size = new System.Drawing.Size(37, 23);
            this.btn_Tek.TabIndex = 7;
            this.btn_Tek.Text = "Tek";
            this.btn_Tek.UseVisualStyleBackColor = true;
            this.btn_Tek.Click += new System.EventHandler(this.btn_Tek_Click);
            // 
            // btn_EnKucuk
            // 
            this.btn_EnKucuk.Location = new System.Drawing.Point(359, 12);
            this.btn_EnKucuk.Name = "btn_EnKucuk";
            this.btn_EnKucuk.Size = new System.Drawing.Size(63, 23);
            this.btn_EnKucuk.TabIndex = 8;
            this.btn_EnKucuk.Text = "En Küçük";
            this.btn_EnKucuk.UseVisualStyleBackColor = true;
            this.btn_EnKucuk.Click += new System.EventHandler(this.btn_EnKucuk_Click);
            // 
            // btn_EnBuyuk
            // 
            this.btn_EnBuyuk.Location = new System.Drawing.Point(428, 12);
            this.btn_EnBuyuk.Name = "btn_EnBuyuk";
            this.btn_EnBuyuk.Size = new System.Drawing.Size(63, 23);
            this.btn_EnBuyuk.TabIndex = 9;
            this.btn_EnBuyuk.Text = "En Büyük";
            this.btn_EnBuyuk.UseVisualStyleBackColor = true;
            this.btn_EnBuyuk.Click += new System.EventHandler(this.btn_EnBuyuk_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 225);
            this.listBox1.TabIndex = 10;
            // 
            // btn_KacTane
            // 
            this.btn_KacTane.Location = new System.Drawing.Point(497, 12);
            this.btn_KacTane.Name = "btn_KacTane";
            this.btn_KacTane.Size = new System.Drawing.Size(63, 23);
            this.btn_KacTane.TabIndex = 11;
            this.btn_KacTane.Text = "Kaç Tane";
            this.btn_KacTane.UseVisualStyleBackColor = true;
            this.btn_KacTane.Click += new System.EventHandler(this.btn_KacTane_Click);
            // 
            // btn_Alfabetik
            // 
            this.btn_Alfabetik.Location = new System.Drawing.Point(135, 41);
            this.btn_Alfabetik.Name = "btn_Alfabetik";
            this.btn_Alfabetik.Size = new System.Drawing.Size(66, 23);
            this.btn_Alfabetik.TabIndex = 12;
            this.btn_Alfabetik.Text = "Alfabetik";
            this.btn_Alfabetik.UseVisualStyleBackColor = true;
            this.btn_Alfabetik.Click += new System.EventHandler(this.btn_Alfabetik_Click);
            // 
            // btn_AlfabetikTers
            // 
            this.btn_AlfabetikTers.Location = new System.Drawing.Point(207, 41);
            this.btn_AlfabetikTers.Name = "btn_AlfabetikTers";
            this.btn_AlfabetikTers.Size = new System.Drawing.Size(80, 23);
            this.btn_AlfabetikTers.TabIndex = 13;
            this.btn_AlfabetikTers.Text = "AlfabetikTers";
            this.btn_AlfabetikTers.UseVisualStyleBackColor = true;
            this.btn_AlfabetikTers.Click += new System.EventHandler(this.btn_AlfabetikTers_Click);
            // 
            // btn_Uzunluklar
            // 
            this.btn_Uzunluklar.Location = new System.Drawing.Point(293, 41);
            this.btn_Uzunluklar.Name = "btn_Uzunluklar";
            this.btn_Uzunluklar.Size = new System.Drawing.Size(68, 23);
            this.btn_Uzunluklar.TabIndex = 14;
            this.btn_Uzunluklar.Text = "Uzunluklar";
            this.btn_Uzunluklar.UseVisualStyleBackColor = true;
            this.btn_Uzunluklar.Click += new System.EventHandler(this.btn_Uzunluklar_Click);
            // 
            // btn_tBarındıran
            // 
            this.btn_tBarındıran.Location = new System.Drawing.Point(374, 41);
            this.btn_tBarındıran.Name = "btn_tBarındıran";
            this.btn_tBarındıran.Size = new System.Drawing.Size(82, 23);
            this.btn_tBarındıran.TabIndex = 15;
            this.btn_tBarındıran.Text = "t Barındıran";
            this.btn_tBarındıran.UseVisualStyleBackColor = true;
            this.btn_tBarındıran.Click += new System.EventHandler(this.btn_tBarındıran_Click);
            // 
            // btn_cileBaslayan
            // 
            this.btn_cileBaslayan.Location = new System.Drawing.Point(462, 41);
            this.btn_cileBaslayan.Name = "btn_cileBaslayan";
            this.btn_cileBaslayan.Size = new System.Drawing.Size(90, 23);
            this.btn_cileBaslayan.TabIndex = 16;
            this.btn_cileBaslayan.Text = "ç ile baslayan";
            this.btn_cileBaslayan.UseVisualStyleBackColor = true;
            this.btn_cileBaslayan.Click += new System.EventHandler(this.btn_cileBaslayan_Click);
            // 
            // btn_SadeceTarihler
            // 
            this.btn_SadeceTarihler.Location = new System.Drawing.Point(135, 70);
            this.btn_SadeceTarihler.Name = "btn_SadeceTarihler";
            this.btn_SadeceTarihler.Size = new System.Drawing.Size(90, 23);
            this.btn_SadeceTarihler.TabIndex = 17;
            this.btn_SadeceTarihler.Text = "Sadece Tarihler";
            this.btn_SadeceTarihler.UseVisualStyleBackColor = true;
            this.btn_SadeceTarihler.Click += new System.EventHandler(this.btn_SadeceTarihler_Click);
            // 
            // btn_Son5
            // 
            this.btn_Son5.Location = new System.Drawing.Point(289, 70);
            this.btn_Son5.Name = "btn_Son5";
            this.btn_Son5.Size = new System.Drawing.Size(50, 23);
            this.btn_Son5.TabIndex = 19;
            this.btn_Son5.Text = "Son 5";
            this.btn_Son5.UseVisualStyleBackColor = true;
            this.btn_Son5.Click += new System.EventHandler(this.btn_Son5_Click);
            // 
            // btn_Ilk5
            // 
            this.btn_Ilk5.Location = new System.Drawing.Point(231, 70);
            this.btn_Ilk5.Name = "btn_Ilk5";
            this.btn_Ilk5.Size = new System.Drawing.Size(52, 23);
            this.btn_Ilk5.TabIndex = 18;
            this.btn_Ilk5.Text = "İlk 5";
            this.btn_Ilk5.UseVisualStyleBackColor = true;
            this.btn_Ilk5.Click += new System.EventHandler(this.btn_Ilk5_Click);
            // 
            // btn_YangWang
            // 
            this.btn_YangWang.Location = new System.Drawing.Point(345, 70);
            this.btn_YangWang.Name = "btn_YangWang";
            this.btn_YangWang.Size = new System.Drawing.Size(90, 23);
            this.btn_YangWang.TabIndex = 20;
            this.btn_YangWang.Text = "Yang Wang";
            this.btn_YangWang.UseVisualStyleBackColor = true;
            this.btn_YangWang.Click += new System.EventHandler(this.btn_YangWang_Click);
            // 
            // btn_SiparisSayisi
            // 
            this.btn_SiparisSayisi.Location = new System.Drawing.Point(441, 70);
            this.btn_SiparisSayisi.Name = "btn_SiparisSayisi";
            this.btn_SiparisSayisi.Size = new System.Drawing.Size(90, 23);
            this.btn_SiparisSayisi.TabIndex = 21;
            this.btn_SiparisSayisi.Text = "Sipariş Sayısı";
            this.btn_SiparisSayisi.UseVisualStyleBackColor = true;
            this.btn_SiparisSayisi.Click += new System.EventHandler(this.btn_SiparisSayisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 343);
            this.Controls.Add(this.btn_SiparisSayisi);
            this.Controls.Add(this.btn_YangWang);
            this.Controls.Add(this.btn_Son5);
            this.Controls.Add(this.btn_Ilk5);
            this.Controls.Add(this.btn_SadeceTarihler);
            this.Controls.Add(this.btn_cileBaslayan);
            this.Controls.Add(this.btn_tBarındıran);
            this.Controls.Add(this.btn_Uzunluklar);
            this.Controls.Add(this.btn_AlfabetikTers);
            this.Controls.Add(this.btn_Alfabetik);
            this.Controls.Add(this.btn_KacTane);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_EnBuyuk);
            this.Controls.Add(this.btn_EnKucuk);
            this.Controls.Add(this.btn_Tek);
            this.Controls.Add(this.btn_Cıft);
            this.Controls.Add(this.btn_Pozitif);
            this.Controls.Add(this.btn_Negatif);
            this.Controls.Add(this.btn_AllNumbers);
            this.Controls.Add(this.btn_AllNames);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_AllOrders);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AllOrders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AllNames;
        private System.Windows.Forms.Button btn_AllNumbers;
        private System.Windows.Forms.Button btn_Negatif;
        private System.Windows.Forms.Button btn_Pozitif;
        private System.Windows.Forms.Button btn_Cıft;
        private System.Windows.Forms.Button btn_Tek;
        private System.Windows.Forms.Button btn_EnKucuk;
        private System.Windows.Forms.Button btn_EnBuyuk;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_KacTane;
        private System.Windows.Forms.Button btn_Alfabetik;
        private System.Windows.Forms.Button btn_AlfabetikTers;
        private System.Windows.Forms.Button btn_Uzunluklar;
        private System.Windows.Forms.Button btn_tBarındıran;
        private System.Windows.Forms.Button btn_cileBaslayan;
        private System.Windows.Forms.Button btn_SadeceTarihler;
        private System.Windows.Forms.Button btn_Son5;
        private System.Windows.Forms.Button btn_Ilk5;
        private System.Windows.Forms.Button btn_YangWang;
        private System.Windows.Forms.Button btn_SiparisSayisi;
    }
}

