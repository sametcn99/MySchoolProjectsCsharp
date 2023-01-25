using System;

namespace forwhiledonguler10
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, toplam;
            while (true)
            {
                Console.Write("Birinci sayıyı giriniz :");
                s1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("İkinci sayıyı giriniz :");
                s2 = Convert.ToInt32(Console.ReadLine());
                toplam = s1 + s2;
                Console.WriteLine("Girdiğiniz sayıların toplamı = {0}", toplam);
                Console.WriteLine("Yeni bir işlem için E harfine basınız.");
                string devam = Console.ReadLine();
                if (devam != "e")
                {
                    break;
                }
            }

        }
    }
}
