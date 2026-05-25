using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace mang1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bai8();

        }
        static void Bai1()
        {
            Console.Write("Chon so luong so trong day: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0 || n > 100) { Console.WriteLine("Chon so nho hon 100 va lon hon 0"); }
            while (n < 0 || n > 100) ;

            Console.Write("Dien day cach boi khoang trong: ");
            string[] inputElements = Console.ReadLine().Split(' ');

            int[] dayMoi = new int[n];
            int sophantu = Math.Min(n, inputElements.Length);

            for (int i = 0; i < sophantu; i++)
            {
                dayMoi[i] = int.Parse(inputElements[i]);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(dayMoi[i] + " ");
            }
        }
        static void Bai2()
        {
            int n = int.Parse(Console.ReadLine());
            while (n < 0 || n > 100) ;

            string[] arr = Console.ReadLine().Split(' ');
            int sopt = Math.Min(n, arr.Length);
            int[] arr2 = new int[sopt];

            for (int i = 0; i < sopt; i++)
            {
                arr2[i] = int.Parse(arr[i]);
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            int sum = 0;
            foreach (int num in arr2)
            {
                sum += num;
            }
            Console.WriteLine("Tong la: " + sum);

            int average = sum / arr2.Length;
            Console.WriteLine("Tbc: " + average);
        }
        static void Bai3()
        {
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            }
            while (n > 100 || n < 0);
            string[] arr = Console.ReadLine().Split(' ');
            int spt = Math.Min(n, arr.Length);
            int[] arr2 = new int[spt];
            for (int i = 0; i < spt; i++)
            {
                arr2[i] = int.Parse(arr[i]);
            }
            for (int i = 0; i < spt; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();
            int Max = arr2[0];
            int Min = arr2[0];
            for (int i = 0; i < spt; i++)
            {
                if (arr2[i] > Max)
                {
                    Max = arr2[i];
                }
                if (arr2[i] < Min) { Min = arr2[i]; }
            }
            Console.WriteLine(Min + " " + Max);
        }
        static void Bai4()
        {
            Random rand = new Random();
            int n = rand.Next(7, 15);

            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr2[i] = rand.Next(1, 100);
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            int count2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr2[i] % 2 == 0)
                {
                    count++;
                }
                else { count2++; }
            }
            Console.WriteLine(count + " " + count2);

        }
        static void Bai5()
        {
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 || n > 100);
            string[] arr = Console.ReadLine().Split(' ');
            int spt = Math.Min(n, arr.Length);
            int[] arr2 = new int[n];
            for (int i = 0; i < spt; i++)
            {
                arr2[i] = int.Parse(arr[i]);
            }
            for (int i = 0; i < spt; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.Write("So muon tim: ");
            Console.WriteLine();
            int sotim = int.Parse(Console.ReadLine());
            for (int i = 0; i < spt; i++)
            {
                if (arr2[i] == sotim)
                {
                    Console.WriteLine("So can tim o vi tri: " + i + 1);

                    break;
                }
                if (arr2[i] != sotim)
                {
                    Console.WriteLine("So can tim o -1");
                }
            }


        }
        public static void Bai6()
        {
            int n;
            Console.WriteLine("Nhap vao n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("hap vao chuoi: ");
            string[] arr = Console.ReadLine().Split(' ');
            int spt = Math.Min(n, arr.Length);
            int[] arr2 = new int[spt];
            for (int i = 0; i < spt; i++)
            {
                arr2[i] = int.Parse(arr[i]);
            }
            Console.WriteLine("Mang ban dau la: ");
            for (int i = 0; i < spt; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Mang sau khi dao la: ");
            for (int i = spt - 1; i >= 0; i--)
            {
                Console.Write(arr2[i] + " ");
            }

        }
        static void Bai7()
        {
            int n;
            Console.WriteLine("Nhap vao n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("hap vao chuoi: ");
            string[] arr = Console.ReadLine().Split(' ');
            int spt = Math.Min(n, arr.Length);
            int[] arr2 = new int[spt];
            for (int i = 0; i < spt; i++)
            {
                arr2[i] = int.Parse(arr[i]);
            }
            Console.WriteLine("Mang ban dau la: ");
            for (int i = 0; i < spt; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Mang sau khi dao la: ");
            int[] arrdao = new int[spt];
            int j = 0;
            for (int i = spt - 1; i >= 0; i--)
            {
                arrdao[j] = arr2[i];

                Console.Write(arrdao[j] + " ");
                j++;
            }
            bool ketQua = true;
            for (int i = 0; i < spt; i++)
            {
                if (arr2[i] != arrdao[i])
                {
                    ketQua = false;
                    break;
                }
            }
            Console.WriteLine($"Mang doi xung {ketQua}");
        }
        static bool Lasonguyento(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        static void Bai8()
        {
            int n;
            Console.WriteLine("Nhap so: ");
            n = int.Parse(Console.ReadLine());
            bool hopLe = true;
            int spt = 0;
            int[] arrchuyen = null;
            do
            {
                Console.WriteLine("Nhap day nguyen duong: ");

                string[] arrnhap = Console.ReadLine().Split(' ');
                spt = Math.Min(n, arrnhap.Length);
                arrchuyen = new int[spt];
                for (int i = 0; i < spt; i++)
                {
                    arrchuyen[i] = int.Parse(arrnhap[i]);
                    if (arrchuyen[i] < 0)
                    {
                        Console.WriteLine("Co so am, hay nhap lai!");
                        hopLe = false;
                        break;
                    }
                }
            }

            while (!hopLe);

                for (int i = 0; i < spt; i++)
                {
                    Console.Write(arrchuyen[i] + " ");
                }
                Console.WriteLine();
            bool cosonguyento = false;
                Console.WriteLine("Cac so nguyen to la: ");
            foreach (int num in arrchuyen)
            {
                if (Lasonguyento(num))
                {
                    Console.Write(num + " ");

                    cosonguyento = true;
                }
            }
                if (cosonguyento == false) { Console.WriteLine("empty"); }
            }




            
            }
    } 

        
       
    
