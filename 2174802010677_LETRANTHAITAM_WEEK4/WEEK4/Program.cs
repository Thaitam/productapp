using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HOCSINH hs1 = new HOCSINH();
            DANHSACH DS = new DANHSACH();
            DS.Excuition();
            hs1.NhapThongTinHocSinh();
            hs1.XuatThongTinHocSinh();
        }
    }    
}
