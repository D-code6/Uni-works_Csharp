using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            double fiyat = 0, tutar = 0;

            fiyat = Convert.ToDouble(textBox1.Text); // ürün fiyatı sayıya çevriliyor
            if(checkBox1.Checked == true) // KDV seçili ise
            {
                tutar = fiyat + (fiyat * 0.18); // ürün fiyatını %18 KDV eklendi

            }
            if(checkBox2.Checked == true) // %5 öğrenci indirimi seçili ise 
            {
                if(checkBox1.Checked == true) // KDV seçili ise
                {
                    tutar = tutar - (fiyat * 0.05); // fiyattan %5 öğrenci indirimi düşülür

                }
                else { tutar = fiyat - (fiyat * 0.05); } // KDV seçili değilse %5 indirimi ürün fiyatı üzerinden yap

                textBox2.Text = tutar.ToString(); // satış tutarını string e çevir ve yaz


            }
        }
    }
}
