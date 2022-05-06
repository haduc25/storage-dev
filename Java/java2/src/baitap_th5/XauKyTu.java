package baitap_th5;

import java.util.*;
import java.io.*;

public class XauKyTu {
	private String st;

	public XauKyTu() {
	}

	public XauKyTu(String s) {
		st = s;
	}

	// nhap
	public void nhapXau() {
		Scanner sc = new Scanner(System.in);

		System.out.print("Nhập vào xâu ký tự: ");
		st = sc.nextLine();
	}

	// get Xau ky tu
	public String getXau() {
		return st;
	}

	// dem ky tu dac biet
	public int demKyTuDacBiet() {
		int dem_sChar = 0;
		for (int i = 0; i < st.length(); i++) {
			if (!(st.charAt(i) >= 'a' && st.charAt(i) <= 'z' || st.charAt(i) >= 'A' && st.charAt(i) <= 'Z' || st.charAt(i) >= '0' && st.charAt(i) <= '9')) {
				dem_sChar++;
			}
		}
		return dem_sChar;

	}

	//demTuBatDauBoiKyTuT
	public int demTuBatDauBoiKyTuT() 
	{
		int dem = 0;
		if(st.charAt(0) == 't')
			dem++;
		for (int i = 0; i < st.length()-1; i++) 
		{
			if (st.charAt(i+1) == 't' && st.charAt(i) == ' ')
				dem++;
		}
		return dem;
	}
	
	//chuan hoa xau
	public void chuanHoaXau() {
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
	
	//main
	public static void main(String[] args) {
		XauKyTu xkt = new XauKyTu();
		xkt.nhapXau();
		System.out.println("==> Xâu vừa nhập là: " + xkt.getXau());
		System.out.println(" />Tổng số ký tự đặc biệt trong xâu là: " + xkt.demKyTuDacBiet());
		System.out.println(" />Số từ trong xâu bắt đầu bởi ký tư 't' là: " + xkt.demTuBatDauBoiKyTuT());
		//xau truoc khi chuan hoa
		System.out.println(" />Xâu trước khi chuẩn hóa là: " + xkt.getXau());
		//xau sau khi chuan hoa
		xkt.chuanHoaXau();
		System.out.println(" />Xâu sau khi chuẩn hóa là: " + xkt.getXau());
	}

}
