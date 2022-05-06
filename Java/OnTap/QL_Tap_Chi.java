package OnTap;

import java.io.*;
import java.util.*;

//class
class TaiLieu
{
	private String maTL;
	private int namXB;
	
	
	public TaiLieu(){
		
	}
	
	public TaiLieu(String matl, int nxb) 
	{
		this.maTL = matl;
		this.namXB = nxb;
	}
	
	//phuong thuc
	
	//nhap
	public void nhapTT() 
	{
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhập mã tài liệu: "); maTL = sc.nextLine();
		System.out.print("Nhập năm xuất bản: "); namXB = Integer.parseInt(sc.nextLine());	
	}
	
	//xuat
	public void hienthiTT() 
	{
		System.out.println("Mã tài liệu: " + maTL);
		System.out.println("Mã năm xuất bản: " + namXB);
	}
	
}

//tap chi
class TapChi extends TaiLieu
{
	private String soPhatHanh;
	private int thangPhatHanh;
	
	public TapChi()
	{}
	
	public TapChi(String matl, int nxb, String sph, int tph)
	{
		super(matl, nxb);
		this.soPhatHanh = sph;
		this.thangPhatHanh = tph;
	}
	
	
	//nhap
	public void nhapTTTC() 
	{
		super.nhapTT();
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhập số phát hành: "); soPhatHanh = sc.nextLine();
		System.out.print("Nhập tháng phát hành: "); thangPhatHanh = Integer.parseInt(sc.nextLine());	
	}
	
	//hien thi
	public void hienthiTTTC() 
	{
		super.hienthiTT();
		System.out.println("Số phát hành: " + soPhatHanh);
		System.out.println("Tháng phát hành: " + thangPhatHanh);	
	}
	
	//thang phat hanh
	public int getThangPH() {
		return thangPhatHanh;
	}
	
}


public class QL_Tap_Chi {
	private int m;
	private TapChi tc[];
	
	
	// nhap
	public void nhapDLDS() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhập số tạp chí (2<= m <= 25): ");

		do {
			try {
				m = Integer.parseInt(sc.nextLine());
			} catch (Exception e) {
				m = -1;
			}
			if (m < 2 || m > 25)
				System.out.print("\t Nhập sai ==> Nhập lại số lượng xe máy (2<= m <= 25): ");
		} while (m < 2 || m > 25);

		tc = new TapChi[m];
		for (int i = 0; i < tc.length; i++) {
			System.out.println("\nNhập thông tin của tạp chí thứ [" + (i + 1) + "] ");
			tc[i] = new TapChi();
			tc[i].nhapTTTC();
		}

	}
	
	
	//xuat
	public void xuatDS() {
		for (int i = 0; i < tc.length; i++) {
			System.out.println("\n---------------------------------------------");
			tc[i].hienthiTTTC();
		}
	}
	
	//lay thang ph = 12
	public void isMonth12() {
		for(int i=0;i<m;i++) {
			System.out.println("\n---------------------------------------------");
			if(tc[i].getThangPH() == 12)
				tc[i].hienthiTTTC();
		}
	}
	
	
	public static void main(String[] args) {
		QL_Tap_Chi qltc = new QL_Tap_Chi();
		qltc.nhapDLDS();
		qltc.xuatDS();
		System.out.println("\n\n\n DS PHAT HANH THANG 12");
		qltc.isMonth12();
	}
}


























