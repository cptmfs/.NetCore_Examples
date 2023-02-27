using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EmeklilikHesaplama
{
    internal class Program
    {

        //Erkeklerin 25 yıl, kadınların da 20 yıl çalıştıktan sonra emekli olacağı varsayılan bir ortamda, klavyeden girilen cinsiyet ve sigorta prim gün sayısına göre kişinin emekliliğine ne kadar süresi kaldığını bulan metodunu yazınız.

        // Açıklama: 1 yıl = 360 gün 1 ay = 30 gün  Baz alınacaktır.
        // Örnek: 1943 gün = 5 yıl 4 ay 23 gün , Bu örnekteki metoda cinsiyet parametresi de ekleyerek, buna göre sonucu ekrana yazdırınız.
        //Örnek: Erkek ve 6643 gün parametreleri girildiğinde "Emekliliğinize 6 yıl 6 ay 17 gün kaldı" şeklinde sonuç döndürecek.

        static void Main(string[] args)
        {
            emekliHesapla();

            Console.ReadLine();
        }
        private static void calismaSureHesapla()
        {

        }
        private static void emekliHesapla()
        {
            Console.WriteLine("Lütfen Cinsiyet Bilgisi Giriniz : ");
            string cinsiyet = Console.ReadLine();
            Console.WriteLine("Lütfen Sigorta Prim Gününüzü Giriniz :");
            int sgk = Convert.ToInt32(Console.ReadLine());

            int yil = (sgk / 360);
            int yilYuvarla = sgk - (yil * 360);
            int ay = (sgk - (yil * 360)) / 30;
            int gun = yilYuvarla - (ay * 30);

            Console.WriteLine("Çalışma Süreniz : {0}",(yil + "yil , " + ay + "ay , " + gun + "gün'dür.."));

            if (cinsiyet == "E")
            {
                if (sgk>=9000)
                {
                    Console.WriteLine("Çalışmalarınızdan dolayı tebrik ederiz. Emekliliğin tadını çıkarın beyfendii ... ");
                }
                else if (sgk<9000)
                {
                    int kalanGun = 9000 - sgk;
                    int yil1 = (kalanGun / 360);
                    int yilYuvarla1 = kalanGun - (yil1 * 360);
                    int ay1 = ((kalanGun - (yil1 * 360)) / 30);
                    int gun1 = yilYuvarla1 - (ay1 * 30);
                    Console.WriteLine("Emekli Olmanız İçin Gereken Prim Gün Sayısı : {0}\nEmeklili olmanıza kalan Süre : {1} 'dür..\nSabredin Günler Çabuk Geçip Gider ,\nÇalışmak ise Vücudu Dinç Eyler...  ", kalanGun, (yil1 + "yil," + ay1 + "ay," + gun1 + "gun"));
                }
            }
            else if (cinsiyet == "K")
            {
                if (sgk >= 7200)
                {
                    Console.WriteLine("Çalışmalarınızdan dolayı tebrik ederiz. Emekliliğin tadını çıkarın hanımefendii ... ");
                }
                else if (sgk<7200)
                {
                    int kalanGun = 7200 - sgk;
                    int yil1 = (kalanGun / 360);
                    int yilYuvarla1 = kalanGun - (yil1 * 360);
                    int ay1 = (kalanGun - (yil1 * 360)) / 30;
                    int gun1 = yilYuvarla1 - (ay1 * 30);
                    Console.WriteLine("Emekli Olmanız İçin Gereken Prim Gün Sayısı : {0}\nEmeklili olmanıza kalan Süre : {1} 'dür..\nSabredin Günler Çabuk Geçip Gider ,\nÇalışmak ise Vücudu Dinç Eyler...  ", kalanGun, (yil1 + "yil," + ay1 + "ay," + gun1 + "gun"));
                }
            }
        }
    }
}
