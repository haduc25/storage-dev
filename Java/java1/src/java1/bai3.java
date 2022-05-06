package java1;

import java.util.Scanner;

public class bai3 {

	// ham kt snt
	public boolean ktsnt(int x) {
		for (int i = 2; i < x; i++)
			if (x % i == 0)
				return false;
		return true;
	}

	// ham hien thi snt <= n
	public void snt_nho_hon_n(int x) {
		System.out.println("\n<---Cac snt nho hon " + x + "--->");
		for (int j = 2; j <= x; j++)
			if (ktsnt(j))
				System.out.print(j + "\t");
	}

	// ham hien thi n snt dau tien
	public void n_snt_dau_tien(int x) {
		System.out.println("\n<---" + x + " snt dau tien--->");
		int i = 2, dem = 0;
		while (dem < x) {
			if (ktsnt(i)) {
				System.out.print(i + "\t");
				dem++;
			}
			i++;
		}
	}

	// ham tinh Fibonacci
	public int tinh_Fibo(int x) {
		if (x < 0)
			return -1;
		else if (x == 0 || x == 1)
			return 1;
		else
			return tinh_Fibo(x - 1) + tinh_Fibo(x - 2);
	}

	// ham hien thi n snt dau tien
	public void n_fibo_dau_tien(int x) {
		System.out.println("\n<---" + x + " fibo dau tien--->");
		for (int j = 0; j <= x - 1; j++) {
			System.out.print(tinh_Fibo(j) + "\t");
		}
	}

	public static void main(String[] args) {
		/*
		 * Nhap n tu ban phim (2 <= n <= 100).
		 * Hien thi ra tat ca so nguyen to <= n.
		 * Hien thi ra n so nguyen to dau tien. 
		 * Hien thi ra tat ca so Fibonacci <= n.
		 * Hien thi ra n so Fibonacci dau tien.
		 */
		Scanner sc = new Scanner(System.in);
		int n;
		System.out.println("Nhap n: ");
		do {
			n = sc.nextInt();

			// kt n
			if (n < 2 || n > 100)
				System.out.println("Nhap lai n: ");

		} while (n < 2 || n > 100); // if(dk=true)-> loop

		System.out.println(n + " Hop le!");
		sc.close();

		bai3 b3 = new bai3();
		b3.snt_nho_hon_n(n);
		b3.n_snt_dau_tien(n);
		b3.n_fibo_dau_tien(n);

	}
}
