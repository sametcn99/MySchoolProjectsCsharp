using System;

namespace forwhiledonguler3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, toplam;
            toplam = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("{0}. Sayıyı giriniz." , i);
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
            }
            Console.WriteLine("Girdiğiniz Sayıların Toplamı: {0}", toplam);
            Console.ReadKey();
        }
    }
}
