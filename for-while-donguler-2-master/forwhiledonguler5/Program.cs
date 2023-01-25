using System;

namespace forwhiledonguler5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Bölen sayıyı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 100; i++)
            {
                if (i % sayi == 0)
                {
                    Console.WriteLine("{0} sayısı {1} sayısına kalansız bölünüyor.", i , sayi);
                }

            }
            Console.ReadKey();
        }
    }
}
