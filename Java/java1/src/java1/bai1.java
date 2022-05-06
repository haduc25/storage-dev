package java1;
import java.util.*; 

public class bai1 
{
	public static void main(String[] args)
	{
		/*s
		 *Nhap so tuong ung voi thu trong tuan 
		 *Vd: 2 - Thu 2, 3 - Thu 3..., 
		 */
		
		
		System.out.println("\n Hello World ");
		int n;
		//khai bao lop Scanner
		Scanner scan = new Scanner(System.in);
		
		n = scan.nextInt();
		System.out.println("gia tri cua n: " + n);
		scan.close();
	
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
		
		
		
		
	}
}
