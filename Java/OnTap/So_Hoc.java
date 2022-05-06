package OnTap;

import java.util.Scanner;

public class So_Hoc {

	// properties
	private int m;

	// phuongthuc
	public void nhapDL() 
	{
		//(2<=m<=100), Exception
		Scanner sc = new Scanner(System.in);
		do {
			System.out.print("Nhập 1 số nguyên m (2<=m<=100): ");
			try {
				m = Integer.parseInt(sc.nextLine());
			} catch (Exception e) {m = 0;}
			if(2>m || m >100) 
			{
				System.out.println("Nhập 1 số nguyên m (2<=m<=100): ");
			}
		}while(2>m || m >100);
	}
	
	
	//kt snt
	public boolean isSNT(int k) 
	{
		if(k<2) return false;
		else{
			
			
			for (int i = 2; i < k; i++)
				if(k%i == 0) return false;
			return true;
		}
	}
	
	//count snt
	public int dem_snt() 
	{
		int dem = 0;
		for (int i = 0; i <= m; i++) {
			if(isSNT(i)) 
				dem ++;
		}
		
		return dem;
	}
	
	// ham hien thi snt <= n
	public void xuatSNT() {
		System.out.println("\n /===> Danh sach SNT <===/ \n");
		for (int j = 2; j <= m; j++)
			if (isSNT(j))
				System.out.print(j + "\t");
	}
	
	
	
	public static void main(String[] args) {
		So_Hoc sh = new So_Hoc();
		sh.nhapDL();
		System.out.println("\n\n /> Có " + sh.dem_snt() + " snt."); 
		sh.xuatSNT();
	}
}
