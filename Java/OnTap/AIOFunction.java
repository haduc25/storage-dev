/* AIO - All In One
 * Kiểm tra snt, đếm snt, hiển thị snt <= m (So_Hoc.java), Hiển thị m snt đầu tiên (NumberProperty_giai.java)
 * Kiểm tra 1 số cho trước có phải số Palindrome (đối xứng) k?, Hiển thị m số Palindrome đầu tiên (NumberProperty_giai.java)
 * Kiểm tra 1 số cho trước có phải số Armstrong hay k?, Hiển thị m số Armstrong đầu tiên (NumberProperty_giai.java)
 * Tính trung bình cộng của m số Armstrong đầu tiên (NumberProperty_giai.java)
 * Nhập vào một dãy gồm m số thực bất kỳ: (bai2_th2_giai.java) 
 * - Hãy cho biết dãy số vừa nhập có phải là dãy đan dấu?
 * - Hãy cho biết dãy vừa nhập có tạo thành cấp số cộng?
 * Hiển thị ra màn hình danh sách số hoàn hảo <= m (ToanHoc.java)
 * 
 * */

package OnTap;

import java.io.*;
import java.util.*;


public class AIOFunction {
	//thuoc tinh
	private int m;
	
	//phuong thuc
	
	//input
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
	
	/*=======================(So_Hoc.java)=======================*/
	//kt snt
	public boolean isSNT(int k) 
	{
		if(k<2) return false;
		else {
			for (int i = 2; i < k; i++)
				if(k%i == 0) return false;
			return true;
		}
	}
	
	//dem snt
	public int demSNT() 
	{
		int dem = 0;
		for (int i = 0; i <= m; i++) {
			if(isSNT(i))
				dem++;
		}
		return dem;
	}
	
	//hien thi snt <= m
	public void xuatSNT() 
	{
		System.out.println("\n /===> Danh sach SNT <===/ \n");
		for (int j = 2; j <= m; j++) {
			if(isSNT(j))
				System.out.print(j + "\t");
		}
	}
	
	/*=======================(NumberProperty_giai.java)=======================*/
	//hien thi m snt dau tien
	public void m_snt_dau_tien() 
	{
		System.out.println("\n\n /===> Danh sach " + m + " SNT dau tien <===/ \n");
		int i = 2, dem = 0;
		while(dem < m) 
		{
			if(isSNT(i))
			{
				System.out.print(i + "\t");
				dem++;			
			}
			i++;
		}
	}
	
	//kt so palindrome
	public boolean palindrome(int k) {	
		int num = k, reversedNum = 0, remainder;
        while( num != 0 ) {
            remainder = num % 10;
            reversedNum = reversedNum * 10 + remainder;
            num  /= 10;
        }
        if(k == reversedNum) return true;
        else return false;
	}
	
	//hien thi m so palindrome dau tien
	public void m_so_palindrome_dau_tien() {
		System.out.println("\n\n /===> Danh sach " + m + " so Palindrome dau tien <===/ \n");
		int dem=0, k=1;
		while(dem < m) {
			if(palindrome(k)) {
				System.out.print(k + "\t");
				dem++;
			}
			k++;
		}
	}
	
	//kt so armstrong
	public boolean armstrong(int k) 
	{
		int num=k, remainder, result = 0, n = 0;
        for (;num != 0; num /= 10, ++n);
        num=k;
        for (;num != 0; num /= 10)  {
            remainder = num % 10;
            result += Math.pow(remainder, n);
        }   
        if(result == k) return true;
        else return false;
	} 
	
	//hien thi m so armstrong dau tien
	public void m_so_armstrong_dau_tien() {
		System.out.println("\n\n /===> Danh sach " + m + " so Armstrong dau tien <===/ \n");
		int dem=0, k=1;
		int arr[] = new int[m];
		while(dem < m) {
			if(armstrong(k)) {
				System.out.print(k+"\t");
				arr[dem] = k;
				dem++;
			}
			k++;
		}
		tinhTBC(arr);
	}
	
	
	//tinh tbc n so armstrong dau tien
	public static void tinhTBC(int[] arr) 
	{
        double total = 0;
        for(int i=0; i<arr.length; i++)
            total = total + arr[i];
        double average = total / arr.length;
        System.out.format("\n\n TRUNG BINH CONG CUA N SO ARMSTRONG DAU TIEN: %.3f", average);	
	}
	
	/*=======================(bai2_th2_giai.java)=======================*/
	//nhap array
	private double A[];
	public void nhapArr() 
	{
		System.out.println("\n\n /===> Nhap vao danh sach " + m + " phan tu <===/ \n");
		// Nhập giá trị cho các phần tử
		Scanner sc = new Scanner(System.in);
		A = new double[m]; // Tạo lập mảng A gồm m số thực
		for(int i=0;i<m;i++) {
			System.out.print("\t A[" + i +"]= ");
			A[i] = sc.nextDouble();
		}	
	}
	
	//xuat array
	public void xuatArr() {
		System.out.println("\n /===> Day so da nhap <===/ \n");
		for(int i=0;i<m;i++)
			System.out.print(A[i] + "\t");
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
			System.out.println("\n =====> DÃY ĐÃ NHẬP KHÔNG TẠO THÀNH CẤP SỐ CỘNG!");
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
	
	/*=======================(ToanHoc.java)=======================*/	
	//kt so hoan hao
	  public boolean ktraSoHH(int k){
		    int sum = 0;
		    for(int i=1;i<=k/2;i++){
		      if(k%i==0) 
		        sum+=i;//tổng các ước số của a
		    }
		    if(sum==k) return true;
		    return false;
		  }
		
	  //hien thi so hoan hao
	  public void xuatSOHH() 
	  {
		    System.out.println("Các số hoàn hảo <= " + m +" là: ");
		    for (int i = 1; i <= m;i++) {
		      if(ktraSoHH(i)){
		        System.out.print(i + "\t");
		      }
		    }
	  }
	
	
	
	
	
	public static void main(String[] args) {
		AIOFunction aio = new AIOFunction();
		aio.nhapDL();
		//(So_Hoc.java)
		System.out.println("\n /> Có " + aio.demSNT() + " snt.");
		aio.xuatSNT();
		
		//(NumberProperty_giai.java)
		aio.m_snt_dau_tien();
		aio.m_so_palindrome_dau_tien();
		aio.m_so_armstrong_dau_tien();
		
		//(bai2_th2_giai.java)
		aio.nhapArr();
		aio.xuatArr();
		//day dan dau: 1 -2  3 -4
		aio.xuat_isDanDau();
		//day cap so cong: 2  4  6  8
		aio.xuat_isCapSoCong();
		aio.xuat_isCapSoNhan();
		
		//(ToanHoc.java)
		aio.xuatSOHH();
		
		
	}
	
}
