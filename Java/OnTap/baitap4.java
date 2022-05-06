package OnTap;

import java.io.*;
import java.util.Scanner;
class KhachHang {
	private String ma;
	private String hoTen;
	private int  tuoi;
	private String diaChi;
	private int sdt;
	private String email;
	
	KhachHang(){}
	KhachHang(String ms){}
	KhachHang(String ms, String ht, int t, String dc, int dt, String em){
		ma=ms;
		hoTen=ht;
		tuoi=t;
		diaChi=dc;
		sdt=dt;
		email=em;
	}
	public void nhapTT() {
		Scanner sc =new Scanner(System.in);
		System.out.print("\t Ma so KH: ");  ma = sc.nextLine();
		System.out.print("\t Ho ten: ");  hoTen = sc.nextLine();
		System.out.print("\t Tuoi: ");  tuoi = Integer.parseInt(sc.nextLine());
		System.out.print("\t Dia chi: ");  diaChi = sc.nextLine();
		System.out.print("\t So dien thoai: ");  sdt = Integer.parseInt(sc.nextLine());
		System.out.print("\t Email: ");  email = sc.nextLine();
	}
	public void hienthiTT() {
		System.out.println("Ma KH= "+ma);
		System.out.println("Ho ten KH= "+hoTen);
		System.out.println("Tuoi KH= "+tuoi);
		System.out.println("Dia chi KH= "+diaChi);
		System.out.println("SDT KH= "+sdt);
		System.out.println("Email KH= "+email);
	}
	public int getTuoi() {return tuoi;}
	public String getTen() {return hoTen;}

}
public class baitap4{
	private int n;
	private KhachHang dskh[];
	public void nhapDSKH() {
		Scanner sc =new Scanner(System.in);
		System.out.println("\n =====Nhap thong tin khach hang======\n");
		System.out.print("Nhap so luong KH: n=");  n= Integer.parseInt(sc.nextLine());
//		n=sc.nextInt();
		dskh= new KhachHang[n];
		for(int i=0;i<n;i++) {
			System.out.println("\n =====Nhap thong tin KH thu <"+(i+1)+">======");
			dskh[i]=new KhachHang();
			dskh[i].nhapTT();
		}
	}
	public void hienthiDSKH() {
		System.out.println("\n =====Thong tin khach hang da nhap======\n");
		for(int j=0;j<n;j++) {
			System.out.println("\n ============================================\n");
			dskh[j].hienthiTT();
		}
	}
	public void sxTheoTuoi() {
		KhachHang tg=new KhachHang();
		for(int i=0;i<n-1;i++)
			for(int j=i+1;j<n;j++) {
				if(dskh[i].getTuoi()<dskh[j].getTuoi()) {
					tg     = dskh[i];
					dskh[i]= dskh[j];
					dskh[j]= tg;
				}
			}
	}
	public void timTheoTen() {
		for(int i=0;i<n;i++)
			if(dskh[i].getTen().equalsIgnoreCase("Nguyen Van Duc")) {
				System.out.println("\n ============================================\n");
				dskh[i].hienthiTT();
			}
	}
	public static void main(String arg[]) {
		baitap4 tmp=new baitap4();
		tmp.nhapDSKH();
		System.out.println("\n =====Thong tin khach hang da nhap======\n");
		tmp.hienthiDSKH();
		tmp.sxTheoTuoi();
		System.out.println("\n =====Thong tin khach hang sau khi sap xep giam dan theo tuoi======\n");
		tmp.hienthiDSKH();
		tmp.timTheoTen();
		System.out.println("\n =====Thong tin khach hang co ten<Nguyen Vawn Duc>======\n");
		tmp.hienthiDSKH();
	}
}