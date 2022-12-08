using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK4
{
    class HOCSINH
    {
        private string MASO, HOTEN, DIACHI;//Khai báo ra các biến, trường dữ liệu
        private double DIEMTOAN, DIEMLY, DIEMHOA;//Khai báo các biến, trường dữ liệu

        //Khai báo contructor mặc định
        public HOCSINH()
        {

        }
        //Khai báo contructor của một đối tượng
        public HOCSINH(string mASO, string hOTEN, string dIACHI, double dIEMTOAN, double dIEMLY, double dIEMHOA)
        {
            MASO = mASO;
            HOTEN = hOTEN;
            DIACHI = dIACHI;
            DIEMTOAN = dIEMTOAN;
            DIEMLY = dIEMLY;
            DIEMHOA = dIEMHOA;
        }
        //khai báo các thuộc tính của 1 đối tượng
        public string maso
        {
            get { return this.MASO; }
            set { this.MASO = value; }
        }
        public string hoten
        {
            get { return this.HOTEN; }
            set { this.HOTEN = value; }
        }
        public string diachi
        {
            get { return this.DIACHI; }
            set { this.DIACHI = value; }
        }

        public double diemtoan { get => DIEMTOAN; set => DIEMTOAN = value; }
        public double diemly { get => DIEMLY; set => DIEMLY = value; }
        public double diemhoa { get => DIEMHOA; set => DIEMHOA = value; }
        //===================================================================

        public double TinhTB()
        {
            return (diemtoan + diemly + diemhoa) / 3;
        }
        public string XepLoai()
        {
            double dtb = TinhTB();
            if (dtb < 5)
            {
                return "Loại Yếu";
            }
            if (dtb < 6)
            {
                return "Loại TB";
            }
            if (dtb < 8)
            {
                return "Loại Khá";
            }
            if (dtb < 9)
            {
                return "Loại Giỏi";
            }
            return "Xuất Xắc";
        }

        public void NhapThongTinHocSinh()
        {
            Console.WriteLine("Nhập mã số: ");
            maso = Console.ReadLine();
            Console.WriteLine("Nhập vào họ tên: ");
            hoten = Console.ReadLine();
            Console.WriteLine("Nhập vào địa chỉ: ");
            diachi = Console.ReadLine();


            //Xử lý điểm Toán
            while (true)
            {
                try
                {
                    //Doạn code có lỗi
                    Console.WriteLine("Nhập vào điểm Toán: ");
                    diemtoan = int.Parse(Console.ReadLine());
                    if (diemtoan < 0 || diemtoan > 10)
                    {
                        Console.WriteLine("Điểm toán nhập vào chưa đúng, Vui lòng nhập lại!!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    //khi có lỗi thì chạy ở đây
                    Console.WriteLine("Kiểu dữ liệu nhập chưa đúng. Vui lòng kiểm tra lại!!");
                }
            }


            //Xử lý điểm Lý
            while (true)
            {
                try
                {
                    //Doạn code có lỗi
                    Console.WriteLine("Nhập vào điểm Lý: ");
                    diemly = int.Parse(Console.ReadLine());
                    if (diemly < 0 || diemly > 10)
                    {
                        Console.WriteLine("Điểm toán nhập vào chưa đúng, Vui lòng nhập lại!!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    //khi có lỗi thì chạy ở đây
                    Console.WriteLine("Kiểu dữ liệu nhập chưa đúng. Vui lòng kiểm tra lại!!");
                }
            }

            //xử lý điểm Hoá
            while (true)
            {
                try
                {
                    //Doạn code có lỗi
                    Console.WriteLine("Nhập vào điểm Hoá: ");
                    diemhoa = int.Parse(Console.ReadLine());
                    if (diemhoa < 0 || diemhoa > 10)
                    {
                        Console.WriteLine("Điểm toán nhập vào chưa đúng, Vui lòng nhập lại!!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    //khi có lỗi thì chạy ở đây
                    Console.WriteLine("Kiểu dữ liệu nhập chưa đúng. Vui lòng kiểm tra lại!!");
                }
            }


        }

        public void XuatThongTinHocSinh()
        {
            Console.WriteLine($"Mã số: {this.maso}");
            Console.WriteLine($"Họ và Tên: {this.hoten}");
            Console.WriteLine($"Địa Chỉ: {this.diachi}");
            Console.WriteLine($"Điểm Toán: {this.diemtoan}");
            Console.WriteLine($"Điểm Lý: {this.diemly}");
            Console.WriteLine($"Điểm trung bình: {TinhTB()}");
            Console.WriteLine($"Xếp loại: {XepLoai()}");
        }
    }
}
