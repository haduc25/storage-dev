using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKTTH2Bai1
{
    class SV
    {
        private int MaSV;
        private string TenSV;
        private int Namsinh, Thangsinh, Ngaysinh;
        private double DiemW;
        private double DiemP;
        private double DiemE;
        private string CN;

        public SV()
        {

        }
        public double GetDTB
        {
            get { return (DiemW + DiemP + DiemE) / 3; }
        }
        public string GetTen()
        {
            return TenSV;
        }
        public string GetCN()
        {
            return CN;
        }
        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            MaSV = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ten sinh vien: ");
            TenSV = Console.ReadLine();
            Console.Write("Nhap Ngay sinh: ");
            Ngaysinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap  thang sinh: ");
            Thangsinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap nam sinh: ");
            Namsinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap diem word: ");
            DiemW = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem powpoint: ");
            DiemP = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem excel: ");
            DiemE = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap Chuyen Nganh: ");
            CN = Console.ReadLine();
        }

        public void xuat()
        {
            Console.WriteLine("Ma Sinh vien: " + MaSV);
            Console.WriteLine("Ten Sinh vien: " + TenSV);
            Console.WriteLine("Ngay sinh: " + Ngaysinh + "  " + "Thang Sinh: " + Thangsinh + "  " + "Nam Sinh: " + Namsinh);
            Console.WriteLine("Diem word: " + DiemW);
            Console.WriteLine("Diem powpoint: " + DiemP);
            Console.WriteLine("Diem excel: " + DiemE);
            Console.WriteLine("Diem Trung Binh: " + this.GetDTB);
            Console.WriteLine("Chuyen Nganh: " + CN);
        }

    }
}

