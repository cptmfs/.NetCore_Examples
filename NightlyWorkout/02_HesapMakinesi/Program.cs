using _02_HesapMakinesi;

internal class Program
{
    private static void Main(string[] args)
    {
        //4 İşlem yapabilen Calculator Yapınız..


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