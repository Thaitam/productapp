using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK3
{
    class MATRAN
    {
        public void matran1()
        {
            Console.WriteLine("Ma Trận A");
            int[,] a;
            int Row, Col;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Mời nhập số hàng: ");
            Row = int.Parse(Console.ReadLine());
            Console.Write("Mời nhập số cột: ");
            Col = int.Parse(Console.ReadLine());

            int[,] IntArray = new int[Row, Col];

            for (int i = 0; i < IntArray.GetLength(0); i++)
            {
                for (int j = 0; j < IntArray.GetLength(1); j++)
                {
                    Console.Write("Nhập giá trị phần tử [{0},{1}]: ", i, j);
                    IntArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Mảng vừa nhập");

            for (int i = 0; i < IntArray.GetLength(0); i++)
            {
                for (int j = 0; j < IntArray.GetLength(1); j++)
                {
                    Console.Write("{0,3}", IntArray[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        public void matran2()
        {
            Console.WriteLine("Ma Trận B");
            int[,] a;
            int Row, Col;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Mời nhập số hàng: ");
            Row = int.Parse(Console.ReadLine());
            Console.Write("Mời nhập số cột: ");
            Col = int.Parse(Console.ReadLine());

            int[,] IntArray = new int[Row, Col];

            for (int i = 0; i < IntArray.GetLength(0); i++)
            {
                for (int j = 0; j < IntArray.GetLength(1); j++)
                {
                    Console.Write("Nhập giá trị phần tử [{0},{1}]: ", i, j);
                    IntArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Mảng vừa nhập");

            for (int i = 0; i < IntArray.GetLength(0); i++)
            {
                for (int j = 0; j < IntArray.GetLength(1); j++)
                {
                    Console.Write("{0,3}", IntArray[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
