package baitap_th6;

import java.io.*;
import java.util.*;


public class PhanSo {
	private int tuSo, mauSo;
	
	public PhanSo() {
		tuSo=0;
		mauSo=1;
	}
	
	public PhanSo(int ts, int ms) 
	{
		this.tuSo = ts;
		this.mauSo = ms;
	}
	
	//nhap
	public void nhap(Scanner sc) 
	{
		int a, b;
		
		System.out.print("Nhập tử số: "); a = sc.nextInt();
		System.out.print("\nNhập mẫu số: ");
		do 
		{	
			b = sc.nextInt();
			 
			if(b==0) 
			{
				System.out.print("\nMẫu số phải khác 0\t => Nhập lại mẫu số: ");
			}else 
			{
				tuSo = a;
				mauSo = b;
			}
												
		}while(b==0);
		
	}
	
	//xuat
	public void xuat() 
	{
		//kt tuSo & mauSo < 0
		if(tuSo*mauSo < 0) 
		{
			//Math.abs(mauSo): lấy giá trị tuyệt đối |mauSo|
			System.out.println("\t-" + Math.abs(tuSo) + "/" + Math.abs(mauSo));
		}else 
		{
			System.out.println("\t" + Math.abs(tuSo) + "/" + Math.abs(mauSo));
		}
	}
	
	//tìm và in ra kq dạng tối giản của 1 đối tượng phân số
	
	//ước số chung lớn nhất
	private int timUSCLN(int a, int b) 
	{
		int r = a%b;
		while(r!=0) 
		{
			a=b;
			b=r;
			r=a%b;
		}
		return b;
	}
	
	//kt tối giản
	public boolean ktToiGian() 
	{
		if(timUSCLN(tuSo, mauSo) == 1)
			return true;
		return false;
	}
	
	
	//tối giản phân số
	public void toiGianPhanSo() 
	{
		int x = timUSCLN(tuSo, mauSo);
		
		tuSo/=x;
		mauSo/=x;
	}
	
	
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		PhanSo ps = new PhanSo();
		ps.nhap(sc);
		
		System.out.println("\n/===>Hiển thị phân số <===/");
		ps.xuat();
		
		//kt so toi gian
		if(!ps.ktToiGian()) 
		{
			System.out.println("\n/===>Phân số sau khi tối giản <===/");
			ps.toiGianPhanSo();
			ps.xuat();
		}
		sc.close();
	}
	
	
}
