using System;

namespace for_while_donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //girilen sayını kaç basamaklı olduğunu gösteren uygulama
            Console.WriteLine("Bir Sayı Giriniz.");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int basamak = 0;

            while (sayi > 0)
            {
                sayi = sayi / 10;
                basamak++;
            }

            Console.WriteLine("Girdiğiniz sayı " + basamak + " basamaklıdır.");
        }
    }
}
