using System;

namespace forwhiledonguler7
{
    class Program
    {
        static void Main(string[] args)
        {
            int tahmin = 0, tutulan, sayac = 0;
            Random rastgele = new Random();
            tutulan = rastgele.Next(1, 100);
            while (tahmin != tutulan)
            {
                sayac++;
                Console.WriteLine("Sayı giriniz");
                tahmin = Convert.ToInt32(Console.ReadLine());


                if (tahmin > tutulan)
                {
                    Console.WriteLine("Sayıyı küçült");

                }
                else if (tahmin < tutulan)
                {
                    Console.WriteLine("Sayıyı büyüt");
                }
            }
            Console.WriteLine("{0}.denemede bildiniz", sayac);
            Console.ReadKey();
        }
    }
}
