using System;

namespace BenzersizSayiOdeviNTP
{
    class Program
    {
        static void Main(string[] args)
        {
            char cevap;
            Random rnd = new Random();
            int sayi, knt = 1, minsay, maxsay, knt2;
            Console.Title = "Benzersiz Sayı Üretme Programı";
            do
            {
                do//exception hatası almamak için do while döngüsü kullanıldı
                {
                    Console.Write("Üretilecek sayı adedini giriniz:");
                    sayi = int.Parse(Console.ReadLine());
                    Console.Write("Sayı aralığı için minimum değer seçiniz:");
                    minsay = int.Parse(Console.ReadLine());
                    Console.Write("Sayı aralığı için maximum değer seçiniz:");
                    maxsay = int.Parse(Console.ReadLine());
                    knt2 = maxsay - minsay; //sayı aralığı ile üretilecek sayı adedinin karşılaştırması için
                    if (knt2 < sayi)
                    {
                        Console.WriteLine("Seçilen değer aralığında " + sayi + " adet sayı üretilemez!!! " +
                            "\nLütfen tekrar giriş yapın.");
                    }
                } while (knt2 < sayi);

                int[] sayilar = new int[sayi];

                for (int i = 0; i < sayilar.Length; i++)// diziye değer atamaları için for döngüsü kullanıldı
                {
                    sayilar[i] = rnd.Next(minsay, maxsay);// diziye değer atamaları yapılır
                }

                while (knt < sayi)//Diziye atanan değerlerin kontrolü ve düzenlenmesi için while döngüsü kullanıldı
                {
                    if (sayilar[knt] == sayilar[knt - 1])//index numarası knt ve knt-1 olan sayıyı karşılaştırır
                    {
                        while (sayilar[knt] == sayilar[knt - 1])//index numarası knt ve knt-1 olan sayıların eşitliği bozulana kadar tekrar değer verir
                        {
                            sayilar[knt - 1] = rnd.Next(minsay, maxsay);// knt-1 index numaralı sayının değeri değiştirilir
                        }
                        knt = 0; //kontrolun tekrarlanması için knt numarası sıfırlanır. while bloğundan çıkıldığında değer 1 arttırıldığı için burada 0 verildi.
                    }
                    knt++; //döngü sağlanması için knt değeri 1 arttırıldı
                    Array.Sort(sayilar); // knt-1 index numaralı sayının değişmiş olması ihtimaline karşın dizi sıralaması tekrar yapılır
                }

                Console.WriteLine("\n{0,-5} {1,-5}", "Sıra", "Değer");
                for (int i = 1; i < sayilar.Length; i++)
                {
                    Console.WriteLine("{0,-5} {1,-5}", i, sayilar[i]);// dizinin yazdırılması
                }

                /*
                for (int i = 1; i < sayilar.Length; i++)
                {
                    Console.WriteLine("Üretilen " + i + ". Sayı: " + sayilar[i] );// dizinin yazdırılması
                }
                */
                Console.WriteLine("\n///////////\nTekrar üretmek için " + "E" + " \nÇıkış için herhangi bir tuşa basın.");
                cevap = char.Parse(Console.ReadLine().ToLower());
                Console.Clear();
            } while (cevap == 'e'); //Programın otomatik kapanmaması için do while döngüsü kullanıldı
        }
    }
}