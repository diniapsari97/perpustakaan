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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void tampildata()
        {
            CBBUKU.Items.Add("B001");
            CBBUKU.Items.Add("B002");
            CBBUKU.Items.Add("B003");
            CBBUKU.Items.Add("B004");
            CBBUKU.Items.Add("B005");
            CBJENIS.Items.Add("J001");
            CBJENIS.Items.Add("J002");
            CBJENIS.Items.Add("J003");
            CBJENIS.Items.Add("J004");
            CBJENIS.Items.Add("J005");

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            tampildata();
        
        }

        private void CBBUKU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBUKU.Text == "B001")
            {
                TBJUDUL.Text = "DOLAN";
                TBPENGARANG.Text = "DIAN";
                TBPENERBIT.Text = "DINI APSARI";
                TBJUMLAH.Text = "5";
                TBHARGA.Text = "RP 5000";
              

            }
            if (CBBUKU.Text == "B002")
            {
                TBJUDUL.Text = "TIMUN SURI";
                TBPENGARANG.Text = "BILQIS";
                TBPENERBIT.Text = "SAAFAH ENJOY";
                TBJUMLAH.Text = "1";
                TBHARGA.Text = "RP 70000";
            

            }
            if (CBBUKU.Text == "B003")
            {
                TBJUDUL.Text = "GANTENG-GANTENG KO GALAK";
                TBPENGARANG.Text = "NUR";
                TBPENERBIT.Text = " LELA";
                TBJUMLAH.Text = "2";
                TBHARGA.Text = "RP 2000";
             
 
            }
            if (CBBUKU.Text == "B004")
            {
                TBJUDUL.Text = "ASSALAMUALAIKUM TONY";
                TBPENGARANG.Text = "DINI";
                TBPENERBIT.Text = "AURA KASIH";
                TBJUMLAH.Text = "10";
                TBHARGA.Text = "RP 15000";
             
 
            }
            if (CBBUKU.Text == "B005")
            {
                TBJUDUL.Text = "(A)DANUR";
                TBPENGARANG.Text = "TONO";
                TBPENERBIT.Text = "PURNOMO STAR";
                TBJUMLAH.Text = "3";
                TBHARGA.Text = "RP 100000";
              

            }
        }

        private void CBJENIS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBJENIS.Text == "J001")
            {

                TBDESKRIPSI.Text = "NOPEL";


            }
            if (CBJENIS.Text == "J002")
            {

                TBDESKRIPSI.Text = "DONGENK";
            }
            if (CBJENIS.Text == "J003")
            {

                TBDESKRIPSI.Text = "PIKSI";
            }
            if (CBJENIS.Text == "J004")
            {

                TBDESKRIPSI.Text = "ROMANCE";
            }
            if (CBJENIS.Text == "J005")
            {

                TBDESKRIPSI.Text = "HOROR";


            }
        }

           

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

