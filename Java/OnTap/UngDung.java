package baitap_th6;

import java.util.Scanner;

public class UngDung {
	private int soHang, soCot;
	private int M[][];

	public UngDung() {
	}

	public UngDung(int _hang, int _cot) {
		this.soHang = _hang;
		this.soCot = _cot;
		M = new int[soHang][soCot];
	}

	// nhap size Ma tran mxn
	public void nhapSize(Scanner sc) {
		System.out.print("Nhap so hang: ");
		do {
			soHang = sc.nextInt();
		} while (soHang <= 0);
		
		System.out.print("Nhap so cot: ");
		do {

			soCot = sc.nextInt();
		} while (soCot <= 0);
	}

	// nhap mt
	public void nhapMT(Scanner sc) {
		M = new int[soHang][soCot];
		System.out.println("Nhap ma tran (mxn)" + soHang + "x" + soCot);

		for (int i = 0; i < soHang; i++) {
			for (int j = 0; j < soCot; j++) {
				System.out.print("M[" + (i + 1) + "][" + (j + 1) + "]= ");
				M[i][j] = sc.nextInt();
			}
		}
	}

	// xuat mt
	public void xuatMT() {
		for (int i = 0; i < soHang; i++) {
			for (int j = 0; j < soCot; j++) {
				System.out.print(M[i][j]+"\t");
			}
			System.out.print("\n");
		}
	}
	
	
	//sx các pt của mt giảm dần theo mỗi cột
	public void sortCol() 
	{
		int temp;
		for (int i = 0; i < soCot; i++) {
			for (int j = 1; j < soHang; j++) {
				for (int k = 0; k < j; k++) {
					if(M[j][i] > M[k][i]) 
					{
						temp = M[j][i];
						M[j][i] = M[k][i];
						M[k][i] = temp;
					}
				}
			}
			System.out.print("\n");
		}
	}

	//kt snt trong mt
    boolean ktSnt(int k) {        
		if(k<2) return false;
		else {
			for(int i=2;i<k;i++)
				if(k%i==0) return false;
			return true;
		}
    }
    
	//count snt
	public int demSnt() 
	{
		int dem = 0;
		for (int i = 0; i < soHang; i++) {
			for (int j = 0; j < soCot; j++) {
				if(ktSnt(M[i][j]))
				{
					dem ++;
				}
			}
		}
		
		return dem;
	}
	
	
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		UngDung ud = new UngDung();
		ud.nhapSize(sc);
		ud.nhapMT(sc);
		ud.sortCol();
		System.out.println("/===> Ma tran sap xep giam dan theo moi cot<===/ \n");
		ud.xuatMT();
		
		System.out.print("\n/=> Tổng số các pt là snt trong mt M: " + ud.demSnt());
		sc.close();
	}

}
