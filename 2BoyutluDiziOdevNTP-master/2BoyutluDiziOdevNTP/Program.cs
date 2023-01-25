using System;

namespace _2BoyutluDiziOdevNTP
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleman;
            Console.WriteLine("Sınıf mevcudunu giriniz:");
            eleman = int.Parse(Console.ReadLine());
            int sinifort = 0;
            string[] ad = new string[eleman];
            string[] soyad = new string[eleman];
            string[] hnotu = new string[eleman];
            int[] vize = new int[eleman];
            int[] final = new int[eleman];
            int[] ortalama = new int[eleman];
            int[] ogrno = new int[eleman];
            for (int i = 0; i < eleman; i++)
            {
                Console.WriteLine("Ad:");
                ad[i] = Console.ReadLine();
                Console.WriteLine("Soyad:");
                soyad[i] = Console.ReadLine();
                Console.WriteLine("Vize:");
                vize[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Final");
                final[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Öğrenci Numarası");
                ogrno[i] = int.Parse(Console.ReadLine());
                ortalama[i] = Convert.ToInt32(vize[i] * 0.4 + final[i] * 0.4);
                if (25 >= ortalama[i] && ortalama[i] >= 0)
                {
                    hnotu[i] = "FF";
                }
                else if (35 >= ortalama[i] && ortalama[i] >= 26)
                {
                    hnotu[i] = "FD";
                }
                else if (45 >= ortalama[i] && ortalama[i] >= 36)
                {
                    hnotu[i] = "DD";
                }
                else if (55 >= ortalama[i] && ortalama[i] >= 46)
                {
                    hnotu[i] = "DC";
                }
                else if (65 >= ortalama[i] && ortalama[i] >= 56)
                {
                    hnotu[i] = "CC";
                }
                else if (75 >= ortalama[i] && ortalama[i] >= 66)
                {
                    hnotu[i] = "CB";
                }
                else if (85 >= ortalama[i] && ortalama[i] >= 76)
                {
                    hnotu[i] = "BB";
                }
                else if (90 >= ortalama[i] && ortalama[i] >= 86)
                {
                    hnotu[i] = "BA";
                }
                else if (100 >= ortalama[i] && ortalama[i] >= 91)
                {
                    hnotu[i] = "AA";
                }
            }
            for (int i = 0; i < eleman; i++)
            {
                Console.WriteLine(ogrno[i] + " " + ad[i] + " " + soyad[i] + " " + vize[i] + " " + final[i] + " " + hnotu[i]);
            }
            for (int i = 0; i < eleman; i++)
            {
                sinifort = sinifort + ortalama[i];
            }
            sinifort = sinifort / eleman;
            Console.WriteLine("Sınıf Ortalaması:" + sinifort);
        }
    }
}