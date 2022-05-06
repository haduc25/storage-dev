package java3;

import java.util.Scanner;

public class Nha extends KhachThue {
	 private int soThangThue;
	 private String loaiNha;   
	 private int a=500, b=300, c=100;
	 public Nha() {}
	 public Nha(String ht, int ns, String gt, String qq, int cc, int stt, String ln ) {
	        super(ht,ns, gt, qq, cc);
	        this.soThangThue = stt;
	        this.loaiNha = ln;
	    }
	
	public void nhapTT_ql() {
		Scanner sc = new Scanner(System.in);
		//super.nhapTT();
		
		System.out.print("Nhập số tháng thuê: ");
		do {
			try {
				soThangThue = Integer.parseInt(sc.nextLine());
			}catch(Exception e) {
				System.out.print("nhập lại số tháng thuê: ");
				soThangThue = Integer.parseInt(sc.nextLine());
			}
			if(soThangThue <0)System.out.print("nhập lại số tháng thuê: ");
		}while(soThangThue <0);
		
		System.out.print("Nhập loại nhà(A/B/C): ");
		do {
			loaiNha=sc.nextLine();
			if(!(loaiNha.equals("a"))&&!(loaiNha.equals("B"))&&!(loaiNha.equals("C")))
				System.out.print("Vui lòng nhập đúng loại nhà: ");
		}while(!(loaiNha.equals("a"))&&!(loaiNha.equals("B"))&&!(loaiNha.equals("C")));
		
	}
	
	public void hienthiTT_ql() {
		
		//super.hienthiTT();

			System.out.println("  <<<Thông Tin Thuê Nhà>>>");
	        System.out.println(" \tSố tháng thuê: " + soThangThue + " tháng");
	        System.out.println(" \tLoại nhà: Loại "+loaiNha );
	   
	       switch (loaiNha) {
	       case "A":{
	       	System.out.println(" \tGiá nhà: " + a + " $");
	       	break;
	       }
	       case "B":{
	       	System.out.println(" \tGiá nhà: " + b + " $");
	       	break;
	       }
	       case "C":{
	       	System.out.println(" \tGiá nhà: " + c + " $");
	       	break;
	       }
	       }

       
	}
	
	public void tienNha() {
		double tp;
		if(loaiNha.equals("A")) {
			tp=(a*soThangThue);
		}
		else {
			if(loaiNha.equals("B")) tp=(b*soThangThue);
			else tp=(c*soThangThue);
		}
		System.out.println(" \t==>Tiền Nhà: " + tp+ " $");
	}
}
