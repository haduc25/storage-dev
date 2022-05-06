/*
 *  viet
		ham Prime de kt 1 so cho truoc co phai snt k
		ham Palindrome de kt 1 so cho truoc co phai so Palindrome (doi xung) k
		ham armstrong de kt 1 so cho truoc co phai armstrong k
		ham Main
	 * 
	 * */

package baitap_th;
import java.util.Scanner;
import java.io.*;

public class NumberProperty {	
	public static Scanner sc = new Scanner(System.in);
	
	
	// ham kt snt
	public static boolean prime(int x) {
		for (int i = 2; i < x; i++)
			if (x % i == 0)
				return false;
		return true;
	}

	// ham hien thi n snt dau tien
	public static void m_snt_dau_tien(int x) {
		System.out.println("\n<---" + x + " so snt dau tien--->");
		int i = 2, dem = 0;
		while (dem < x) {
			if (prime(i)) {
				System.out.print(i + "\t");
				dem++;
			}
			i++;
		}
	}
	
	// ham kt so Palindrome
	static int isPalindrome(int input, int b, int isOdd) {
	    int n = input;
	    int palin = input;
	    if (isOdd == 1)
	        n /= b;
	    while (n > 0) {
	        palin = palin * b + (n % b);
	        n /= b;
	    }
	    return palin;
	}
	 
	static void m_palindrome_dau_tien(int x) {
	    int number;
	    System.out.println("\n<---" + x + " so Palindrome dau tien--->");
	    for (int j = 0; j < 2; j++) {
	        int i = 1;
	        while ((number = isPalindrome(i, 10, j % 2)) < x) {
	            System.out.print(number + "\t");
	            i++;}
	    }
	}	 
	
	static void m_palindrome_dau_tien_la_snt(int x) {
	    int number;
	    System.out.println("\n<---" + x + " so Palindrome dau tien la snt--->");
	    for (int j = 0; j < 2; j++) {
	        int i = 1, dem = 0;
	        while ((number = isPalindrome(i, 10, j % 2)) < x) {
	            if(prime(number))
		            System.out.print(number + "\t");
		        i++;}
	    }
	}

	 //so Armstrong
	 static boolean isArmstrong(int n)   
	 {   
		 int temp, digits=0, last=0, sum=0;   
		 temp=n;   
		 while(temp>0)    
		 {   
			 temp = temp/10;   
			 digits++;   
		 }   
		 temp = n;   
		 while(temp>0)   
		 {   
			 last = temp % 10;   
			 sum +=  (Math.pow(last, digits));   
			 temp = temp/10;   
		 }  
		 if(n==sum)   
		 return true;      
		 else return false; 
		 
	 }
	 
	//in ra so isArmstrong3
	static void print_isArmstrong3(int x) 
	{
	    System.out.println("\n<---" + x + " so Armstrong--->");
	    int arr[] = new int[x];
		int i = 2, j = 0, dem = 0;
		while (dem < x) {
			if (isArmstrong(i)) {
				arr[j] = i;
				j++;
				dem++;
			}
			i++;
		}
		tinhTBC(arr);
	}
	
	public static void tinhTBC(int[] arr) 
	{
        double total = 0;
        for(int i=0; i<arr.length; i++){
            total = total + arr[i];
            System.out.print(arr[i] + "\t");
        }
        double average = total / arr.length;
        System.out.format("\nKết quả là: %.3f", average);
		
	}
	
	
	public static void main(String[] args) {
		int m;
		System.out.print("Nhập m (2<=m<=1000000): ");
		do{
			try {
				m = Integer.parseInt(sc.nextLine());
			}catch(Exception e) {m=0;}
			if(m<2||m>1000000) System.out.print("\t Nhập sai => Vui lòng nhập lại m (2<=m<=1000000): ");
		}while (m<2||m>1000000 );
	
		NumberProperty np = new NumberProperty();
		np.m_snt_dau_tien(m);
		System.out.println("\n");
		np.m_palindrome_dau_tien(m);
		System.out.println("\n");
		np.m_palindrome_dau_tien_la_snt(m);
		System.out.println("\n");
		np.print_isArmstrong3(m);
		System.out.println("\n");
		
	}
}