using _02_HesapMakinesi;

internal class Program
{
    private static void Main(string[] args)
    {
        //Kullanıcıdan alınan 2 sayıya yine kullanıcıdan alınacak işlem seçimine göre dört işlem uygulayan program kodunu yazınız. (Toplama için T veya t, Çıkartma için E/e, Çarpma için Ç/ç, Bölme için B/b kodlarını kullanınız. Eğer bu işlem kodları dışındaki girişler için hatalı giriş yapıldığına dair bir mesaj verdirebilirsiniz)

        //    int sayi1, sayi2;
        //    string girilenDeger;

        //    Console.WriteLine("Lütfen sayi1'i giriniz : ");
        //    sayi1 = Int32.Parse(Console.ReadLine());
        //    Console.WriteLine("Lütfen sayi2'yi giriniz : ");
        //    sayi2 = Int32.Parse(Console.ReadLine());
        //adim1:
        CalculateManager calculateManager = new CalculateManager();
        Console.WriteLine("\t\t---------------------Hesap Makinesi---------------------");
        Console.WriteLine("\n\nBilgisayar 1 ile 200 arası 2 adet rastgele sayı oluşturdu.\n");
        Random rnd = new Random();
        HMakine hMakine = new HMakine();
        hMakine.sayi1 = rnd.Next(1, 200);
        hMakine.sayi2 = rnd.Next(1, 200);
        Console.WriteLine($"Birinci Sayı :{hMakine.sayi1} ");
        Console.WriteLine($"\nİkinci Sayı : {hMakine.sayi2}" );

        Console.Write("\nBölme İşlemi için :b \nÇarpma İşlemi için :ç \nToplama İşlemi için :t \nÇıkarma İşlemi için :e tuşlayınız..\nLütfen yapmak istediğiniz işlemi tuşlayınız : ");
       
        
        hMakine.girilenDeger = Console.ReadLine();
        
        



        calculateManager.Calculate4(hMakine);





        Console.ReadKey();
    }

}