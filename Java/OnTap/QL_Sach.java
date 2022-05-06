package nhap_xuat_file;
/*
 a) Xây dựng lớp Sách gồm các thuộc tính: tên sách, tác giả, năm xuất bản; 
 có các phương thức gồm: toán tử tạo lập, nhập và hiển thị thông tin của đối tượng
 b) Xây dựng lớp QL_Sach với các phương thức:
 + Nhập và hiện thị 1 danh sách Sách
 + Nhập vào họ và tên của 1 tác giả. Hiển thị thông tin của tất cả các cuốn sách của tác giả đã nhập
 */
import java.io.*;
import java.util.*;
class Sach{
	// Các thuộc tính
	private String tenSach;
	private String tenTG;
	private int namXB;
	// Các toán tử tạo lập
	public Sach() {}
	public Sach(String tenSach) {
		this.tenSach = tenSach;
	}
	public Sach(String tenSach, String tenTG, int namXB) {
		this.tenSach = tenSach;
		this.tenTG = tenTG;
		this.namXB = namXB;
	}
	// Các phương thức
	public String getTenTG() { return tenTG;}
	public void nhapTT() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Tên sách: "); tenSach = sc.nextLine();
		System.out.print("Tên tác giá: "); tenTG = sc.nextLine();
		System.out.print("Năm XB: "); namXB = sc.nextInt();
	}
	public void hienThiTT() {
		System.out.println("\t Tên sách = " + tenSach); 
		System.out.println("\t Tên tác giả = " + tenTG);
		System.out.println("\t Năm XB = " + namXB);
	}
	
}
public class QL_Sach {
	private int m;
	private Sach ds[];
	public void nhapDS_TuBanPhim() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhập số lượng sách:");
		do {
			try {
				m = Integer.parseInt(sc.nextLine());
			}catch(Exception e) {
				m=-1;
			}	
			if(m<=0) System.out.print("\t Nhập sai ==> Nhap lại số lượng sách (>0):");
		}while (m<=0);
		
		ds = new Sach[m];
		for(int i=0;i<m;i++) {
			System.out.println("Nhập thông tin của sách thứ <" + i + "> ");
			ds[i]=new Sach();
			ds[i].nhapTT();
		}
	}
	public void nhapDS_TuFileVB() {
	// đọc dữ liệu từ filename, sau đó gán cho các thuộc tính của lớp hiện tại	
		String inputFile="E:\\Eclipse\\Src\\eclipse-workspace\\java2\\src\\nhap_xuat_file\\sach.txt";
		try {
			File file = new File(inputFile);
			FileReader reader=new FileReader(file);
			BufferedReader in = new BufferedReader(reader);
			
			String st="";
			
			//Đọc số sách 
			st = in.readLine();
			m = Integer.parseInt(st);
			ds = new Sach[m];
			
			// Đọc giá trị cho từng sách
			for(int i=0; i<m; i++) {
				String ts = in.readLine().trim();
				String ttg = in.readLine().trim();
				int nxb=Integer.parseInt(in.readLine());
					
				ds[i] = new Sach(ts,ttg,nxb);	
			}
	
		}catch(Exception e) { 
			System.out.println(e.getMessage());
		}
	}
	public void hienThiDS() {
		for(int i=0;i<m;i++) {
			System.out.println("\n---------------------------------------------");
			ds[i].hienThiTT();
		}
	}
	public void timKiemTenTG(String ttg) {
		
		for(int i=0;i<m;i++)
			if(ds[i].getTenTG().equalsIgnoreCase(ttg)) {
				System.out.println("-----------------------------------------");
				ds[i].hienThiTT();
			}
	}
	public static void main(String arg[]) {
		QL_Sach ql = new QL_Sach();
		//ql.nhapDS_TuBanPhim();
		ql.nhapDS_TuFileVB();
		System.out.println("\n ======= DANH SÁCH ĐÃ NHẬP =======");
		ql.hienThiDS();
		
		String ttg;
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhập vào tên tác giả cần tìm: "); ttg=sc.nextLine().trim();
		
		System.out.println("\n ======= DANH SÁCH TÌM KIẾM ĐƯỢC =======");
		ql.timKiemTenTG(ttg);
	}
}
