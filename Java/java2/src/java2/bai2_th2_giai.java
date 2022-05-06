/*
 Viết chương trình JAVA thực hiện các công việc sau:
	- Nhập vào một số nguyên dương n từ bàn phím (2 ≤ n ≤ 100)
	- Nhập vào một dãy gồm n số thực bất kỳ
	- Hãy cho biết dãy số vừa nhập có phải là dãy đan dấu?
	- Hãy cho biết dãy vừa nhập có tạo thành cấp số cộng?
 */

package java2;
import java.io.*;
import java.util.*;
public class bai2_th2_giai {
	private double A[];
	int n;
	// Các phương thức
	public void nhapDS() {
		Scanner sc = new Scanner(System.in);
		
		// Nhập n thỏa mãn 2<=n<=100 có bắt lỗi và xử lý ngoại lệ
		System.out.print("Nhập n (2<=n<=100): ");
		do{
			try {
				n = Integer.parseInt(sc.nextLine());
			}catch(Exception e) {n=0;}
			if(n<2||n>100) System.out.print("\t Nhập sai => Đề nghị nhập lại n (2<=n<=100): ");
		}while (n<2||n>100 );
		
		// Nhập giá trị cho các phần tử
		A = new double[n]; // Tạo lập mảng A gồm n số thực
		for(int i=0;i<n;i++) {
			System.out.print("\t A[" + i +"] =");
			A[i] = sc.nextDouble();
			sc.close();
		}	
	}
	public void hienThiDS() {
		System.out.println("\n ===== DÃY SỐ ĐÃ NHẬP ===== \n");
		for(int i=0;i<n;i++)
			System.out.print(A[i] + "\t");
	}
	public boolean kt_dau_dau() {
		for(int i=0;i<n-1;i++)
			if(A[i]*A[i+1] >= 0 ) return false;
		
		return true;
	}
	public boolean kt_cs_cong() {
		double d = A[1]-A[0];
		for(int i=0;i<n-1;i++)
			if(A[i+1]-A[i] != d ) return false;
		
		return true;
	}
	public static void main(String arg[]) {
		bai2_th2_giai tmp = new bai2_th2_giai();
		tmp.nhapDS();
		tmp.hienThiDS();
		// HIỂN THỊ KẾT QUẢ DÃY ĐAN DẤU??
		if(tmp.kt_dau_dau()) 
			System.out.println("\n\n =====> DÃY ĐÃ NHẬP LÀ DÃY ĐAN DẤU!");
		else
			System.out.println("\n\n =====> DÃY ĐÃ NHẬP KHÔNG PHẢI LÀ DÃY ĐAN DẤU!");
		
		//HIỂN THỊ KẾT QUẢ DÃY TẠO THÀNH CẤP SỐ CỘNG??
		if(tmp.kt_cs_cong()) 
			System.out.println("\n\n =====> DÃY ĐÃ NHẬP TẠO THÀNH CẤP SỐ CỘNG!");
		else
			System.out.println("\n\n =====> DÃY ĐÃ NHẬP KHÔNG TẠO THÀNH CẤP SỐ CỘNG!");
	}
}
