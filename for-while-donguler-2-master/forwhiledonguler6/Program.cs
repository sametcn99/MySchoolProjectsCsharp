using System;

namespace forwhiledonguler6
{
    class Program
    {
        static void Main(string[] args)
        {
            int say;
            say = Convert.ToInt32(Console.ReadLine());
            while (say <= 100 && say % 2 == 0)
            {
                Console.WriteLine(say);
                say += 2;
            }
            Console.ReadKey();
        }
    }
}
