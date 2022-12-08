using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK4
{
    class DANHSACH
    {
        List<HOCSINH> danhsachhs = new List<HOCSINH>();
        public void Excuition()
        {
            bool f = true;
            while (f)
            {
                ShowMENU();
                int LuaChon;
                Console.Write("Nhập vào lựa chọn: ");
                LuaChon = int.Parse(Console.ReadLine());
                switch (LuaChon)
                {
                    case (1):
                        NhapDanhSachSV();
                        break;
                    case (2):
                        XuatThongTinSV();
                        break;
                    case (0):
                        f = false;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn chưa đúng vui lòng xem lại");
                        break;
                }
            }
            
        }





        public void NhapDanhSachSV()
        {
            HOCSINH x = new HOCSINH();
            x.NhapThongTinHocSinh();
            danhsachhs.Add(x);
        }

        public void XuatThongTinSV()
        {
            foreach (HOCSINH x in danhsachhs)
            {
                x.XuatThongTinHocSinh();
            }
        }
        public void ShowMENU()
        {
            Console.Write("\n1. Nhập thông tin học sinh");
            Console.Write("\n2. Xuất thông tin học sinh");
            Console.Write("\n0. Kết thúc chương trình");
        }
    }
}
