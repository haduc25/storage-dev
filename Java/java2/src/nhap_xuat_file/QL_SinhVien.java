package nhap_xuat_file;

import java.io.*;
import java.util.*;

class Nguoi
{
	private String hoTen;
	private int namSinh;
	
	// Các toán tử tạo lập
	public Nguoi() {}
	public Nguoi(String ht) {
		this.hoTen = ht;
	}
	public Nguoi(String ht, int ns) {
		this.hoTen = ht;
		this.namSinh = ns;
	}
	
	// Các phương thức
	public void nhapTT() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhập họ & tên: "); hoTen = sc.nextLine();
		System.out.print("Nhập năm sinh: "); namSinh = sc.nextInt();
	}
	
	public void hienThiTT() {		
		System.out.println("\t Họ & tên: " + hoTen); 
		System.out.println("\t Năm sinh: " + namSinh);
	}
}

class SinhVien extends Nguoi
{
	private String lop;
	private double dtb;
	
	// Các toán tử tạo lập
	public SinhVien() {}
	public SinhVien(String ht, int ns, String _lop, double _dtb) {
		super(ht, ns);
		this.lop = _lop;
		this.dtb = _dtb;
	}
	
	// Các phương thức
	public void nhapTT() {
		super.nhapTT();
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhập lớp: "); lop = sc.nextLine();
		System.out.print("Nhập điểm tb: "); dtb = sc.nextDouble();
	}
	
	public void hienThiTT() {	
		super.hienThiTT();
		System.out.println("\t Lớp: " + lop); 
		System.out.println("\t ĐTB: " + dtb);
	}
	
	//lay diem tb
	public double getDTB() 
	{
		return dtb;
	}
	
}



public class QL_SinhVien {
	private int m;
	private SinhVien ds[];
	
	//nhap dl from ban phim
	public void nhapDS_TuBanPhim() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhập số lượng sinh viên (2<= m <= 60): ");
		do {
			try {
				m = Integer.parseInt(sc.nextLine());
			}catch(Exception e) {
				m=-1;
			}	
			if(m < 2 || m > 60) System.out.print("\t Nhập sai ==> Nhập số lượng sinh viên (2<= m <= 60): ");
		}while (m < 2 || m > 60);
		
		
		ds = new SinhVien[m];
		for(int i=0;i<m;i++) {
			System.out.println("\nNhập thông tin của sinh viên thứ [" + (i + 1) + "] ");
			ds[i]=new SinhVien();
			ds[i].nhapTT();
		}
	}
	
	
	//nhap dl tu file
	public void nhapDS_TuFile() 
	{
		// đọc dữ liệu từ filename, sau đó gán cho các thuộc tính của lớp hiện tại
		String inputFile = "E:\\Eclipse\\Src\\eclipse-workspace\\java2\\src\\nhap_xuat_file\\sinhvien.txt";
		try 
		{
			File file = new File(inputFile);
			FileReader reader = new FileReader(file);
			BufferedReader in = new BufferedReader(reader);
			
			String st = "";
			
			//Đọc số sách
			st = in.readLine();
			m = Integer.parseInt(st);
			ds = new SinhVien[m];
			
			
			//Đọc giá trị cho từng sách
			for (int i = 0; i < ds.length; i++) {
				String ht = in.readLine().trim();
				int ns = Integer.parseInt(in.readLine());
				String lop = in.readLine().trim();
				double dtb = Double.parseDouble(in.readLine());
				
				
				
				ds[i] = new SinhVien(ht, ns, lop, dtb);
			}
			
			
		}catch(Exception e) 
		{
			System.out.println(e.getMessage());
		}
		
	}
	
	
	
	//xuat
	public void hienThiDS() {
		for(int i=0;i<m;i++) {
			System.out.println("\n---------------------------------------------");
			ds[i].hienThiTT();
		}
	}
	
	//lay dtb > 8.5
	public void dtbLonHon85() {
		for(int i=0;i<m;i++) {
			System.out.println("\n---------------------------------------------");
			if(ds[i].getDTB() > 8.5)
				ds[i].hienThiTT();
		}
	}
	
	

	public static void main(String[] args) {
		QL_SinhVien qlsv = new QL_SinhVien();
//		qlsv.nhapDS_TuBanPhim();
		qlsv.nhapDS_TuFile();
		System.out.println("\n />======= DANH SÁCH ĐÃ NHẬP =======</");
		qlsv.hienThiDS();
	}
	
	
	
	
		
}
