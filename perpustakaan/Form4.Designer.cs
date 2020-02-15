namespace perpustakaan
{
    partial class Form4
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.combokode = new System.Windows.Forms.ComboBox();
            this.tbjudul = new System.Windows.Forms.TextBox();
            this.tbjual = new System.Windows.Forms.TextBox();
            this.tbjumlah = new System.Windows.Forms.TextBox();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.dgv4 = new System.Windows.Forms.DataGridView();
            this.BTNSIMPAN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Faktur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Judul";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga Jual";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(207, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // combokode
            // 
            this.combokode.FormattingEnabled = true;
            this.combokode.Location = new System.Drawing.Point(207, 79);
            this.combokode.Name = "combokode";
            this.combokode.Size = new System.Drawing.Size(100, 21);
            this.combokode.TabIndex = 7;
            this.combokode.SelectedIndexChanged += new System.EventHandler(this.combokode_SelectedIndexChanged);
            // 
            // tbjudul
            // 
            this.tbjudul.Location = new System.Drawing.Point(207, 119);
            this.tbjudul.Name = "tbjudul";
            this.tbjudul.Size = new System.Drawing.Size(179, 20);
            this.tbjudul.TabIndex = 8;
            // 
            // tbjual
            // 
            this.tbjual.Location = new System.Drawing.Point(207, 190);
            this.tbjual.Name = "tbjual";
            this.tbjual.Size = new System.Drawing.Size(179, 20);
            this.tbjual.TabIndex = 9;
            // 
            // tbjumlah
            // 
            this.tbjumlah.Location = new System.Drawing.Point(207, 148);
            this.tbjumlah.Name = "tbjumlah";
            this.tbjumlah.Size = new System.Drawing.Size(179, 20);
            this.tbjumlah.TabIndex = 10;
            // 
            // tbtotal
            // 
            this.tbtotal.Location = new System.Drawing.Point(207, 225);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.Size = new System.Drawing.Size(179, 20);
            this.tbtotal.TabIndex = 11;
            // 
            // dgv4
            // 
            this.dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv4.Location = new System.Drawing.Point(29, 269);
            this.dgv4.Name = "dgv4";
            this.dgv4.Size = new System.Drawing.Size(469, 187);
            this.dgv4.TabIndex = 12;
            this.dgv4.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv4_CellMouseClick);
            // 
            // BTNSIMPAN
            // 
            this.BTNSIMPAN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTNSIMPAN.Location = new System.Drawing.Point(423, 155);
            this.BTNSIMPAN.Name = "BTNSIMPAN";
            this.BTNSIMPAN.Size = new System.Drawing.Size(97, 51);
            this.BTNSIMPAN.TabIndex = 13;
            this.BTNSIMPAN.Text = "SIMPAN";
            this.BTNSIMPAN.UseVisualStyleBackColor = false;
            this.BTNSIMPAN.Click += new System.EventHandler(this.BTNSIMPAN_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(532, 488);
            this.Controls.Add(this.BTNSIMPAN);
            this.Controls.Add(this.dgv4);
            this.Controls.Add(this.tbtotal);
            this.Controls.Add(this.tbjumlah);
            this.Controls.Add(this.tbjual);
            this.Controls.Add(this.tbjudul);
            this.Controls.Add(this.combokode);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "DATA DETAIL TRANSAKSI";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox combokode;
        private System.Windows.Forms.TextBox tbjudul;
        private System.Windows.Forms.TextBox tbjual;
        private System.Windows.Forms.TextBox tbjumlah;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.DataGridView dgv4;
        private System.Windows.Forms.Button BTNSIMPAN;
    }
}