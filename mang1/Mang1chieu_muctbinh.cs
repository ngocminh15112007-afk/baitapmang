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
            Console.WriteLine("KET QUA BAI 9");
            Bai10(mangCuaToi);

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
                for(int i = 0; i <arr.Length; i++)
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
                for (int j = 0; j<arr.Length; j++)
                {

                    tangdan[j] = arr[j]
                        
                       ;

                    giamdan[j] = arr[j];
                }
                for (int i = 0; i<arr.Length-1; i++)
                {
                    for (int j = 0; j<arr.Length-i-1;j++)
                    {
                        if
                       ( tangdan[j] > tangdan[j+1])
                        {
                            temp = tangdan[j];
                        tangdan[j] = tangdan[j + 1];
                        tangdan[j + 1] = temp;
                        }
                    }
                }
                Console.WriteLine("Tang dan: "); Xuatmang(tangdan);
                for (int i = 0; i<arr.Length-1; i++)
                {
                    for (int j = 0; j<arr.Length-i-1;j++)
                    {
                        if
                       (giamdan[j] < giamdan[j+1])
                        {
                            temp = giamdan[j];
                        giamdan[j] = giamdan[j + 1];
                        giamdan[j + 1] = temp;
                        }
                    }
                }
                Console.WriteLine("Giam dan: "); Xuatmang(giamdan);
            }
                
            }


        }



