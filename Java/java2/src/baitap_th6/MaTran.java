package baitap_th6;

import java.util.Scanner;

public class MaTran {
	private int soHang, soCot;
	private int A[][];

	public MaTran() {
	}

	public MaTran(int _hang, int _cot) {
		this.soHang = _hang;
		this.soCot = _cot;
		A = new int[soHang][soCot];
	}

	// nhap size Ma tran
	public void nhapSize(Scanner sc) {
		// hang
		System.out.print("Nhap so hang: ");
		do {
			soHang = sc.nextInt();
		} while (soHang <= 0);

		// cot
		System.out.print("Nhap so cot: ");
		do {

			soCot = sc.nextInt();
		} while (soCot <= 0);
	}

	// nhap mt
	public void nhapMT(Scanner sc) {
		A = new int[soHang][soCot];
		System.out.println("Nhap ma tran " + soHang + "x" + soCot);

		for (int i = 0; i < soHang; i++) {
			for (int j = 0; j < soCot; j++) {
				System.out.print("A[" + (i + 1) + "][" + (j + 1) + "]= ");
				A[i][j] = sc.nextInt();
			}
		}
	}

	// xuat mt
	public void xuatMT() {
		for (int i = 0; i < soHang; i++) {
			for (int j = 0; j < soCot; j++) {
				System.out.print(A[i][j]+"\t");
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
					if(A[j][i] > A[k][i]) 
					{
						temp = A[j][i];
						A[j][i] = A[k][i];
						A[k][i] = temp;
					}
				}
			}
			System.out.print("\n");
		}
	}

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		MaTran mt = new MaTran();
		mt.nhapSize(sc);
		mt.nhapMT(sc);
		System.out.println("\n=================================\n");
		mt.xuatMT();
		
		mt.sortCol();
		System.out.println("\n/===> Ma tran sau khi sap xep <===/ \n");
		mt.xuatMT();
	
		sc.close();
	}

}
