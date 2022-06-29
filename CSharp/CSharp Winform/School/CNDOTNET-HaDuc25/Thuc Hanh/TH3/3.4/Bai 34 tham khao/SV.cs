using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class SV
    {
        private int MaSV;
        private string TenSV;
        private string Namsinh;
        private double DT;
        private double DV;
        private double DA;
        private string CN;

        public SV()
        {

        }
        public double GetDTB
        {
            get { return (DT + DA + DV) / 3; }
        }
        

        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            MaSV = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ten sinh vien: ");
            TenSV = Console.ReadLine();
            Console.Write("Nhap ngay thang nam sinh: ");
            Namsinh = Console.ReadLine();
            Console.Write("Nhap diem Toan: ");
            DT = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem Van: ");
            DV = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem Anh: ");
            DA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap Chuyen Nganh: ");
            CN = Console.ReadLine();
        }

        public void xuat()
        {
            Console.WriteLine("Ma Sinh vien: "+MaSV);
            Console.WriteLine("Ten Sinh vien: "+TenSV);
            Console.WriteLine("Ngay thang nam sinh: "+Namsinh);
            Console.WriteLine("Diem Toan: "+DT);
            Console.WriteLine("Diem Van: "+DV);
            Console.WriteLine("Diem Anh: "+DA);
            Console.WriteLine("Diem Trung Binh: "+this.GetDTB);
            Console.WriteLine("Chuyen Nganh: "+CN);
        }

    }
}
