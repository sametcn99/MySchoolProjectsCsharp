﻿using System;

namespace forwhiledonguler8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = Convert.ToInt32(Console.ReadLine());
            int basamak = 0;

            while (sayi > 0)
            {
                basamak++;
                sayi = sayi / 10;
            }

            Console.WriteLine("Girdiğiniz sayı " + basamak.ToString() + "basamaklıdır.");
        }
    }
}
