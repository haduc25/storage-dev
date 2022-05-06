package baitap_th2;
import java.io.*;
import java.util.*;


class SinhVien {

	private String hoTen;
	private int namSinh;
	private String lop;
	private double dtb;
	private String email;
	
	SinhVien(){}
	
	SinhVien(String ht, int ns, String _lop, double _dtb, String _email)
	{
		hoTen = ht;
		namSinh = ns;
		lop = _lop;
		dtb = _dtb;
		email = _email;
	}
	
	
	public void nhap() 
	{
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Nhap ho & ten: "); hoTen = sc.nextLine();
		System.out.print("Nhap nam sinh: "); namSinh = Integer.parseInt(sc.nextLine());
		System.out.print("Nhap lop: "); lop = sc.nextLine();
		System.out.print("Nhap diem trung binh: "); dtb = Double.parseDouble(sc.nextLine());
		System.out.print("Nhap e-mail: "); email = sc.nextLine();
	}
	
	public void xuat() 
	{	
		System.out.println("Ho & ten: " + hoTen);
		System.out.println("Nam sinh: " + namSinh);
		System.out.println("Lop: " + lop);
		System.out.println("Diem trung binh: " + dtb);
		System.out.println("E-mail: " + email);
	}
	
	
	
	
	public double getDTB() 
	{
		return dtb;
	}
	
	
}

public class QL_SinhVien 
{
	
	private int n;
	private SinhVien sv[];
	
	
	//nhap ds
	public void nhapDSSV() 
	{
		Scanner sc = new Scanner(System.in);

		System.out.print("Nhap so luong SV: "); n = sc.nextInt();
		sv = new SinhVien[n]; //tao n sinh vien
		
		
		for (int i = 0; i < sv.length; i++) {
			System.out.println("\n =====Nhap thong tin sinh vien thu [" + (i + 1) + "]======");
			sv[i] = new SinhVien();
			sv[i].nhap();
		}
	}
	
	//xuat ds
	public void xuatDSSV() 
	{
		System.out.print("\n ===>Thong tin sinh vien da nhap<===");
		
		for (int j = 0; j < sv.length; j++) {
			System.out.println("\n =====Thong tin sinh vien thu [" + (j + 1) + "]======");
			sv[j].xuat();
		}
	}
	
	//tinh dtb
	public void tinhDTB() 
	{
		for (int i = 0; i < sv.length; i++) {
			if(sv[i].getDTB() > 8.5) 
			{
				sv[i].xuat();
			}
		}
	}
	
	//main
	public static void main(String[] args) 
	{
		QL_SinhVien qlsv = new QL_SinhVien();
		qlsv.nhapDSSV();
		qlsv.xuatDSSV();
		System.out.println("\n Sinh vien (DTB > 8.5)");
		qlsv.tinhDTB();
	}


}