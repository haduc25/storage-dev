package baitap_th2;

import java.io.*;
import java.util.*;

public class ToanHoc {
	// properties
	private int m;

	// phuongthuc
	public void nhapDL() 
	{
		//(2<=m<=100), Exception
		Scanner sc = new Scanner(System.in);
		do {
			System.out.print("Nhập 1 số nguyên m (2<=m<=100): ");
			try {
				m = Integer.parseInt(sc.nextLine());
			} catch (Exception e) {m = 0;}
			if(2>m || m >100) 
			{
				System.out.println("Nhập 1 số nguyên m (2<=m<=100): ");
			}
		}while(2>m || m >100);
	}
	
	
	//kt snt
	public boolean isSNT(int k) 
	{
		if(k<2) return false;
		else{
			for (int i = 2; i < k; i++)
				if(k%i == 0) return false;
			return true;
		}
	}
	
	//display snt m snt dau tien
	public void xuatSNT() 
	{
		System.out.println("\n /===> Danh sach [" + m + "] SNT dau tien la <===/ \n");
		int j=2,dem=0;
		while(dem<m) 
		{
			if(isSNT(j)) 
			{
				System.out.print(j + "\t");
				dem++;
			}
			j++;
		}
	}
	
	
	
	public static void main(String[] args) {
		ToanHoc th = new ToanHoc();
		th.nhapDL();
		th.xuatSNT();
	}

}
















































