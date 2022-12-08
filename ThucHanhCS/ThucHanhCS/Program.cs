using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhCS
{
    public class student // dữ liệu thành viên
    {
        private int SID;
        private string TEN;
        private string KHOA;
        private float DIEM;
        
        #region Constructor không tham số
        public student()
        {
            SID = 0677;
            TEN = "Lê Trần Thái Tâm";
            KHOA = "CNTT";
            DIEM = 10.0f;
        }
        #endregion
        
        
        #region Hàm Constructor sao chép
        public student(student stu)
        {
            SID = stu.SID;
            TEN = stu.TEN;
            KHOA = stu.KHOA;
            DIEM = stu.DIEM;
        }
        #endregion
        public student(int id, string ten, string khoa, float diem) //Có tham số
        {
            SID = id;
            TEN = ten;
            KHOA = khoa;
            DIEM = diem;
        }
        // DANH SÁCH CÁC PROPERTIES
        public int STUDENTID
        {
            get
            {
                return SID;
            }
            set
            {
                SID = value;
            }
        }
        public string NAME
        {
            get { return TEN; }
            set { TEN = value; }
        }
        public string FACULTY
        {
            get { return KHOA; }
            set { KHOA = value; }
        }
        public float MARK
        {
            get { return DIEM; }
            set { DIEM = value; }

        }
        // Phương thức show()
        public void Show()
        {
            Console.WriteLine($"MSSV là: {SID}");
            Console.WriteLine($"Tên là: {NAME}");
            Console.WriteLine($"Khoa là: {FACULTY}");
            Console.WriteLine($"Điểm là: {MARK}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            student[] Studentlist;
            int n;
            Console.Write("Nhập số lượng sinh viên: ");
            n = int.Parse(Console.ReadLine());

            Studentlist = new student[n]; //tạo mảng có n phần tử

            for (int i = 0; i < n; i++)
            {
                Studentlist[i] = new student();
                Console.Write($"Nhập vào tên Sinh viên thứ {i + 1}: ");
                Studentlist[i].NAME = Console.ReadLine();
                Console.Write("Nhập vào MSSV: ");
                Studentlist[i].STUDENTID = int.Parse(Console.ReadLine());
                Console.Write("Nhập vào tên khoa: ");
                Studentlist[i].FACULTY = Console.ReadLine();
                Console.Write("Nhập vào điểm: ");
                Studentlist[i].MARK = float.Parse(Console.ReadLine());
            }
            //Xuất danh sách sinh viên
            Console.WriteLine("----------------DANH SÁCH SINH VIÊN----------------");
            foreach (student st in Studentlist)
            {
                st.Show();
            }
            Console.ReadLine();
        }
    }
}
