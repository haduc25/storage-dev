package java3;

import java.io.*;
import java.util.*;

public class KhachThue {
		//các thuộc tính
	private String hoTen;
	private int namSinh;
	private String gioiTinh;
	private String queQuan;
	private int CCCD;
		
		//toán tử tạo lập
	public KhachThue(){}
	public KhachThue(String ht,int ns,String gt,String qq, int cc){
		this.hoTen= ht;
		this.namSinh= ns;
		this.gioiTinh= gt;
		this.queQuan= qq;
		this.CCCD=cc;
	}
		
	public String getHoTen() {
		return hoTen;
	}
		
	public void setHoTen(String hoTen) {
		this.hoTen = hoTen;
	}
	public void nhapTT() {
		Scanner sc = new Scanner(System.in);
		System.out.print("nhập tên khách thuê: ");
		hoTen=sc.nextLine();
			
		System.out.print("nhập năm sinh: ");
		do {
			try {
				namSinh = Integer.parseInt(sc.nextLine());
			}catch(Exception e) {
				System.out.print("==>nhập lỗi >> nhập lại năm sinh: ");
				namSinh = Integer.parseInt(sc.nextLine());
			}
			if(namSinh <0)System.out.print("==>nhập lỗi >> nhập lại năm sinh: ");
		}while(namSinh <0);
			
		System.out.print("nhập giới tính(nam/nữ): ");
		do {
			gioiTinh=sc.nextLine();
			if(!(gioiTinh.equalsIgnoreCase("nam"))&&!(gioiTinh.equalsIgnoreCase("nữ")))
				System.out.print("==>Vui lòng nhập lại giới tính: ");
		}while(!(gioiTinh.equalsIgnoreCase("nam"))&&!(gioiTinh.equalsIgnoreCase("nữ")));
			
			
		System.out.print("nhập quê quán: ");
		queQuan=sc.nextLine();
			
		System.out.print("nhập số căn cước công dân: ");
		do {
			try {
				CCCD = Integer.parseInt(sc.nextLine());
			}catch(Exception e) {
				System.out.print("nhập lại căn cước cong dân: ");
				CCCD = Integer.parseInt(sc.nextLine());
			}
			if(CCCD <0)System.out.print("nhập lại căn cước cong dân: ");
		}while(CCCD <0);
	}
		
	public void hienthiTT() {
		System.out.println("  <<<Thông Tin Cá Nhân>>>");
		System.out.println(" \tHọ Tên: "+hoTen);
		System.out.println(" \tNăm Sinh: "+namSinh);
		System.out.println(" \tGiới Tính: "+gioiTinh);
		System.out.println(" \tQuê Quán: "+queQuan);
		System.out.println(" \tCCCD: "+CCCD);
	}
}
