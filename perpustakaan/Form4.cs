using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace perpustakaan
{
    public partial class Form4 : Form
    {
       

        public Form4()
        {
            InitializeComponent();
        }

       

        void tampildata()
        {
            comboBox1.Items.Add("F001");
            comboBox1.Items.Add("F002");
            comboBox1.Items.Add("F003");
            comboBox1.Items.Add("F004");
            comboBox1.Items.Add("F005");
            combokode.Items.Add("B001");
            combokode.Items.Add("B002");
            combokode.Items.Add("B003");
            combokode.Items.Add("B004");
            combokode.Items.Add("B005");

        }
        private void Form4_Load(object sender, EventArgs e)
        {

         
            tampildata();
            kolom();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "F001")
            {

                tbjual.Text = "RP 5000";
                tbtotal.Text = "RP 25000";
              
            }
            if (comboBox1.Text == "F002")
            {
                tbjual.Text = "RP 70000";
                tbtotal.Text = "RP 70000";

            }
            if (comboBox1.Text == "F003")
            {
                tbjual.Text = "RP 2000";
                tbtotal.Text = "RP 4000";

            }
            if (comboBox1.Text == "F004")
            {
                tbjual.Text = "RP 15000";
                tbtotal.Text = "RP 150000";

            }
            if (comboBox1.Text == "F005")
            {
                tbjual.Text = "RP 100000";
                tbtotal.Text = "RP 300000";

            }
        }

        private void combokode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combokode.Text == "B001")
            {

                tbjudul.Text = "DOLAN";
                tbjumlah.Text = "5";

            }
            if (combokode.Text == "B002")
            {
                tbjudul.Text = "TIMUN SURI";
                tbjumlah.Text = "1";

            }
            if (combokode.Text == "B003")
            {
                tbjudul.Text = "GANTENG-GANTENG KO GALAK";
                tbjumlah.Text = "2";

            }
            if (combokode.Text == "B004")
            {
                tbjudul.Text = "ASSALAMUALAIKUM TONY";
                tbjumlah.Text = "10";

            }
            if (combokode.Text == "B005")
            {
                tbjudul.Text = "ADANUR";
                tbjumlah.Text = "3";

            }

        }

        void kolom()
        {
            dgv4.Columns.Add("0", "NO FAKTUR");
            dgv4.Columns.Add("1", "KODE BUKU");
            dgv4.Columns.Add("2", "JUDUL");
            dgv4.Columns.Add("3", "JUMLAH");
            dgv4.Columns.Add("4", "HARGA JUAL");
            dgv4.Columns.Add("5", "TOTAL");
     
        }

        private void BTNSIMPAN_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || combokode.Text == "")
            {
                MessageBox.Show("maaf data belum lengkap");
            }
            else
            {
                string[] baris = new string[] { comboBox1.Text, combokode.Text, tbjudul.Text, tbjumlah.Text, tbjual.Text, tbtotal.Text };
                dgv4.Rows.Add(baris);
                MessageBox.Show("data berhasil disimpan");
            }
        }

        private void dgv4_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
    }
}
