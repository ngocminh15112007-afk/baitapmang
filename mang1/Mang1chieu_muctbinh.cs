using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace mang1
{
    public class Mang1chieu_muctbinh
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KHOI TAO DU LIEU");
            int[] mangCuaToi = NhapMang();
            Console.WriteLine("KET QUA BAI 11");
            Solanxuathien(mangCuaToi);

        }



        // 1. HÀM HỖ TRỢ

        static int[] NhapMang()
        {
            int n;
            do
            {
                Console.WriteLine("Nhap so n: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 || n > 100);
            string[] arr = null;
            int spt = 0;
            int[] arrchuyen = null;
            bool kq = true;
            do
            {
                kq = true;
                Console.WriteLine("Nhap day nguyen duong: ");

                arr = Console.ReadLine().Split(' ');
                spt = Math.Min(n, arr.Length);
                arrchuyen = new int[spt];

                for (int i = 0; i < spt; i++)
                {
                    arrchuyen[i] = int.Parse(arr[i]);
                    if (arrchuyen[i] < 0)
                    {

                        Console.WriteLine("Hay nhap so duong");
                        kq = false;
                        break;
                    }
                    Console.Write(arrchuyen[i] + " ");

                }
            }
            while (kq == false);
            return arrchuyen;

        }
        // hàm xuất mảng 
        static void Xuatmang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        // ========================================================
        // 2. CÁC HÀM GIẢI BÀI TẬP
        // ========================================================

        //bai9
        static void Tachchan_le(int[] arr)
        {
            int[] arrchan = new int[arr.Length];
            int[] arrle = new int[arr.Length];
            int c = 0;
            int l = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arrchan[c] = arr[i];
                    c++;
                }
                else
                {
                    arrle[l] = arr[i];
                    l++;
                }
            }
            Console.WriteLine("Day chan la: "); Xuatmang(arrchan);
            Console.WriteLine("Day le la: "); Xuatmang(arrle);
        }
        //bai 10
        static void Bai10(int[] arr)
        {
            int temp = 0;
            int[] tangdan = new int[arr.Length];
            int[] giamdan = new int[arr.Length];
            for (int j = 0; j < arr.Length; j++)
            {

                tangdan[j] = arr[j]

                   ;

                giamdan[j] = arr[j];
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if
                   (tangdan[j] > tangdan[j + 1])
                    {
                        temp = tangdan[j];
                        tangdan[j] = tangdan[j + 1];
                        tangdan[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Tang dan: "); Xuatmang(tangdan);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if
                   (giamdan[j] < giamdan[j + 1])
                    {
                        temp = giamdan[j];
                        giamdan[j] = giamdan[j + 1];
                        giamdan[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Giam dan: "); Xuatmang(giamdan);
        }
        static void Bai11(int[] arr, int x)
        {
            int n = arr.Length;
            int temp = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if
                        (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(); Xuatmang(arr);
            //chenf 1 soos
            int[] mangmoi = new int[n + 1];
            int vitri = 0;
            while (vitri < n && x > arr[vitri])
            {
                vitri++;
            }
            for (int i = 0; i < vitri; i++)
            {
                mangmoi[i] = arr[i];
            }
            mangmoi[vitri] = x;
            for (int i = vitri; i < n; i++)
            {
                mangmoi[i + 1] = arr[i];
            }
            Console.WriteLine(); Xuatmang(mangmoi);
        }
        static void Bai12(int[] arr, int x)
        {
            int n = arr.Length;
            int soluongx = 0;

            int vitri = 0;
            foreach (int num in arr)
            {
                if (num == x)
                {
                    soluongx++;
                }
            }
            int[] mangmoi = new int[n - soluongx];

            for (int i = 0; i < n; i++)
            {
                if (arr[i] != x)
                {
                    mangmoi[vitri] = arr[i];
                    vitri++;
                }
            }
            Console.WriteLine("Mang sau khi bo x: "); Xuatmang(mangmoi);
        }
        static void Solanxuathien(int[] arr)
        {
           
            int j = 0;
            bool[] xuathien = new bool[arr.Length];
            int maxCount = 0;
            int maxPhantu = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                if (xuathien[i]) continue;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j]) 
                    { count++; xuathien[j] = true; }

                }
                Console.WriteLine($"{arr[i]}: {count}");

                if (count > maxCount || (count == maxCount && arr[i] > maxPhantu))
                {
                    maxCount = count;
                    maxPhantu = arr[i];
                }

            }
            Console.WriteLine($"So xuat hien nhieu nhat voi so lan:{maxCount} la so: {maxPhantu}");


        }

    }
        }



