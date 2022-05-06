package OnTap;

import java.io.*;
import java.util.*;

public class ToanHoc {
	// properties
	private int m;

	// phuongthuc
	public void nhapDL() 
	{
		//(2<=m<=100), Exception
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhập 1 số nguyên m (2<=m<=100): ");
		do {
			
			try {
				m = Integer.parseInt(sc.nextLine());
			} catch (Exception e) {m = 0;}
			if(2>m || m >100) 
				System.out.print("\t=> Nhap sai vui long nhap lai (2<m<100): ");
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
	
	//display snt m snt dau tien
	public void xuatSNT() 
	{
		System.out.println("\n /===> Danh sach [" + m + "] SNT dau tien la <===/ \n");
		int j=2,dem=0;
		while(dem<m) 
		{
			if(isSNT(j)) 
			{
				System.out.print(j + "\t");
				dem++;
			}
			j++;
		}
	}
	
	//kt so hoan hao
	  public boolean ktraSoHH(int k){
		    int sum = 0;
		    for(int i=1;i<=k/2;i++){
		      if(k%i==0) 
		        //tổng các ước số của a
		        sum+=i;
		    }
		    if(sum==k)return true;
		    return false;
		  }
		
	  //xuat so hoan hao
	  public void xuatSOHH() 
	  {
		    System.out.println("Các số hoàn hảo <= " + m +" là: ");
		    // sử dụng vòng lặp for để duyệt từng phần tử và kiểm tra, nếu thỏa mãn thì in ra màn hình
		    for (int i = 1; i <= m;i++) {
		      if(ktraSoHH(i)){
		        System.out.print(i + "\t");
		      }
		    }
	  }
	
	
	
	public static void main(String[] args) {
		ToanHoc th = new ToanHoc();
		th.nhapDL();
		//th.xuatSNT();
		th.xuatSOHH();
	}

}
















































