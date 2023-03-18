using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reverse__Printing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTers_Click(object sender, EventArgs e)
        {
            txtMetin.Clear();
            txtTers.Clear();    

            for (int i = 0; i < txtMetin.Text.Length; i++) // girilen metin harf sayısı kadar dönen bir for döngüsü
            {
                txtTers.Text = txtMetin.Text.Substring(i, 1) + txtTers.Text; // metni ters yazdıracağımız textbox'ın içine txtMetin'e girilen metnin ilk karakterini ekletiyourz. sonra for döngüsü tekrar dönünce 2. karakteri alıyor substring ile ve + txtTers.Text'in içerisinde ilk karakter olduğu için onun yanına ekliyor ve txtTers'e atama yapıyor.
            }
            // Örneğin ferit girildi txtMetin'e for döngüsü başlıyor ve substring ile f yi alıp txtTers'e atadı, 
            // 2. turda substring " e " harfini alıyor + txtTers ( içerisinde "f" var) "ef" olarak txtTers'e atadı,
            // son turda  substring " t " harfini alır + txtTers (içerisinde iref var ) t'nin ardına toplama işlemi ile ekleyince "tiref" olarak sonuç vermiş olacak.. 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
