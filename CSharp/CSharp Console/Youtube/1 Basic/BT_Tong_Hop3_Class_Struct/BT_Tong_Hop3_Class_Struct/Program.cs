using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Tong_Hop3_Class_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String, StringBuilder, Chuan hoa chuoi
            Console.WriteLine("\n/============> String, StringBuilder, Chuan hoa chuoi <============/");
            //String, StringBuilder
            /*Hàm hỗ trợ, Phương Thức trong String
            - String.Compare(string strA,string strB): So sánh stA,stB
            - <Tên biến>.CopareTo(string strB) :gọi So sánh qua tên biến
            - String.Concat(string strA,string strB): Nối chuỗi strA và strB thành 1
            - IndexOf(char value): Trả vè int xuất hiện first của kí tự value trong chuỗi
            - LastIndexOf(char value): Trả vè int xuất hiện last của kí tự value trong chuỗi
            - Insert(int startindex,string value): Trả về chuỗi mới gồm chuỗi cũ đã chèn thêm chuỗi value vào
            vị trí của startindex(chèn kí tự)
            - String.isNullOrEmpty(string value): Check value xem có phải là null or emply hay k,true or false
            - Remove(int startindex,int count): Trả về chuỗi mới đã xóa count từ vị trí startindex trong chuỗi ban đầu
            - Replace(char Oldvalue,char Newvalue): Trả về chuỗi mới thay thế kí tự oldvalue vào newvalue
            - Split(char value): Trả về 1 mảng đc cắt ra từ chuỗi ban đầu tại nơi có chứa kí tự value
            - Subtring(int startdex,int length): Trả về 1 chuỗi mới đc cắt từ vị trí startdex với số kí tự cắt là legth
            - ToCharArray(): Trả về 1 mảng kí tự trong chuỗi ban đầu
            - ToLower(): Trả về 1 chuỗi mới đã viết thường các kí tự trong chuỗi ban đầu
            - ToUpper(): Trả về 1 chuỗi mới đã viết Hoa các kí tự trong chuỗi ban đầu
            - Trim(): Trả về 1 chuỗi mới đã bỏ tất cả các khoảng trắng đầu và cuối trong chuỗi ban đầu*/

            Console.WriteLine("\n/>Ex1 Khai bao string");
            //Ex1:Khai báo string:
            string a = "Ha Minh Duc";
            a = a.Substring(3, 1);
            Console.Write(a);


            Console.WriteLine("\n/>Ex2 Chuan hoa chuoi");
            //Ex2:
            string FullName;
            string Result = ""; // Chứa kết quả chuẩn hóa chuỗi
            Console.Write("Nhap Ho va Ten: ");
            FullName = Console.ReadLine();
            //Cắt khoảng trắng First and Last
            FullName = FullName.Trim();
            //Thay 2 khoảng trắng = 1 khoảng trắng
            while (FullName.IndexOf("  ") != -1)
            {
                FullName = FullName.Replace("  ", " ");
                string[] SubName = FullName.Split(' ');
                for (int i = 0; i < SubName.Length; i++)
                {
                    string FirstChar = SubName[i].Substring(0, 1);
                    string OtherChar = SubName[i].Substring(1);
                    SubName[i] = FirstChar.ToUpper() + OtherChar.ToLower();
                    Result += SubName[i] + " ";

                }
                Console.WriteLine("Ho va Ten La:{0} ", Result);
            }
            //Ap dụng được 2 khoảng trắng, trên 2 kt = lỗi

            /*StringBuilder: tiết kiệm bộ nhớ hơn string
            //Tạo StringBuilde rỗng
                StringBuilder<Tên biến > = new StringBuilder();
            // Tạo 1  StringBuilder có giá trị cho trước
                StringBuilder<Tên biến > = new StringBuilder(<Chuỗi giá trị>);
            // phương thức: Remove,Inset,Replace Như string
                Append(string Value) Nối chuỗi Value sau chuỗi ban đầu
                Clear(): Xóa bỏ toàn bộ nội dung 
                Tostring(): Chuyển đối tượng StringBuilder sang string*/

            #endregion

            /*=================================================================================================*/

            #region Struct
            Console.WriteLine("\n/============> Struct <============/");

            //Struct
            SinhVien sv = new SinhVien();
            Console.WriteLine(" Nhap thong tin sinh vien: ");

            NhapSV(out sv);
            Console.WriteLine("\n******************************\n");
            Console.WriteLine("/>Thong tin sinh vien vua nhap la: ");
            XuatSV(sv);
            Console.WriteLine("/>Diem TB cua Sinh Vien la: " + DiemTBSinhVien(sv));
            #endregion

            /*=================================================================================================*/

            #region Enum
            Console.WriteLine("\n/============> Enum <============/");
            Console.WriteLine(Color.Green);

            //Nếu dùng 'if' với 'enum' thì phải ép kiểu
            //Ex 1: Ép Kiểu enum
            Console.WriteLine("/>Ep kieu Ex1: ");
            Console.Write("\nNhap a: ");
            int a2 = int.Parse(Console.ReadLine());
            if (a2 == (int)Color.Red)// Ép kiểu
                Console.WriteLine("/>Ban chon mau do");
            else
                Console.WriteLine("/>Khong phai mau do");

            //Ex 2: Esp kiểu enum(ngược lại)
            Console.WriteLine("Ep kieu Ex2: ");
            Color Background = (Color)3; //Ép kiểu lúc này Background sẽ = 3 là màu Blue
            Console.WriteLine("{0}", Background);

            #endregion

            Console.ReadKey();
        }

        #region Struct
        //struct
        struct SinhVien
        {
            //Struct: tưởng tự class, sử dụng ngoài main
            public int MaSV;
            public string HoTen;
            public string Lop;
            public double DiemToan;
            public double DiemAnh;
            public double DiemLy;
        }

        //Nhap
        static void NhapSV(out SinhVien sv)
        {
            Console.Write("Ma SV: ");
            sv.MaSV = int.Parse(Console.ReadLine());
            Console.Write("Ho Ten: ");
            sv.HoTen = Console.ReadLine();
            Console.Write("Lop: ");
            sv.Lop = Console.ReadLine();
            Console.Write("Diem Toan: ");
            sv.DiemToan = Double.Parse(Console.ReadLine());
            Console.Write("Diem Ly: ");
            sv.DiemLy = Double.Parse(Console.ReadLine());
            Console.Write("Diem Anh: ");
            sv.DiemAnh = Double.Parse(Console.ReadLine());
        }

        //Xuat
        static void XuatSV(SinhVien sv)
        {
            Console.WriteLine("Ma SV: " + sv.MaSV);
            Console.WriteLine("Ho Ten: " + sv.HoTen);
            Console.WriteLine("Lop: " + sv.Lop);
            Console.WriteLine("Diem Toan: " + sv.DiemToan);
            Console.WriteLine("Diem Ly: " + sv.DiemLy);
            Console.WriteLine("Diem Anh: " + sv.DiemAnh);
        }

        static double DiemTBSinhVien(SinhVien SV)
        {
            return (SV.DiemToan + SV.DiemLy + SV.DiemAnh) / 3;
        }
        #endregion

        #region Enum
        enum Color
        {
            Red = 1,
            Blue = 3,
            Green = 6,
            Yellow = 9,
        }
        #endregion
    }
}
