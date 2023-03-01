using System;

namespace ikili_taban
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, kalan;
            Console.Write("sayi giriniz: ");
            sayi = Convert.ToInt32( Console.ReadLine());

            int[] dizi = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            int bitSira = 7;
            while (sayi != 1)
            {
                kalan = sayi % 2;
                sayi = sayi / 2;
                dizi[bitSira] = kalan;
                bitSira--;
            }

            dizi[bitSira] = sayi;
            Console.ReadLine();
        }
    }
}

