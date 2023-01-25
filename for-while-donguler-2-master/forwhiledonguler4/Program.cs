using System;

namespace forwhiledonguler4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz:");
            int sayi, sonuc;
            sayi = Convert.ToInt32(Console.ReadLine());
            sonuc = 1;

            for (int i = sayi; i > 1; i--)
            {
                sonuc *= i;
            }
            Console.Write("{0} Sayısının Faktöriyeli: " + sonuc , sayi);
            Console.ReadKey();
        }
    }
}
