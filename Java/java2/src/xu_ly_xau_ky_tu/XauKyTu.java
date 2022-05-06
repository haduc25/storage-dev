package xu_ly_xau_ky_tu;

import java.io.*;
import java.util.*;

public class XauKyTu {
	private String st;

	public XauKyTu() {
	}

	public XauKyTu(String s) {
		st = s;
	}

	public void nhapXau() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhập vào xâu ký tự: ");
		st = sc.nextLine();
	}

	public String getXau() {
		return st;
	}

	public void chuanHoaXau() {
		/*
		 * \\s - khớp với ký tự khoảng trắng đơn 
		 * \\s+ - khớp chuỗi của một hoặc nhiều ký tự khoảng trắng.
		 */
		st = st.trim().toLowerCase(); // cắt 'space' & cho về lowercase
		st = st.replaceAll("\\s+", " ");
		String[] temp = st.split(" ");
		st = "";
		for (int i = 0; i < temp.length; i++) {
			st += String.valueOf(temp[i].charAt(0)).toUpperCase() + temp[i].substring(1);
			if (i < temp.length - 1)
				st += " ";
		}
	}

	// Hàm đếm số từ.
	public int demSoTu() {
		int dem = 0;
		for (int i = 0; i < st.length(); i++) {
			if (st.charAt(i) != ' ')
				dem++;
		}
		return dem;
	}

	// Hàm đếm từ xuất hiện bằng kí tự G.
	public int demTuKetThucBoiKyTuG() {
		int dem = 0;
		boolean checker = false;
		
		
		for (int i = 0; i < st.length(); i++) 
		{
			if(st.charAt(i) == ' ' || st.charAt(st.length() -1 ) == ' ')
				checker = true;
			else
				checker = false;
		}		
		
		if(checker) 
		{
			for (int i = 0; i < st.length(); i++) {
			if (st.charAt(i) == 'g' && st.charAt(i+1) == ' ')
				dem++;
			}
		}else 
		{
			for (int i = 0; i < st.length(); i++) {
			if (st.charAt(i) == 'g')
				dem++;
			}
		}
			
			
		return dem;
	}

	// Hàm đếm ký tự chữ số.
	public int demKyTuChuSo() {
		int dem = 0;
		for (int i = 0; i < st.length(); i++) {
			if (st.charAt(i) >= 48 && st.charAt(i) <= 57)
				dem++;
		}
		return dem;
	}
	
	
	public static void main(String[] args) {
		XauKyTu xkt = new XauKyTu();
		xkt.nhapXau();
		System.out.println("==>Xâu vừa nhập là: " + xkt.getXau());
		//so tu
		System.out.print("\n\t -Số từ trong xâu là: " + xkt.demSoTu());
		//tu ket thuc boi 'g'
		System.out.print("\n\t -Số từ trong xâu kết thúc bởi ký tư 'g' là: " + xkt.demTuKetThucBoiKyTuG());
		//ky tu chu so
		System.out.print("\n\t -Tổng số ký tự là chữ số trong xâu là: " + xkt.demKyTuChuSo());
		//xau truoc khi chuan hoa
		System.out.print("\n\t -Xâu trước khi chuẩn hóa là: " + xkt.getXau());
		//xau sau khi chuan hoa
		xkt.chuanHoaXau();
		System.out.print("\n\t -Xâu sau khi chuẩn hóa là: " + xkt.getXau());
	}

}





























