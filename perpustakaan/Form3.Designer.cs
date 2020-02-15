namespace perpustakaan
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ITEM = new System.Windows.Forms.TextBox();
            this.KEMBALI = new System.Windows.Forms.TextBox();
            this.DIBAYAR = new System.Windows.Forms.TextBox();
            this.TOTAL = new System.Windows.Forms.TextBox();
            this.TELP = new System.Windows.Forms.TextBox();
            this.NAMA = new System.Windows.Forms.TextBox();
            this.CBFAKTUR = new System.Windows.Forms.ComboBox();
            this.tbharga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNKEMBALI = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Faktur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Pembeli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "No Telfon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dibayar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kembali";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Item";
            // 
            // ITEM
            // 
            this.ITEM.Location = new System.Drawing.Point(147, 165);
            this.ITEM.Name = "ITEM";
            this.ITEM.Size = new System.Drawing.Size(100, 20);
            this.ITEM.TabIndex = 9;
            this.ITEM.TextChanged += new System.EventHandler(this.ITEM_TextChanged);
            // 
            // KEMBALI
            // 
            this.KEMBALI.Location = new System.Drawing.Point(147, 260);
            this.KEMBALI.Name = "KEMBALI";
            this.KEMBALI.Size = new System.Drawing.Size(100, 20);
            this.KEMBALI.TabIndex = 11;
            // 
            // DIBAYAR
            // 
            this.DIBAYAR.Location = new System.Drawing.Point(147, 229);
            this.DIBAYAR.Name = "DIBAYAR";
            this.DIBAYAR.Size = new System.Drawing.Size(100, 20);
            this.DIBAYAR.TabIndex = 12;
            this.DIBAYAR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DIBAYAR_KeyDown);
            // 
            // TOTAL
            // 
            this.TOTAL.Location = new System.Drawing.Point(147, 199);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(100, 20);
            this.TOTAL.TabIndex = 13;
            // 
            // TELP
            // 
            this.TELP.Location = new System.Drawing.Point(147, 114);
            this.TELP.Name = "TELP";
            this.TELP.Size = new System.Drawing.Size(100, 20);
            this.TELP.TabIndex = 14;
            // 
            // NAMA
            // 
            this.NAMA.Location = new System.Drawing.Point(147, 82);
            this.NAMA.Name = "NAMA";
            this.NAMA.Size = new System.Drawing.Size(100, 20);
            this.NAMA.TabIndex = 15;
            this.NAMA.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // CBFAKTUR
            // 
            this.CBFAKTUR.FormattingEnabled = true;
            this.CBFAKTUR.Location = new System.Drawing.Point(147, 47);
            this.CBFAKTUR.Name = "CBFAKTUR";
            this.CBFAKTUR.Size = new System.Drawing.Size(100, 21);
            this.CBFAKTUR.TabIndex = 17;
            this.CBFAKTUR.SelectedIndexChanged += new System.EventHandler(this.CBFAKTUR_SelectedIndexChanged);
            // 
            // tbharga
            // 
            this.tbharga.Location = new System.Drawing.Point(147, 139);
            this.tbharga.Name = "tbharga";
            this.tbharga.Size = new System.Drawing.Size(100, 20);
            this.tbharga.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Harga";
            // 
            // BTNKEMBALI
            // 
            this.BTNKEMBALI.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNKEMBALI.Location = new System.Drawing.Point(314, 117);
            this.BTNKEMBALI.Name = "BTNKEMBALI";
            this.BTNKEMBALI.Size = new System.Drawing.Size(114, 42);
            this.BTNKEMBALI.TabIndex = 20;
            this.BTNKEMBALI.Text = "KEMBALI";
            this.BTNKEMBALI.UseVisualStyleBackColor = false;
            this.BTNKEMBALI.Click += new System.EventHandler(this.BTNKEMBALI_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(314, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 44);
            this.button1.TabIndex = 21;
            this.button1.Text = "DATA DETAIL TRANSAKSI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(498, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNKEMBALI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbharga);
            this.Controls.Add(this.CBFAKTUR);
            this.Controls.Add(this.NAMA);
            this.Controls.Add(this.TELP);
            this.Controls.Add(this.TOTAL);
            this.Controls.Add(this.DIBAYAR);
            this.Controls.Add(this.KEMBALI);
            this.Controls.Add(this.ITEM);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Data Transaksi";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ITEM;
        private System.Windows.Forms.TextBox KEMBALI;
        private System.Windows.Forms.TextBox DIBAYAR;
        private System.Windows.Forms.TextBox TOTAL;
        private System.Windows.Forms.TextBox TELP;
        private System.Windows.Forms.TextBox NAMA;
        private System.Windows.Forms.ComboBox CBFAKTUR;
        private System.Windows.Forms.TextBox tbharga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNKEMBALI;
        private System.Windows.Forms.Button button1;
    }
}