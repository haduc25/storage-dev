package OnTap;

import java.io.*;
import java.util.*;


public class DaySo {
	//thuoc tinh
	private int m;
	private int A[];
	
	//phuong thuc
	
	//nhap
	public void nhapDL() 
	{
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap vao 1 so nguyen m (2<m<100): ");
		do {
			try {
				m = Integer.parseInt(sc.nextLine());
			}catch(Exception e) {m = 0;}
			
			if(2>m || m >100) 
				System.out.print("\t=> Nhap sai vui long nhap lai (2<m<100): ");
		}while(2>m || m >100);
		
	}
	
	
	//nhap arr
	public void nhapARR() 
	{	
		Scanner sc = new Scanner(System.in);
		boolean checker = true;
		System.out.println("\n\n /===> Nhap vao danh sach " + m + " phan tu <===/ \n");
		A = new int[m]; //  Tạo lập mảng A gồm m số nguyên
		for(int i=0;i<m;i++) {
			System.out.print("\t A[" + i +"]= ");
			
			do {
				try {
					A[i] = Integer.parseInt(sc.nextLine());
				}catch(Exception e) { checker = false;}
				
				if(!checker) 
					System.out.print("\t=> Nhap sai vui long nhap lai!: "); checker = true;
			}while(!checker);
			
			
			
		}	
	}

	//xuat array
	public void xuatArr() {
		System.out.println("\n /===> Day so da nhap <===/ \n");
		for(int i=0;i<m;i++)
			System.out.print(A[i] + "\t");
	}
	
	//sortASC 
	public void sortRise() {
		int temp = A[0];
        for (int i = 0 ; i < A.length - 1; i++) {
            for (int j = i + 1; j < A.length; j++) {
                if (A[i] > A[j]) {
                    temp = A[j];
                    A[j] = A[i];
                    A[i] = temp;
                }
            }
        }
	}
	
	//kt day hien thi ket qua la cap so cong
	public boolean isCapSoCong() 
	{
		double d = A[1]-A[0];
		for(int i=0;i<m-1;i++)
			if(A[i+1]-A[i] != d ) return false;
		return true;
	}
	
	//hien thi day la cap so cong hoac k la day cap so cong
	public void xuat_isCapSoCong() 
	{
		if(isCapSoCong()) 
			System.out.println("\n\n =====> DÃY ĐÃ NHẬP TẠO THÀNH CẤP SỐ CỘNG!");
		else
			System.out.println("\n\n =====> DÃY ĐÃ NHẬP KHÔNG TẠO THÀNH CẤP SỐ CỘNG!");
	}
	
	
	//kt day hien thi ket qua la cap so nhan
	public boolean isCapSoNhan() 
	{
		double d = A[1]/A[0];
		for(int i=0;i<m-1;i++)
			if(A[i]*d != A[i+1] ) return false;
		return true;
	}
	
	//hien thi day la cap so nhan hoac k la day cap so nhan
	public void xuat_isCapSoNhan() 
	{
		if(isCapSoNhan()) 
			System.out.println("\n\n =====> DÃY ĐÃ NHẬP TẠO THÀNH CẤP SỐ NHÂN!");
		else
			System.out.println("\n\n =====> DÃY ĐÃ NHẬP KHÔNG TẠO THÀNH CẤP SỐ NHÂN!");
	}
	
	//kt day so dan dau
	public boolean isDanDau() 
	{
		for(int i=0;i<m-1;i++)
			if(A[i]*A[i+1] >= 0 ) return false;
		return true;
	}
	
	//hien thi so dan dau hoac k la dan dau
	public void xuat_isDanDau() 
	{
		if(isDanDau()) 
			System.out.println("\n\n =====> DÃY ĐÃ NHẬP LÀ DÃY ĐAN DẤU!");
		else
			System.out.println("\n\n =====> DÃY ĐÃ NHẬP KHÔNG PHẢI LÀ DÃY ĐAN DẤU!");
	}
	
	
	
	public static void main(String[] args) {
		DaySo ds = new DaySo();
		ds.nhapDL();
		ds.nhapARR();
		//ds.xuatArr();
		ds.sortRise();
		System.out.println("\n\nDay so sau khi sap xep: \n");
		ds.xuatArr();
		ds.xuat_isCapSoCong();
		ds.xuat_isCapSoNhan();
		ds.xuat_isDanDau();
	}
	
	
}






















