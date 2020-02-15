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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 buku = new Form2();
            Form3 transaksi = new Form3();
            Form4 detail  = new Form4();
            buku.Show();
            transaksi.Close();
            detail.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 buku = new Form2();
            Form3 transaksi = new Form3();
            Form4 detail = new Form4();
            buku.Close();
            transaksi.Show();
            detail.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }
    }
}
