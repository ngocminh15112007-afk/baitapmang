using System;
using System.Collections.Generic;
using System.Text;

namespace mang1
{
    public class Remake_bai8
    {
        static bool Lasonguyento(int n)

        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    
        public static void Remakebai8()
        {
            int n;
            Console.WriteLine("Dien so: ");
            do
            {
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 || n > 100);
            Console.WriteLine("Nhap day: ");
            string[] arrnhap = Console.ReadLine().Split(' ');
            int spt = Math.Min(n, arrnhap.Length);
            int[] arrchuyen = new int[spt];
            for (int i = 0; i < spt; i++)
            {
                arrchuyen[i] = int.Parse(arrnhap[i]);
                Console.Write(arrchuyen[i] + " ");
            }
            bool tong = false;
            foreach (int num in arrchuyen)
            {
                if (Lasonguyento(num))
                {
                    Console.Write(num + " ");
                    tong = true;
                }
            }
                if (tong=false ) { Console.WriteLine("Empty"); }
        }
            
    }
}
