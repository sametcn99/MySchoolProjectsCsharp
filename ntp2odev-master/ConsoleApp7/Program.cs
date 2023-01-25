using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasitLib;

namespace ConsoleApp7
{
    class Program
    {

        static void Main(string[] args)
        {
            string fullText = "";
            int girdi;
            Console.WriteLine("Araba sayısı: ");
            girdi = int.Parse(Console.ReadLine());
            Araba arb = new Araba();
            string[] ad = new string[girdi];
            for (int i = 0; i < girdi; i++)
            {
                Console.WriteLine("Marka Giriniz: ");
                arb.Marka = Console.ReadLine();
                Console.WriteLine("Girilen Marka: " + arb.Marka + "\nModel Giriniz:");
                arb.Model = Console.ReadLine();
                Console.WriteLine("Girilen Model: " + arb.Model);
                ad[i] = "Marka: " + arb.Marka + "\nModel: " + arb.Model;
                fullText += ad[i] + "\n";
            }
            Console.WriteLine(fullText);
            System.IO.File.WriteAllText("deneme.txt", fullText); //text dosyası \bin\debug klasörü altına kaydediliyor.
        }
    }
}
