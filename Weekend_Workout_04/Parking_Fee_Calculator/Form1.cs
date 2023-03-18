using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Fee_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.SelectedIndex = 0; // Form yüklenirken combox seçili değeri 0. index Araba olarak seçtik.
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double saat, yuzde, ucret; // saat yüzde ve ücret değişkenleri tanımladık
            if (nudSaat.Value >= 1) // numericUpDown dan seçilen değer 1e büyük eşitmi ? 
            {
                saat = double.Parse(nudSaat.Value.ToString()); // saat değişkenine nudSaat değerini double olarak atıyoruz .. Çünkü saat değişkenimiz double tanımlandı ama nud decimal döndürüyor..

                // Ücret Açıklamaları  " 1 " saat üzerinden yazıyor olacağım..
                // Saat*yuzde ( 1*0.20 ) = 0.20 döndürüyor 10 * 0.20 2 vereceği için 10 ile çarpmadan + 1 ekleyerek 1.20 değerini elde ediyor ve 10 ile çarparak 12 tl sonucunu aldırıyoruz..
                if (comboBox1.SelectedIndex == 0) //  Combobox'ın Seçilen index'i 0 ise yani araba ise alttaki kod çalışacak..
                {
                    yuzde = 00.20; // araba için saatlik yüzde artışı %20 bu yüzden direk tanımladık.
                    ucret = 10 * (1 + (saat * yuzde));
                    MessageBox.Show($"Araç Tipiniz : {comboBox1.SelectedItem}\r\nOtopark Süreniz : {saat} saat\r\nOtopark Ücreti : {ucret} ₺ 'dir.");
                }
                else if (comboBox1.SelectedIndex == 1)  //  Combobox'ın Seçilen index'i 1 ise yani minibüs ise alttaki kod çalışacak..
                {
                    yuzde = 0.25; // minibüs için saatlik yüzde artışı %25 bu yüzden direk tanımladık.
                    ucret = 15 * (1 + (saat * yuzde));
                    MessageBox.Show($"Araç Tipiniz : {comboBox1.SelectedItem}\r\nOtopark Süreniz : {saat} saat\r\nOtopark Ücreti : {ucret} ₺ 'dir.");
                }
                else if (comboBox1.SelectedIndex == 2)  //  Combobox'ın Seçilen index'i 2 ise yani ticari ise alttaki kod çalışacak..
                {
                    yuzde = 0.30; // ticari için saatlik yüzde artışı %30 bu yüzden direk tanımladık.
                    ucret = 20 * (1 + (saat * yuzde));
                    MessageBox.Show($"Araç Tipiniz : {comboBox1.SelectedItem}\r\nOtopark Süreniz : {saat} saat\r\nOtopark Ücreti : {ucret} ₺ 'dir.");
                }

            }
            else // eğer nudSaat 1 e büyük eşit değilse hata mesajı verdiriyoruz
            {
                MessageBox.Show("Otopark Süresi Minimum 1 Saat Olmalıdır. Lütfen Tekrar Giriniz..");
            }

        }
    }
}
