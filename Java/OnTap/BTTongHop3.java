/*
 * 
 * xay dung class SoPhuc
	1. properties private (phanThuc, phanAo) double
	2. tao toan tu tao lap SoPhuc(), SoPhuc(float pt, float pa)
	3. phuong thuc thuc hien
		void nhapSoPhuc();
		void inSoPhuc();
	cong so phuc: SoPhuc congSoPhuc(SoPhuc sp)
	nhan so phuc: SoPhuc nhanSoPhuc(SoPhuc sp)
	
	4. cai dat main nhap vao 2 so phuc A=a+	bi va B=c+di
	tinh: so phuc tong SP_TONG=A.nhanSoPhuc(B)
	      so phuc tinh SP_TICH.nhanSoPhuc(B)
 * */

package baitap_th;
import java.io.*;
import java.util.*;



class SoPhuc
{
	// Thuoc tinh
	private double phanThuc, phanAo;
	 // Phuong thuc
	SoPhuc()
	{
		phanThuc = 0; phanAo = 0;
	}
	
	SoPhuc(float pt, float pa)
	{
		this.phanThuc = pt;
		this.phanAo = pa;
	}
	
	//nhap
	void nhapSP() 
	{
		Scanner sc = new Scanner(System.in);
		
		do 
		{
			System.out.print("Nhap phan thuc: "); 
			try{
				phanThuc = Double.parseDouble(sc.nextLine());
			}catch(Exception ex) { phanThuc = 0;}
		}while(phanThuc<=0);
		
		do 
		{
			System.out.print("Nhap phan ao: ");
			try{
				phanAo = Double.parseDouble(sc.nextLine());
			}catch(Exception ex) { phanAo = 0;}
		}while(phanAo<=0);
//		sc.close();
	}
	
	//xuat
	void xuatSP() 
	{
		if (phanAo < 0) 
		{
			//Math.abs() : tinh gia tri tuyet doi
			System.out.println(phanThuc + " - " + Math.abs(phanAo) + "*i");
		} else {
			System.out.println(phanThuc + " + " + phanAo + "*i");
		}
	}
	
    //cong
    public SoPhuc congSP(SoPhuc sp1, SoPhuc sp2) {
    	SoPhuc spTemp = new SoPhuc();
    	spTemp.phanThuc = sp1.phanThuc + sp2.phanThuc;
    	spTemp.phanAo = sp1.phanAo + sp2.phanAo;
    	
    	return spTemp;
    }
	
    
	//nhan
    public SoPhuc nhanSP(SoPhuc sp1, SoPhuc sp2) {
    	SoPhuc spTemp = new SoPhuc();
    	spTemp.phanThuc = sp1.phanThuc * sp2.phanThuc - sp1.phanAo * sp2.phanAo;
    	spTemp.phanAo = sp1.phanThuc * sp2.phanAo + sp2.phanThuc * sp1.phanAo;
    	return spTemp;
    }
}


public class BTTongHop3 {
	public static Scanner sc = new Scanner(System.in);
	public static void main(String[] args) {
		SoPhuc sp1 = new SoPhuc();
		SoPhuc sp2 = new SoPhuc();
		SoPhuc sp = new SoPhuc();
		
		//nhap
		System.out.println("<===/ Nhap so phuc [1] /===>");
		sp1.nhapSP();
		System.out.println("<===/ Nhap so phuc [2] /===>");
		sp2.nhapSP();
		
		//xuat
		System.out.println();
		System.out.print("So phuc [1]: ");
		sp1.xuatSP();
		System.out.print("So phuc [2]: ");
		sp2.xuatSP();
		
		//cong
		sp = sp.congSP(sp1,sp2);
		System.out.print("\t==>Tong (+) cua so phuc [1] va [2]: ");
		sp.xuatSP();
		
		//nhan
		sp = sp.nhanSP(sp1, sp2);
		System.out.print("\t==>Tich (*) cua so phuc [1] va [2]: ");
		sp.xuatSP();

		
		
		
	}
}
