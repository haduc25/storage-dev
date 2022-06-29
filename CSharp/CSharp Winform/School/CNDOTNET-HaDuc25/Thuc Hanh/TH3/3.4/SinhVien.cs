using System;

namespace Bai_34
{
    class SinhVien
    {
        #region Khai bao tt sv
        private string maSV;
        private string hoTen;
        private string dob;
        private double diemToan, diemVan, diemAnh;
        private string chuyenNganh;

        public double DiemToan { get => diemToan; set => diemToan = value; }
        public double DiemVan { get => diemVan; set => diemVan = value; }
        public double DiemAnh { get => diemAnh; set => diemAnh = value; }

        public SinhVien() { }

        public string getMaSV() { return maSV; }
        public string getHoTen() { return hoTen; }
        public string getDoB() { return dob; }
        public double getDTB() { return (DiemToan+DiemVan+DiemAnh)/3; }
        public string getChuyenNganh() { return chuyenNganh; }

        #endregion

        #region Nhap, Xuat
        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            this.maSV = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            this.hoTen = Console.ReadLine();
            Console.Write("Nhap ngay/thang/nam sinh: ");
            this.dob = Console.ReadLine();
            Console.Write("Nhap diem Toan: ");
            this.DiemToan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem Van: ");
            this.DiemVan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem Anh: ");
            this.DiemAnh = Convert.ToDouble(Console.ReadLine()); ;
            Console.Write("Nhap chuyen nganh dao tao: ");
            this.chuyenNganh = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine("Ma sinh vien: " + this.getMaSV());
            Console.WriteLine("Ho Ten: " + this.getHoTen());
            Console.WriteLine("Ngay sinh: " + this.getDoB());
            Console.WriteLine("Diem trung binh: " + this.getDTB());
            Console.WriteLine("Chuyen Nganh: " + this.getChuyenNganh());
        }
        #endregion
    }
}