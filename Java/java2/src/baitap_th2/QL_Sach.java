/*
 * Xay dung cac lop Sach gom cac thuoc tinh: ten sach, tac gia, nam xb
 * co cac phuong thuc gom: taon tu tao lap: nhap, hien thi tt cua obj
 * b, xay dung lop QL_Sach voi cac phuong thuc 
 * 	+nhap va hien thi 1 danh sach
 * nhap vao ho ten 	cua 1 tac gia, hien thi tt cua tat ca cac cuon sach cua tac gia da nhap
 *  
 * */

package baitap_th2;

import java.util.Scanner;



	class Sach
	{
		//thuoc tinh
		private String tenSach;
		private String tenTG;
		private int namXB;
		
		//cac toan tu tao lap
		public Sach() {}
		public Sach(String ts)
		{
			tenSach = ts;
		}
		public Sach(String ts, String tg, int nxb)
		{
			tenSach = ts;
			tenTG = tg;
			namXB = nxb;
		}
		
		
		//phuong thuc
		public int nhapSoNguyen() 
		{
			//nhap so nguyen co xu ly ngoai le
			Scanner sc = new Scanner(System.in);
			int m = 0;
			do {
				try {
					m = Integer.parseInt(sc.nextLine());
				} catch (Exception e) {m = 0;}
				if(m <= 0)
					System.out.print("Nhập lại 1 số nguyên dương m: ");
			}while(m <= 0);
			return m;
		}
		
		//nhap
		public void nhapSach() 
		{
			//nhap thong tin cho1 doi tuong sach - doi tuong hien thoi
			Scanner sc = new Scanner(System.in);
			System.out.print("Nhap ten sach: "); tenSach = sc.nextLine();
			System.out.print("Nhap ten tac gia: "); tenTG = sc.nextLine();
			System.out.print("Nhap nam xb: "); namXB = nhapSoNguyen();
			
		}
		
		//xuat
		public void displaySach() 
		{
			System.out.print("Ten sach: " + tenSach); 
			System.out.print("\nTen tac gia: " + tenTG); 
			System.out.print("\nNam xuat ban: " + namXB);  
			
		}
		
		//get ten tg
		public String getTenTG() {return tenTG;}
		
	}
	
	public class QL_Sach {
		//thuoc tinh
		private int num;
		private Sach ds[];
		//phuong thuc
		
		//nhap ds
		public void nhapDS_Sach() 
		{
			//nhap ds obj Sach
			Sach tmp = new Sach();
			System.out.print("Nhập số lượng sách: ");
			num = tmp.nhapSoNguyen();
			ds = new Sach[num]; //tao lap mang chua 'num' doi tuong sach
			for (int i = 0; i < num; i++) {
				ds[i] = new Sach();
				System.out.println("\n /===> Nhap thong tin cho sach thu [" + (i+1) + "] <===/ \n");
				ds[i].nhapSach();
			}
			
		}
		
		//xuat ds
		public void xuatDS_Sach() 
		{
			for (int i = 0; i < ds.length; i++) {
				System.out.println("\n\n/*******************************/ \n");
				ds[i].displaySach();
			}
		}
		
		//tim ten tg
		public void timTenTacGia() 
		{
			String tentg = "";
			Scanner sc = new Scanner(System.in);
			
			//check tentg is exists in array
			boolean checker = false;
			
			
			System.out.print("\n\nNhập tên tác giả bất kỳ: "); tentg = sc.nextLine();
			tentg = tentg.trim();
			System.out.println("\n /===> Thông tin tên tác giả vừa nhập <===/");
			for (int i = 0; i < ds.length; i++) {
				if(ds[i].getTenTG().equalsIgnoreCase(tentg))
				{
					System.out.println("\n\n/*******************************/ \n");
					ds[i].displaySach();
					checker = true;
				}else {checker = false;}
			}
			
			if(!checker) 
				System.out.println("\n /> Không tìm thấy thông tin tác giả " + tentg);
			
			
		}
		
		//main
		public static void main(String[] args) {
			QL_Sach qls = new QL_Sach();
			qls.nhapDS_Sach();
			System.out.println("\n /===> Thông tin sách vừa nhập <===/");
			qls.xuatDS_Sach();
			qls.timTenTacGia();
		}
		
		
	}


	
	
	
	
	
	
	
	
	
	
	
	
	