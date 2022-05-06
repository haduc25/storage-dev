package baitap_th2;

import java.io.*;
import java.util.Scanner;

public class TamGiac {
	private double canh_a, canh_b, canh_c;
	TamGiac(){}
	
	TamGiac(double a, double b, double c)
	{
		canh_a = a;
		canh_b = b;
		canh_c = c;
	}
	
	public void isTriangle()
	{
        double chuVi = canh_a + canh_b + canh_c;
        double temp = chuVi / 2;
        double dienTich = Math.sqrt(temp * (temp - canh_a) * (temp - canh_b) * (temp - canh_c));
        
//        System.out.printf("Chu vi tam giac: %.2f, Dien Tich tam giac: %.2f",chuVi,dienTich);
       
        
        //checking
        if (canh_a < canh_b + canh_c && canh_b < canh_a + canh_a + canh_c && canh_c < canh_a + canh_b)
        {
        	System.out.printf("Dien Tich tam giac: %.2f",dienTich);
            if (canh_a * canh_a == canh_b * canh_b + canh_c * canh_c || canh_b * canh_b == canh_a * canh_a + canh_c * canh_c || canh_c * canh_c == canh_a * canh_a + canh_b * canh_b)
            {
                System.out.println("\t =>Day la tam giac vuong!");
            }
            else if (canh_a == canh_b && canh_b == canh_c)
            {
                System.out.println("\t =>Day la tam giac deu!");
            }
            else if (canh_a == canh_b || canh_a == canh_c || canh_b == canh_c)
            {
                System.out.println("\t =>Day la tam giac can");
            }
            else
            {
                System.out.println("\t =>Day la tam giac thuong");
            }
        }
        else
        {
        	System.out.println("\t =>Canh A, B, C khong phai la 3 canh cua mot tam giac");
        }
	}
	
	
	
	//nhap
	public void nhap() 
	{
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Nhap canh A: ");
		do {
			try {
				canh_a = Double.parseDouble(sc.nextLine());
			} catch (Exception e) {
				canh_a = 0;
			}
			if (canh_a == 0)
				System.out.print("\t Nhap sai => Nhap lai canh A: ");
		} while (canh_a <= 0);
		
		System.out.print("Nhap canh B: ");
		do {
			try {
				canh_b = Double.parseDouble(sc.nextLine());
			} catch (Exception e) {
				canh_b = 0;
			}
			if (canh_b == 0)
				System.out.print("\t Nhap sai => Nhap lai canh B: ");
		} while (canh_b <= 0);
		
		System.out.print("Nhap canh C: ");
		do {
			try {
				canh_c = Double.parseDouble(sc.nextLine());
			} catch (Exception e) {
				canh_c = 0;
			}
			if (canh_c == 0)
				System.out.print("\t Nhap sai => Nhap lai canh C: ");
		} while (canh_c <= 0);
	}
	
	//xuat
	public void xuat() 
	{
		System.out.println("\n <====== Result ======> \n");
		
		System.out.println("Canh A: " + canh_a); 
		System.out.println("Canh B: " + canh_b);  
		System.out.println("Canh C: " + canh_c); 
	}
	
	
	public static void main(String[] args) {
		TamGiac tmp = new TamGiac();
		System.out.println("Tam giac :> ");
		tmp.nhap();
		tmp.xuat();
		tmp.isTriangle();
		
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
}
