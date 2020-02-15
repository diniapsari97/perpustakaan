namespace perpustakaan
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CBBUKU = new System.Windows.Forms.ComboBox();
            this.CBJENIS = new System.Windows.Forms.ComboBox();
            this.TBJUDUL = new System.Windows.Forms.TextBox();
            this.TBPENERBIT = new System.Windows.Forms.TextBox();
            this.TBPENGARANG = new System.Windows.Forms.TextBox();
            this.TBDESKRIPSI = new System.Windows.Forms.TextBox();
            this.TBHARGA = new System.Windows.Forms.TextBox();
            this.TBJUMLAH = new System.Windows.Forms.TextBox();
            this.btnkembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Jenis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Judul";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pengarang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Penerbit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Jumlah";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Harga";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Deskripsi";
            // 
            // CBBUKU
            // 
            this.CBBUKU.FormattingEnabled = true;
            this.CBBUKU.Location = new System.Drawing.Point(151, 30);
            this.CBBUKU.Name = "CBBUKU";
            this.CBBUKU.Size = new System.Drawing.Size(121, 21);
            this.CBBUKU.TabIndex = 8;
            this.CBBUKU.SelectedIndexChanged += new System.EventHandler(this.CBBUKU_SelectedIndexChanged);
            // 
            // CBJENIS
            // 
            this.CBJENIS.FormattingEnabled = true;
            this.CBJENIS.Location = new System.Drawing.Point(151, 57);
            this.CBJENIS.Name = "CBJENIS";
            this.CBJENIS.Size = new System.Drawing.Size(121, 21);
            this.CBJENIS.TabIndex = 9;
            this.CBJENIS.SelectedIndexChanged += new System.EventHandler(this.CBJENIS_SelectedIndexChanged);
            // 
            // TBJUDUL
            // 
            this.TBJUDUL.Location = new System.Drawing.Point(151, 84);
            this.TBJUDUL.Name = "TBJUDUL";
            this.TBJUDUL.Size = new System.Drawing.Size(199, 20);
            this.TBJUDUL.TabIndex = 10;
            // 
            // TBPENERBIT
            // 
            this.TBPENERBIT.Location = new System.Drawing.Point(151, 136);
            this.TBPENERBIT.Name = "TBPENERBIT";
            this.TBPENERBIT.Size = new System.Drawing.Size(199, 20);
            this.TBPENERBIT.TabIndex = 11;
            // 
            // TBPENGARANG
            // 
            this.TBPENGARANG.Location = new System.Drawing.Point(151, 110);
            this.TBPENGARANG.Name = "TBPENGARANG";
            this.TBPENGARANG.Size = new System.Drawing.Size(199, 20);
            this.TBPENGARANG.TabIndex = 12;
            // 
            // TBDESKRIPSI
            // 
            this.TBDESKRIPSI.Location = new System.Drawing.Point(151, 214);
            this.TBDESKRIPSI.Name = "TBDESKRIPSI";
            this.TBDESKRIPSI.Size = new System.Drawing.Size(199, 20);
            this.TBDESKRIPSI.TabIndex = 13;
            // 
            // TBHARGA
            // 
            this.TBHARGA.Location = new System.Drawing.Point(151, 188);
            this.TBHARGA.Name = "TBHARGA";
            this.TBHARGA.Size = new System.Drawing.Size(199, 20);
            this.TBHARGA.TabIndex = 14;
            // 
            // TBJUMLAH
            // 
            this.TBJUMLAH.Location = new System.Drawing.Point(151, 162);
            this.TBJUMLAH.Name = "TBJUMLAH";
            this.TBJUMLAH.Size = new System.Drawing.Size(199, 20);
            this.TBJUMLAH.TabIndex = 15;
            // 
            // btnkembali
            // 
            this.btnkembali.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnkembali.Location = new System.Drawing.Point(197, 260);
            this.btnkembali.Name = "btnkembali";
            this.btnkembali.Size = new System.Drawing.Size(75, 50);
            this.btnkembali.TabIndex = 16;
            this.btnkembali.Text = "Kembali";
            this.btnkembali.UseVisualStyleBackColor = false;
            this.btnkembali.Click += new System.EventHandler(this.btnkembali_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(415, 436);
            this.Controls.Add(this.btnkembali);
            this.Controls.Add(this.TBJUMLAH);
            this.Controls.Add(this.TBHARGA);
            this.Controls.Add(this.TBDESKRIPSI);
            this.Controls.Add(this.TBPENGARANG);
            this.Controls.Add(this.TBPENERBIT);
            this.Controls.Add(this.TBJUDUL);
            this.Controls.Add(this.CBJENIS);
            this.Controls.Add(this.CBBUKU);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "DATA BUKU";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CBBUKU;
        private System.Windows.Forms.ComboBox CBJENIS;
        private System.Windows.Forms.TextBox TBJUDUL;
        private System.Windows.Forms.TextBox TBPENERBIT;
        private System.Windows.Forms.TextBox TBPENGARANG;
        private System.Windows.Forms.TextBox TBDESKRIPSI;
        private System.Windows.Forms.TextBox TBHARGA;
        private System.Windows.Forms.TextBox TBJUMLAH;
        private System.Windows.Forms.Button btnkembali;
    }
}