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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            tampildata();
        }

        void tampildata()
        {
            CBFAKTUR.Items.Add("F001");
            CBFAKTUR.Items.Add("F002");
            CBFAKTUR.Items.Add("F003");
            CBFAKTUR.Items.Add("F004");
            CBFAKTUR.Items.Add("F005");

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBFAKTUR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBFAKTUR.Text == "F001")
            {
                
                NAMA.Text = "DIAN";
                TELP.Text = "0218887";
                tbharga.Text = "5000";
            }
            if (CBFAKTUR.Text == "F002")
            {
                NAMA.Text = "DINI";
                TELP.Text = "0218887";
                tbharga.Text = "70000";
            }
            if (CBFAKTUR.Text == "F003")
            {
                NAMA.Text = "BILQIS";
                TELP.Text = "0218887";
                tbharga.Text = "2000";
            }
            if (CBFAKTUR.Text == "F004")
            {
                NAMA.Text = "SAFAAH";
                TELP.Text = "0218887";
                tbharga.Text = "15000";
            }
            if (CBFAKTUR.Text == "F005")
            {
                NAMA.Text = "NUR";
                TELP.Text = "0218887";
                tbharga.Text = "100000";
            }
        }

        double HARGA, TOTAL1, ITEM1, DIBAYAR1, KEMBALI1;






        private void btnsimpan_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 buku = new Form2();
            Form3 transaksi = new Form3();
            Form4 detail = new Form4();
            buku.Close();
            transaksi.Close();
            detail.Show();
        }

        private void BTNKEMBALI_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DIBAYAR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (DIBAYAR.Text == "")
                {
                    MessageBox.Show("PEMBAYARAN BELUM DI INPUT", "KONFIRMASI");
                }
                else
                {
                    DIBAYAR1 = Convert.ToInt32(DIBAYAR.Text);
                    if (TOTAL1 > DIBAYAR1)
                    {
                        MessageBox.Show("UANG PEMBAYARAN KURANG", "INFORMASI");
                    }
                    if (TOTAL1 < DIBAYAR1)
                    {
                        KEMBALI1 = DIBAYAR1 - TOTAL1;
                        KEMBALI.Text = Convert.ToString(KEMBALI1);
                    }
                    if (TOTAL1 == DIBAYAR1)
                    {
                        KEMBALI1 = DIBAYAR1 - TOTAL1;
                        KEMBALI.Text = Convert.ToString(KEMBALI1);
                    }


                }
            }
        }

        private void ITEM_TextChanged(object sender, EventArgs e)
        {
            if (ITEM.Text == "")
            {
                MessageBox.Show("INPUT QTY ANDA", "INFORMASI");
                TOTAL.Text = "0";
            }
            else
            {
                HARGA = Convert.ToInt32(tbharga.Text);
                ITEM1 = Convert.ToInt32(ITEM.Text);
                TOTAL1 = HARGA * ITEM1;
                TOTAL.Text = Convert.ToString(TOTAL1);
            }
        }
    }
}
