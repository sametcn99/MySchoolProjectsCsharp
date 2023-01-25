using System;

namespace forwhiledonguler2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            int toplam=0;
            int ortalama;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("{0}. Sayıyı Giriniz: \n " , i);
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
            }
            ortalama = toplam / 5;
            Console.WriteLine("Ortalama:{0}" , ortalama);
            Console.ReadKey();
        }
    }
}