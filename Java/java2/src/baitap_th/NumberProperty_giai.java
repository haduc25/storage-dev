package baitap_th;

import java.io.*;
import java.util.*;

public class NumberProperty_giai {
	private int n;
	public boolean prime(int k) {
		if(k<2) return false;
		else {
			for(int i=2;i<k;i++)
				if(k%i==0) return false;
			return true;
		}
	}
	public boolean palindrome(int k) {	
		int num = k, reversedNum = 0, remainder;
        // reversed integer is stored in variable 
        while( num != 0 ) {
            remainder = num % 10;
            reversedNum = reversedNum * 10 + remainder;
            num  /= 10;
        }
        if (k == reversedNum) 	return true;
        else  			      	return false;
	}
	public boolean armstrong(int k) {
		int num=k, remainder, result = 0, n = 0;
        for (;num != 0; num /= 10, ++n); // Find out n = the number of digits of k 
        num=k;
        for (;num != 0; num /= 10)  {
            remainder = num % 10;
            result += Math.pow(remainder, n);
        }   
        if(result == k) return true;
        else return false;
	}
	public void nhap_n() {
		Scanner sc=new Scanner(System.in);
		System.out.print("Nhập n (2<=n<=1000000): ");
		do {
			try {n=Integer.parseInt(sc.nextLine());}
			catch(Exception e) {n=0;}
		if(n<2||n>1000000) System.out.print("\\t Nhập sai => Vui lòng nhập lại m (2<=n<=1000000): ");	
		}while(n<2||n>1000000 );
	}
	public void lietKe_n_NT_DauTien() {
		int dem=0, k=2;
		while(dem<n) {
			if(prime(k)) {
				System.out.print(k+"\t");
				dem++;
			}
			k++;
		}
	}
	public void lietKe_n_PAL_DauTien() {
		int dem=0, k=1;
		while(dem<n) {
			if(palindrome(k)) {
				System.out.print(k+"\t");
				dem++;
			}
			k++;
		}
	}
	public void lietKe_n_ARM_DauTien() {
		int dem=0, k=1;
		int arr[] = new int[n];
		while(dem<n) {
			if(armstrong(k)) {
				System.out.print(k+"\t");
				arr[dem] = k;
				dem++;
			}
			k++;
		}
		tinhTBC(arr);
	}
	
	
	public static void tinhTBC(int[] arr) 
	{
        double total = 0;
        for(int i=0; i<arr.length; i++){
            total = total + arr[i];
        }
        double average = total / arr.length;
        System.out.format("\n TRUNG BINH CONG CUA N SO ARMSTRONG DAU TIEN: %.3f", average);		
	}
	
	public static void main(String arg[]) {
		NumberProperty_giai tmp = new NumberProperty_giai();
		tmp.nhap_n();
		System.out.println("\n DANH SACH N SO NGUYEN TO DAU TIEN");
		tmp.lietKe_n_NT_DauTien();
		System.out.println("\n DANH SACH N SO PALINDROME DAU TIEN");
		tmp.lietKe_n_PAL_DauTien();
		System.out.println("\n DANH SACH N SO ARMSTRONG DAU TIEN");
		tmp.lietKe_n_ARM_DauTien();
		
		
	}
}