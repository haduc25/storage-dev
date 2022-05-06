/*
 * Viet huong trinh java thuc hien 
1. xay dung lop Nguoi
	a. thuoc tinh chung: hoTEn, diaChi, namSinh, gioiTinh
	b. ac phuong thuc
		public void nhapTT() //nhap for NGuoi
		public void inTT()
2. Xay dung lop VanDung chua phuong thuc main() 
 * 
 * */

package baitap_class;


import java.io.*;
import java.util.*;

class Nguoi {
	//thuoc tinh
	private String hoTen;
	private String diaChi;
	private int namSinh;
	private String gioiTinh;
	
	//phuong thuc
	public void nhap() 
	{
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap ho ten: "); hoTen = sc.nextLine();
		System.out.print("Nhap dia chi: "); diaChi = sc.nextLine();
		do 
		{
			System.out.print("Nhap nam sinh: ");
			try{
				namSinh = Integer.parseInt(sc.nextLine()); //ep kieu
			}catch(Exception ex) {namSinh = 0;}
		}while(namSinh<=0);

		do 
		{
			System.out.print("Nhap gioi tinh (Nam/Nu): "); gioiTinh = sc.nextLine();
		}while(!gioiTinh.equalsIgnoreCase("NAM") && !gioiTinh.equalsIgnoreCase("NU"));
		sc.close();
		
	}
	
	public void hienthi() 
	{
		System.out.println("\n Ho ten: " + hoTen);
		System.out.println("\n Dia chi: " + diaChi);
		System.out.println("\n Nam sinh: " + namSinh);
		System.out.println("\n Gioi tinh: " + gioiTinh);
	}
	
}


public class VanDung
{
	public static void main(String[] args) {
		Nguoi tmp = new Nguoi();
		System.out.println("\n<===INPUT===>");
		tmp.nhap();
		System.out.println("\n<===OUTPUT===>");
		tmp.hienthi();
		
	}
	
}















