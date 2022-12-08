using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK2
{
    class Program
    {
        static void tinhtong(int n)
        {
            int i, tong = 0;
            Console.Write("nhập vào giá trị n: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0;i<= n; i++)
            {
                tong += i;
            }
            Console.WriteLine(tong);

        }
        static void tinhtich(int n)
        {
            int i, tich = 1;
            Console.Write("nhập vào giá trị n: ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                tich *= i;
            }
            Console.WriteLine(tich);

        }
        static void tinhcanchi(int namsinh)
        {
            
            Console.Write("Nhập vào năm sinh của bạn: ");
            namsinh = int.Parse(Console.ReadLine());

            String can = "", chi = "";
            switch (namsinh % 10)
            {
                case 0:
                    can = "Canh";
                    break;
                case 1:
                    can = "Tân";
                    break;
                case 2:
                    can = "Nhâm";
                    break;
                case 3:
                    can = "Quý";
                    break;
                case 4:
                    can = "Giáp";
                    break;
                case 5:
                    can = "Ất";
                    break;
                case 6:
                    can = "Bính";
                    break;
                case 7:
                    can = "Đinh";
                    break;
                case 8:
                    can = "Mậu";
                    break;
                case 9:
                    can = "Kỷ";
                    break;
            }
            switch (namsinh % 12)
            {
                case 0:
                    chi = "Thân";
                    break;
                case 1:
                    chi = "Dậu";
                    break;
                case 2:
                    chi = "Tuất";
                    break;
                case 3:
                    chi = "Hợi";
                    break;
                case 4:
                    chi = "Tý";
                    break;
                case 5:
                    chi = "Sửu";
                    break;
                case 6:
                    chi = "Dần";
                    break;
                case 7:
                    chi = "Mão";
                    break;
                case 8:
                    chi = "Thìn";
                    break;
                case 9:
                    chi = "Tị";
                    break;
                case 10:
                    chi = "Ngọ";
                    break;
                case 11:
                    chi = "Mùi";
                    break;
            }
            Console.WriteLine($"bạn sinh năm {namsinh} và tuổi của bạn là{can}{chi}");
            
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //tinhcanchi(namsinh);
            MyArray arr = new MyArray();
            arr.Xuatmang();
        }
        
    }
    class MyArray
    {
        static void Nhapmang(int[] a, int n)
        {
            Console.WriteLine("\t------------------NHẬP CÁC PHẦN TỬ MẢNG------------------\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập vào phần thứ {i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Xuatmang(int[] a,int n)
        {
            Console.WriteLine("\n\n\t------------------XUẤT MẢNG------------------\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Phần tử thứ a[{i+1}]: {a[i]}");
            }
        }

        public int Xuatmang()
        {
            int n;
            Console.Write("Nhập vào số lượng phần tử: ");
            n = int.Parse(Console.ReadLine());
            int[] myArr = new int[n];
            Nhapmang(myArr, n);
            Xuatmang(myArr, n);
            SapxepMang(myArr, n);
            GTLN(myArr, n);
            Console.ReadLine();
            return 1;
        }
        public void SapxepMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n\n\t------------------MẢNG SAU KHI ĐƯỢC SẮP XẾP------------------\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} \t\t");
            }
        }
        public void GTLN(int[]a, int n)
        {
            int MAX = a[0];
            for (int i = 0; i < n; i++)
            {
                if (a[i] > MAX)
                {
                    MAX = a[i];
                }
            }
            Console.WriteLine($"\nGiá trị lớn nhất là: {MAX}");
        }
    }
}
