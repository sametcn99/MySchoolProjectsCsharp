using System;

namespace forwhiledonguler9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Bir sayı giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            while (sayi <= 100)
            {
                if (sayi % 2 == 1)
                    toplam += sayi;
                sayi++;
            }
            Console.WriteLine("Girdiğiniz Sayı ile 100 Arasındaki Tek Sayıların Toplamı:" + toplam);
            Console.ReadKey();
        }
    }
}
