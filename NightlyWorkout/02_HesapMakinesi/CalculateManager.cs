using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace _02_HesapMakinesi
{
    public  class CalculateManager
    {
              public void Calculate4(HMakine hMakine)
                {
                if (hMakine.girilenDeger == "b")
                {
                    Console.WriteLine("\nBölme İşleminizi sonucu : " + (hMakine.sayi1 / hMakine.sayi2));
                }
                else if (hMakine.girilenDeger == "ç")
                {
                    Console.WriteLine("\nÇarpma İşleminizi sonucu : " + (hMakine.sayi1 * hMakine.sayi2));
                }
                else if (hMakine.girilenDeger == "t")
                {
                    Console.WriteLine("\nToplama İşleminizi sonucu : " + (hMakine.sayi1 + hMakine.sayi2));
                }
                else if (hMakine.girilenDeger == "e")
                {
                    Console.WriteLine("\nÇıkarma İşleminizi sonucu : " + (hMakine.sayi1 - hMakine.sayi2));
                }
                else
                {
                    Console.WriteLine("\nLütfen Geçerli bir İşlem degeri giriniz..");

                }

            }
        
       
    }
}
