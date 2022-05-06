package java1;

import java.util.Scanner;

public class bai2 {
	public static void main(String[] args) {
		/*
		 * Find max and min
		 */

		int a, b, max, min;
		Scanner sc = new Scanner(System.in);
		System.out.println("Nhap a: ");
		a = sc.nextInt();
		System.out.println("Nhap b: ");
		b = sc.nextInt();
		sc.close();
		System.out.println("value of a: " + a + "\nvalue of b: " + b);
		System.out.println("\n\t<---Max & Min--->");
		
		if (a > b) 
		{
			max = a;
			min = b;
		} else {
			max = b;
			min = a;
		}
		
		System.out.println("Max is: " + a + "\nMin is: " + b);
		
		
		
		System.out.println("\n\t<---LOOP-->");
		for (int i = 0; i < 5; i++) 
		{
			System.out.println(i);
		}
	}

}
