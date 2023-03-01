using System;
using System.Collections.Generic;
using System.Text;

namespace ikili_taban
{
    public class BinaryArray
    {

        public int Us(int[] a)
        {
            int b= Convert.ToInt32((Math.Pow(2, 0) * a[0]) + 
                                   (Math.Pow(2, 1) * a[1]) + 
                                   (Math.Pow(2, 2) * a[2]) + 
                                   (Math.Pow(2, 3) * a[3]) + 
                                   (Math.Pow(2, 4) * a[4]) + 
                                   (Math.Pow(2, 5) * a[5]) + 
                                   (Math.Pow(2, 6) * a[6]) + 
                                   (Math.Pow(2, 7) * a[7]));

            return b;
        }

        public int Array(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += (int)(Math.Pow(2, (7 - i)) * a[i]);
            }

            return sum;
        }
        public int[] Dizi(int sayi)
        {
            int  kalan;
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
            return dizi;
        }
    }
}
