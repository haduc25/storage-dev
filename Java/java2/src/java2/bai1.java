	/*
	 * viet
		ham Prime de kt 1 so cho truoc co phai snt k
		ham Palindrome de kt 1 so cho truoc co phai so Palindrome (doi xung) k
		ham armstrong de kt 1 so cho truoc co phai armstrong k
		ham Main
	 * 
	 * */

package java2;
import java.util.Scanner;
import java.io.*;


public class bai1 {	
	public static Scanner sc = new Scanner(System.in);
	
	
	// ham kt snt
	public static boolean prime(int x) {
		for (int i = 2; i < x; i++)
			if (x % i == 0)
				return false;
		return true;
	}

	// ham hien thi snt <= n
	public static void snt_nho_hon_m(int x) {
		System.out.println("\n<---Cac snt nho hon " + x + "--->");
		for (int j = 2; j <= x; j++)
			if (prime(j))
				System.out.print(j + "\t");
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
	public boolean palindrome(int x) {
		int reversedNum = 0, remainder;
	    
	    // store the number to originalNum
	    int originalNum = x;
	    
	    // get the reverse of originalNum
	    // store it in variable
	    while (x != 0) {
	      remainder = x % 10;
	      reversedNum = reversedNum * 10 + remainder;
	      x /= 10;
	    }
		
	    // check if reversedNum and originalNum are equal
	    if (originalNum == reversedNum) {
//	      System.out.println(originalNum + " is Palindrome.");
	      return false;
	    }
	    else {
//	      System.out.println(originalNum + " is not Palindrome.");
	      return true;
	    }
	}
	
	
	// ham kt so Palindrome
	static int isPalindrome(int input, int b, int isOdd) {
	    int n = input;
	    int palin = input;
	 
	    // checks if number of digits is odd or even
	    // if odd then neglect the last digit of input in
	    // finding reverse as in case of odd number of
	    // digits middle element occur once
	    if (isOdd == 1)
	        n /= b;
	 
	    // Creates palindrome by just appending reverse
	    // of number to itself
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
	            i++;
	    }
	    }
	    
	    //source: https://www.geeksforgeeks.org/generate-palindromic-numbers-less-n/
	}	 
	
	static void m_palindrome_dau_tien_la_snt(int x) {
	    int number;
	    System.out.println("\n<---" + x + " so Palindrome dau tien la snt--->");
	    for (int j = 0; j < 2; j++) {
	        int i = 1, dem = 0;
	        while ((number = isPalindrome(i, 10, j % 2)) < x) {
	            if(prime(number))
		            System.out.print(number + "\t");
		        i++;
	    }
	    }
	}
	
	
	//
    /* Function to calculate x raised to the power y */
	 int power(int x, long y)
	 {
	     if( y == 0)
	         return 1;
	     if (y%2 == 0)
	         return power(x, y/2)*power(x, y/2);
	     return x*power(x, y/2)*power(x, y/2);
	 }
	
	 /* Function to calculate order of the number */
	 int order(int x)
	 {
	     int n = 0;
	     while (x != 0)
	     {
	         n++;
	         x = x/10;
	     }
	     return n;
	 }
	
	 // Function to check whether the given number is
	 // Armstrong number or not
	 boolean isArmstrong (int x)
	 {
	     // Calling order function
	     int n = order(x);
	     int temp=x, sum=0;
	     while (temp!=0)
	     {
	         int r = temp%10;
	         sum = sum + power(r,n);
	         temp = temp/10;
	     }
	
	     // If satisfies Armstrong condition
	     return (sum == x);
	 }
	
	 
	 //test2
	//function to check if the number is Armstrong or not  
	 static boolean isArmstrong2(int n)   
	 {   
		 int temp, digits=0, last=0, sum=0;   
		 //assigning n into a temp variable  
		 temp=n;   
		 //loop execute until the condition becomes false  
		 while(temp>0)    
		 {   
			 temp = temp/10;   
			 digits++;   
		 }   
		 temp = n;   
		 while(temp>0)   
		 {   
			 //determines the last digit from the number      
			 last = temp % 10;   
			 //calculates the power of a number up to digit times and add the resultant to the sum variable  
			 sum +=  (Math.pow(last, digits));   
			 //removes the last digit   
			 temp = temp/10;   
		 }  
		 //compares the sum with n  
		 if(n==sum)   
		 //returns if sum and n are equal  
		 return true;      
		 //returns false if sum and n are not equal  
		 else return false; 
		 
		 //source: https://www.javatpoint.com/armstrong-number-in-java
	 }
	 
	//in ra so isArmstrong2
	static void print_isArmstrong2(int x) 
	{
	    System.out.println("\n<--- Kiem tra so " + x + " co la Armstrong--->");
		if(isArmstrong2(x))  
		{  
			System.out.print(x  + " la so Armstrong");  
		}  
		else   
		{  
			System.out.print(x  + " khong la so Armstrong");  
		} 
	}
	
	 
	//in ra so isArmstrong3
	static void print_isArmstrong3(int x) 
	{
	    System.out.println("\n<---" + x + " so Armstrong--->");
	    int arr[] = new int[x];
		int i = 2, j = 0, dem = 0;
		while (dem < x) {
			if (isArmstrong2(i)) {
				arr[j] = i;
//				System.out.print(i + "\t");
//				System.out.println("arr[" + j + "]= " + arr[j]);
//				System.out.println(kt_cs_cong(x,arr));
				
				j++;
				
				dem++;
			}
			
			i++;
		}
		tinhTBC(arr);
		
//		if(isArmstrong2(x))  
//		{  
//			System.out.print(x  + " la so Armstrong");  
//		}  
//		else   
//		{  
//			System.out.print(x  + " khong la so Armstrong");  
//		} 
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
	
		bai1 b1 = new bai1();
		b1.m_snt_dau_tien(m);
		System.out.println("\n");
		b1.m_palindrome_dau_tien(m);
		System.out.println("\n");
		b1.m_palindrome_dau_tien_la_snt(m);
		
		
////		System.out.println("\n");
////		System.out.println(b1.isArmstrong(153));
		System.out.println("\n");
//		for(int i=0; i<=153; i++)
//			if(isArmstrong2(i))  
//				//prints the armstrong numbers  
//				System.out.print(i+ ", ");  
		b1.print_isArmstrong3(m);
		System.out.println("\n");
		
		
 
		
	}
}
