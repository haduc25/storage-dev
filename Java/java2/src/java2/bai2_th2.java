package java2;
import java.util.Iterator;
import java.util.Scanner;
import java.io.*;

public class bai2_th2 {
	public static Scanner sc = new Scanner(System.in);
	
	// ham hien thi n snt dau tien
	public static void nhap(int x) {
		int[] arr = new int[x];
		for (int i = 0; i < arr.length; i++) {
	          System.out.printf("a[%d] = ", i);
	          arr[i] = sc.nextInt();
		}
		xuat(x, arr);
		so_dan_dau(arr);
		if(kt_cap_so_cong(arr, x))
			System.out.println("la csc");
		else
			System.out.println("k la csc");
	}
	
	public static void xuat(int x, int[] arr) {
		System.out.println("\n<---cac pt cua mang--->");
		for (int i = 0; i < arr.length; i++) {
	          System.out.printf(arr[i] + "\t");
		}
	}
	
    public static boolean isArrayAlternating(int[] arr) {
        if (arr == null || arr.length % 2 != 0) {
            return false;
        }
        for (int i = 0; i < arr.length - 1; i++) {
            if (arr[i] >= 0 && arr[i + 1] >= 0 || arr[i] <= 0 && arr[i + 1] <= 0) {
                return false;
            }
        }
        return true;
    }
    
    public static void so_dan_dau(int[] arr) 
    {
    	System.out.println("\n");
        if(isArrayAlternating(arr))
        	System.out.println("Day so tren la day so dan dau!");
        else
        	System.out.println("Day so tren k la day so dan dau!");
    }
    
    //kt cap so cong
    public static boolean kt_cap_so_cong(int [] arr, int n) {
    	int b = arr[1]-arr[0];
    	for (int i = 0; i < n -1; i++)
    		if(arr[i+1] - arr[i] != b) return false;
    	
    	return true;
    }
    
	public static void main(String[] args) {
		int n;
		System.out.println("Nhap n: ");
		do {
			n = sc.nextInt();

			// kt n
			if (n < 2 || n > 100)
				System.out.println("Nhap lai n: ");

		} while (n < 2 || n > 100); // if(dk=true)-> loop

		System.out.println(n + " Hop le!");
		nhap(n);
	}
}














