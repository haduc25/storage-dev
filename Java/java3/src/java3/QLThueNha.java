package java3;

/*	Để quản lý khách hàng đến thuê Nhà, người ta cần các thông tin sau: Số ngày thuê, loại phòng, thông tin cá nhân của những người thuê phòng.
  	thông tin cá nhân gồm: họ tên, năm sinh, giới tính, quê quán, căn cước công dân.
  			1)xây dựng lớp khách thuê để quản lý thông tin cá nhân
  			2) xây dưng lớp Nhà  kế thừa lớp khách thuê để quản lý thông tin thuê nhà
  			3) xây dựng lớp QLThueNha kế thừa lớp Nhà  để quản lý danh sách khách thuê
*/
import java.io.*;
import java.util.*;

import nhap_xuat_file.XeMay;

public class QLThueNha {
	List <Nha> DSKT;
	public QLThueNha() {
		DSKT = new ArrayList<Nha>();
	}
	Nha Nha = new Nha();
	
	private Nha nha[];
	
	private int n = 2;
	public void NhapDSKT() {
//		for(int i=0;i<n;i++) {
//			DSKT.add(Nha);
//			DSKT.get(i).nhapTT_ql();
//			
//			DSKT.get(i).hienthiTT_ql();
//			
//
//		}
		
		nha = new Nha[n];
		for (int i = 0; i < nha.length; i++) {
			System.out.println("\nNhập thông tin của xe máy thứ [" + (i + 1) + "] ");
			nha[i] = new Nha();
			nha[i].nhapTT_ql();
			
		}
	}
		
	public void HienThiDSKT() {
//		for(int i=0;i<n;i++) { 
//			System.out.println("-------------------------------------------------------");
////			System.out.println("Khách Thuê Thứ "+(i+1));
//			DSKT.get(i).hienthiTT_ql();
//		}
		
		
		for (int i = 0; i < nha.length; i++) {
			System.out.println("\n---------------------------------------------");
			nha[i].hienthiTT_ql();
			nha[i].tienNha();
		}
	}
	

	public static void main(String[] args) {
		QLThueNha t=new QLThueNha();
		t.NhapDSKT();
//		System.out.println("================Danh Sách Sách Khách Thuê================ ");
		t.HienThiDSKT();
	}
}

