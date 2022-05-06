package nhap_xuat_file;

import java.io.*;
import java.util.*;

//phuong tien
class PhuongTien {
	private String hangSX, mauPT;

	public PhuongTien() {
	}

	public PhuongTien(String hangsx) {
		this.hangSX = hangsx;
	}

	public PhuongTien(String hangsx, String maupt) {
		this.hangSX = hangsx;
		this.mauPT = maupt;
	}

	public String getHangSX() {
		return hangSX;
	}

	public void setHangSX(String hangSX) {
		this.hangSX = hangSX;
	}

	public String getMauPT() {
		return mauPT;
	}

	public void setMauPT(String mauPT) {
		this.mauPT = mauPT;
	}

	// nhap
	public void nhapTT() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhập hãng sản xuất: ");
		hangSX = sc.nextLine();
		System.out.print("Nhập màu phương tiện: ");
		mauPT = sc.nextLine();
	}

	// xuat
	public void xuatTT() {
		System.out.println("Hãng SX: " + hangSX);
		System.out.println("Màu phương tiện: " + mauPT);
	}

}

//xe may
class XeMay extends PhuongTien {
	private String bienSo;
	private double giaThanh;

	public XeMay() {
	}

	public XeMay(String hangsx, String maupt, String bs, double gt) {
		super(hangsx, maupt);
		this.bienSo = bs;
		this.giaThanh = gt;
	}

	public void nhapXM() {
		super.nhapTT();
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhập biển số: ");
		bienSo = sc.nextLine();
		System.out.print("Nhập giá thành: ");
		do {
			try {
				giaThanh = Double.parseDouble(sc.nextLine());
			} catch (Exception e) {
				giaThanh = -1;
			}
			if (giaThanh < 0)
				System.out.print("\t Nhập sai ==> Nhập lại giá xe máy: ");
		} while (giaThanh < 0);
	}

	public void hienThiXM() {
		super.xuatTT();
		System.out.println("Biển số: " + bienSo);
		System.out.println("Giá thành: " + giaThanh);
	}

	public String getbienSo() {
		return bienSo;
	}

	public Double getGia() {
		return giaThanh;
	}

}

public class QL_XeMay {
	private int m;
	private XeMay xm[];

	// nhap ban phim
	public void nhapDLBanPhim() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhập số lượng xe máy (2<= m <= 20): ");

		do {
			try {
				m = Integer.parseInt(sc.nextLine());
			} catch (Exception e) {
				m = -1;
			}
			if (m < 2 || m > 20)
				System.out.print("\t Nhập sai ==> Nhập lại số lượng xe máy (2<= m <= 20): ");
		} while (m < 2 || m > 20);

		xm = new XeMay[m];
		for (int i = 0; i < xm.length; i++) {
			System.out.println("\nNhập thông tin của xe máy thứ [" + (i + 1) + "] ");
			xm[i] = new XeMay();
			xm[i].nhapXM();
		}

	}

	// nhap tu file
	public void nhapDLFile() {
		String inputFile = "E:\\Eclipse\\Src\\eclipse-workspace\\java2\\src\\nhap_xuat_file\\DSXeMay.txt";
		try {
			File file = new File(inputFile);
			FileReader reader = new FileReader(file);
			BufferedReader buffered = new BufferedReader(reader);

			String st = "";

			st = buffered.readLine();
			m = Integer.parseInt(st);
			xm = new XeMay[m];

			// read file
			for (int i = 0; i < xm.length; i++) {
				String hangsx = buffered.readLine().trim();
				String maupt = buffered.readLine().trim();
				String bienso = buffered.readLine().trim();
				double giathanh = Double.parseDouble(buffered.readLine());

				xm[i] = new XeMay(hangsx, maupt, bienso, giathanh);
			}

		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
	}

	// xuat file
	public void xuatDLFile()
	{
		try 
		{
		     File file = new File("E:\\Eclipse\\Src\\eclipse-workspace\\java2\\src\\nhap_xuat_file\\printDSXeMay.txt");
		     FileWriter fw = new FileWriter(file); 
		     
		     System.out.println("come");
		     
			 for (int i = 0; i < xm.length; i++) { 
				fw.write("\n---------------------------------------------");
				fw.write("\n\nnHangSX: " +  xm[i].getHangSX() + "\nmau xe: " + xm[i].getMauPT() + "\nBien so: " + xm[i].getbienSo() + "\nGia: " + xm[i].getGia());
			    System.out.println("Đã xuất file thành công!");
			    fw.close();
		}catch(Exception e)
		{
			System.out.println("wrong");
			System.out.println(e.getMessage());
		}

	}

	// xuat
	public void xuatDS() {
		for (int i = 0; i < xm.length; i++) {
			System.out.println("\n---------------------------------------------");
			xm[i].hienThiXM();
		}
	}

	// nhap so x hien thi gia thanh cua xe may (gia thanh <= x)
	public void giaThanhX(double x) {
		for (int i = 0; i < m; i++) {
			System.out.println("\n---------------------------------------------");
			if (xm[i].getGia() <= x)
				xm[i].hienThiXM();
		}
	}

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		double x = 0;
		QL_XeMay qlxm = new QL_XeMay();
//		qlxm.nhapDLBanPhim();

		qlxm.nhapDLFile();
//		System.out.println("\n />======= DANH SÁCH ĐÃ NHẬP =======</");
		qlxm.xuatDS();
//		qlxm.xuatDLFile();

//		System.out.print("\n/>Nhập giá thành x: "); x = sc.nextDouble();
//		qlxm.giaThanhX(x);
	}

}
