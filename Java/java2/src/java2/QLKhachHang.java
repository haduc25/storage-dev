package java2;

import java.io.*;
import java.util.Scanner;

class KhachHang {
	private String ma;
	private String hoTen;
	private int tuoi;
	private String diaChi;
	private int sdt;
	private String email;

	KhachHang() {
	}

	KhachHang(String ms) {
	}

	KhachHang(String ms, String ht, int t, String dc, int dt, String em) {
		ma = ms;
		hoTen = ht;
		tuoi = t;
		diaChi = dc;
		sdt = dt;
		email = em;
	}

	public void nhapTT() {
		Scanner sc = new Scanner(System.in);
		System.out.print("\t Ma so KH: ");
		ma = sc.nextLine();
		System.out.print("\t Ho ten: ");
		hoTen = sc.nextLine();
		System.out.print("\t Tuoi: ");
		do {
			try {
				tuoi = Integer.parseInt(sc.nextLine());
			} catch (Exception e) {
				tuoi = 0;
			}
			if (tuoi == 0)
				System.out.print("\t Nhap sai => vui long nhap lai Tuoi: ");
		} while (tuoi <= 0);

		System.out.print("\t Dia chi: ");
		diaChi = sc.nextLine();
		System.out.print("\t So dien thoai: ");
		do {
			try {
				sdt = Integer.parseInt(sc.nextLine());
			} catch (Exception e) {
				sdt = 0;
			}
			if (sdt == 0)
				System.out.print("\t Nhap sai => vui long nhap lai So dien thoai: ");
		} while (sdt <= 0);

		System.out.print("\t Email: ");
		email = sc.nextLine();
//		sc.close();
	}

	public void hienthiTT() {
		System.out.println("Ma KH: " + ma);
		System.out.println("Ho ten KH: " + hoTen);
		System.out.println("Tuoi KH: " + tuoi);
		System.out.println("Dia chi KH: " + diaChi);
		System.out.println("SDT KH: 0" + sdt);
		System.out.println("Email KH: " + email);
	}

	public int getTuoi() {
		return tuoi;
	}

	public String getTen() {
		return hoTen;
	}

}

public class QLKhachHang {
	private int n;
	private KhachHang dskh[];

	public void nhapDSKH() {
		Scanner sc = new Scanner(System.in);

		System.out.print("Nhap so luong KH: ");
		do {
			try {
				n = Integer.parseInt(sc.nextLine());
			} catch (Exception e) {
				n = 0;
			}
			if (n == 0)
				System.out.print("\t Nhap sai => vui long nhap lai so luong KH: ");
		} while (n <= 0);

		dskh = new KhachHang[n];
		for (int i = 0; i < n; i++) {
			System.out.println("\n =====Nhap thong tin KH thu [" + (i + 1) + "]======");
			dskh[i] = new KhachHang();
			dskh[i].nhapTT();
		}
//		sc.close();
	}

	public void hienthiDSKH() {

		for (int j = 0; j < n; j++) {
			System.out.println("\n =====Thong tin KH thu [" + (j + 1) + "]======");
			dskh[j].hienthiTT();
		}
	}

	public void sxTheoTuoi() {
		KhachHang tg = new KhachHang();
		for (int i = 0; i < n - 1; i++)
			for (int j = i + 1; j < n; j++) {
				if (dskh[i].getTuoi() < dskh[j].getTuoi()) {
					tg = dskh[i];
					dskh[i] = dskh[j];
					dskh[j] = tg;
				}
			}
	}

	public void timTheoTen() {
		String name = "Nguyen Van Duc";
		boolean check = false;
		for (int i = 0; i < dskh.length; i++)
			if (dskh[i].getTen().equalsIgnoreCase(name)) {
				dskh[i].hienthiTT();
				check = true;
			}

		if (!check) {
			System.out.println("\n Khong tim thay khach hang co ten '" + name + "' !\n");
		}

	}

	public static void main(String arg[]) {
		QLKhachHang tmp = new QLKhachHang();
		tmp.nhapDSKH();
		System.out.print("\n ===>Thong tin khach hang da nhap<===");
		tmp.hienthiDSKH();
		tmp.sxTheoTuoi();
		System.out.print("\n ===>Thong tin khach hang sau khi sap xep giam dan theo tuoi<===");
		tmp.hienthiDSKH();
		System.out.print("\n ===>Thong tin khach hang co ten 'Nguyen Van Duc'<===\n");
		tmp.timTheoTen();
	}
}