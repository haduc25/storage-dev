package java2;
import java.util.*; 
import java.io.*;

public class bai3 
{
	public static Scanner sc = new Scanner(System.in);
	public static void main(String[] args)
	{
		/*
		 *Nhap so tuong ung voi thu trong tuan 
		 *Vd: 2 - Thu 2, 3 - Thu 3..., 
		 */
		Integer n = null;
		System.out.print("Nhập số nguyên dương thể hiện thứ trong tuần (2, 3, 4...): ");
		try {
			n = Integer.parseInt(sc.nextLine());
			
			switch(n) 
			{
				case 2: 
					System.out.println("Monday");
					break;
				case 3: 
					System.out.println("Tuesday");
					break;
				case 4: 
					System.out.println("Wednesday");
					break;
				case 5: 
					System.out.println("Thursday");
					break;
				case 6: 
					System.out.println("Friday");
					break;
				case 7: 	
					System.out.println("Saturday");
					break;
				case 8: 
					System.out.println("Sunday");
					break;
				default: 
					System.out.println("No corresponding day!");
					break;
				}
		}catch(InputMismatchException ime) 
		{
			System.out.println("Nhập sai định dạng, vui lòng nhập lại !\n" + ime);
			
		}
		catch(NumberFormatException nfe)
		{
			System.out.println("Nhập sai định dạng hoặc để trống, vui lòng nhập lại !\n" + nfe);
			n = null;
		}


		
		
		
		
	}
}
