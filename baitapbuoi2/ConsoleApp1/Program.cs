using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap4
{
    class Program
    {
        static void Nhapmang(ref int[] a, int n)
        {
            Console.WriteLine("\t-------------NHẬP MẢNG---------------/n");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i+1}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Xuatmang(int[] a, int n)
        {
            Console.WriteLine("\t\tCÁC PHÂN TỬ CỦA MẢNG\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.Write("Nhập vào số lượng phần tử: ");
            n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            Nhapmang(ref myArray, n);
            Xuatmang(myArray,n);   
        }
    }
}
