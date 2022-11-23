using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Test
{
    internal class Program
    {
        struct SinhVien
        {
            public string maSV;
            public string tenSV;
            public string lop;
            public double diem1;
            public double diem2;
            
        }
         static void NhapSV(out SinhVien SV)
        {
            Console.WriteLine("Nhap ma sinh vien: ");
            SV.maSV =Console.ReadLine();
            Console.WriteLine("Nhap ten sinh vien: ");
            SV.tenSV =Console.ReadLine();
            Console.WriteLine("Nhap lop sinh vien: ");
            SV.lop=Console.ReadLine();
            Console.WriteLine("Nhap diem mon 1 sinh vien: ");
            SV.diem1 =double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem mon 2 sinh vien: ");
            SV.diem2 = double.Parse(Console.ReadLine());
            
        }
        static double  diemTBsinhvien(SinhVien SV)
        {
            return (SV.diem1 + SV.diem2) / 2;
        }

        static void XuatSV(SinhVien SV)
        {
            Console.WriteLine($"{SV.maSV}_{SV.tenSV}_{SV.lop}_{SV.diem1}_{SV.diem2}");
        }
        static void Main(string[] args)
        {
            SinhVien SV1=new SinhVien();
            NhapSV(out SV1);
            XuatSV(SV1);
            Console.WriteLine($"Diem trung binh sinh vien la: {diemTBsinhvien(SV1)}");
        }
    }
}
