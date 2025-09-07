using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBiletUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad_soyad = tB_adsoyad.Text;
            string nereden = tB_nereden.Text;
            string nereye = tB_nereye.Text;
            string tarih = dT_tarih.Text;
            string saat = lB_saat.SelectedItem.ToString();
            bilet.Text = ad_soyad + " isimli yolcu " + tarih + " tarihinde saat " + saat + " itibariyle "
                 + nereden + " noktasından " + nereye + " noktasına yolculuk yapmak üzere bilet almıştır.";

        }
    }
}
