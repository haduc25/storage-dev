using System;

namespace use_Class1
{
    class SinhVien
    {
        private string maSV, hoTen, chuyenNganhDaoTao;
        private DateTime ngaySinh = new DateTime();
        private double diemWord, diemPowerpoint, diemExcel;

        //  [get/set]
        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public double DiemWord { get => diemWord; set => diemWord = value; }
        public double DiemPowerpoint { get => diemPowerpoint; set => diemPowerpoint = value; }
        public double DiemExcel { get => diemExcel; set => diemExcel = value; }
        public string ChuyenNganhDaoTao { get => chuyenNganhDaoTao; set => chuyenNganhDaoTao = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        public SinhVien() { }

        public string getMaSV() { return maSV; }
        public string getHoTen() { return hoTen; }
        public DateTime getNgaySinh() { return ngaySinh; }    
        public double getDTB() { return ((diemWord + diemPowerpoint + diemExcel) / 3); }
        public string getChuyenNganhDaoTao() { return chuyenNganhDaoTao; }


        //nhap, xuat
        public void nhap()
        {
            Console.Write("Nhap MaSV: ");
            this.maSV = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            this.hoTen = Console.ReadLine();
            //Console.Write("Nhap Ngay/Thang/Nam Sinh (MM/dd/yyyy): ");
            //this.ngaySinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap diem word: ");
            this.diemWord = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem pp: ");
            this.diemPowerpoint = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem excel: ");
            this.diemExcel = double.Parse(Console.ReadLine());
            //Console.Write("Nhap chuyen nghanh dao tao: ");
            //this.chuyenNganhDaoTao = Console.ReadLine();
        }


        public void xuat()
        {
            Console.WriteLine("MaSV: " + this.getMaSV());
            Console.WriteLine("Ho Ten: " + this.getHoTen());
            //Console.WriteLine("Ngay/Thang/Nam Sinh: " + this.getNgaySinh());
            Console.WriteLine("Diem TB: " + this.getDTB());
            //Console.WriteLine("Chuyen nganh DT: " + this.getChuyenNganhDaoTao());
        }
    }
}
