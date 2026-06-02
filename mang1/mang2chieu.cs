using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Text;
using System.Threading.Channels;

namespace mang1
{
    internal class mang2chieu
    {
        static void Main(string[] args)
        {
            Demso(Taomatranrandom(3, 3));
        }

        static int[,] Lapmatran(int row, int col)
        {
            int[,] a = new int[row, col];
            int result;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {

                    Console.Write($"a[{i},{j}] la: ");

                    while (!int.TryParse(Console.ReadLine(), out result))
                    {
                        Console.WriteLine("Khong dung dinh dang, nhap lai: ");
                    }
                    a[i, j] = result;

                    Console.WriteLine();
                }

            }
            Console.WriteLine("Ma tran vua nhap la:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }


            return a;
        }
        static (int[] a, int[] b) Tongphantu(int[,] a)
        {
            int[] tongtrendong = new int[a.GetLength(0)];
            int[] tongtrencot = new int[a.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    tongtrendong[i] += a[i, j];
                    tongtrencot[j] += a[i, j];
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write(tongtrendong[i] + " ");
            }
            Console.WriteLine();
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(tongtrencot[j] + " ");
            }
            return (tongtrendong, tongtrencot);
        }
        static int[,] Taomatranrandom(int row, int cols)
        {
            Random r = new Random();
            int[,] a = new int[row, cols];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    a[i, j] = r.Next(1, 11);
                }
                Console.WriteLine();
            }
            return a;
        }
        static double Demso(int[,] a)
        {
            double tbc=0;
            int k;
            int count = 0;
            int sum = 0;
            int min = int.MaxValue;
            Console.WriteLine("Nhap so k: ");
            while (!int.TryParse(Console.ReadLine(), out k))
                Console.WriteLine("Nhap lai");
            Console.WriteLine("Ma tran la:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < k && a[i, j] % 2 != 0)
                    {
                        count++;
                        sum += a[i, j];
                        if (a[i, j] < min) min = a[i, j];
                    }
                }
            }
            if (count == 0) { Console.WriteLine("Khong ton tai so muon tim"); }
            else
            {
                tbc = sum / count;
                Console.WriteLine($"Co {count} so nho hon {k} va la so le co tbc la {tbc}");
            }

                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] < k && a[i, j] % 2 != 0 && a[i, j] == min)
                        {
                            Console.WriteLine($"So nho nhat thoa dieu kien la {a[i, j]}, tai dong {i} cot {j}");
                        }

                    }
                }
                return tbc;
            
        }
    }
}