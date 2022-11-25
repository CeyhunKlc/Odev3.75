using System;

namespace odev3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Sayiyi Giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayiyi Giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 <= sayi2)
            {
                for (int i = sayi1; i <= sayi2; i++)
                {
                    Console.WriteLine(i);
                }

            }
            else
            {


                for (int i = sayi1; i >= sayi2; i--)
                {

                    {
                        Console.WriteLine(i);
                    }
                }
            }






        }
    }
}