#include <iostream>
#include <cstring>

using namespace std;

class NGUOI
{
	private:
		string so_cmt,ho_ten,que_quan;
		int nam;
	public:
		NGUOI();
		NGUOI(string, string, string, int);
		void nhap();
		void xuat();
		int age(int);
};
class SINH_VIEN:public NGUOI
{
	private:
		string ma_sv;
		string nganh_hoc;
	public:
		SINH_VIEN();//1
		SINH_VIEN(string,string,string,int,string,string);
		void nhap_ds();
		void xuat_ds();
};

SINH_VIEN::SINH_VIEN() //1
{
	ma_sv="";
	nganh_hoc="";
}

SINH_VIEN::SINH_VIEN(string so_cmt1, string ho_ten1, string que_quan1,int nam1, string ma_sv1,string nganh_hoc1):NGUOI(so_cmt1,ho_ten1,que_quan1,nam1)
{
	ma_sv=ma_sv1;
	nganh_hoc=nganh_hoc1;
}

NGUOI::NGUOI()
{
	so_cmt = "";
	ho_ten = "";
	que_quan = "";
}

NGUOI::NGUOI(string so_cmt1, string ho_ten1, string que_quan1, int nam1)
{
	so_cmt=so_cmt1;
	ho_ten=ho_ten1;
	que_quan=que_quan1;
	nam=nam1;
}
void SINH_VIEN::nhap_ds()
{
	NGUOI::nhap();
	fflush(stdin);
	cout<<"Nhap Ma SV: ";
	getline(cin,ma_sv);
	fflush(stdin);
	cout<<"Nhap Nganh Hoc: ";
	getline(cin,nganh_hoc);
	fflush(stdin);
}
void SINH_VIEN::xuat_ds()
{
	NGUOI::xuat();
	cout<<ma_sv<<","<<nganh_hoc<<endl;	
}

void NGUOI::nhap()
{
	fflush(stdin);
	cout<<"So CMT: ";
	getline(cin,so_cmt);
	fflush(stdin);
	cout<<"Ho Ten: ";
	getline(cin,ho_ten);
	fflush(stdin);
	cout<<"Que Quan: ";
	getline(cin,que_quan);
	fflush(stdin);
	cout<<"Nam Sinh: ";
	cin>>nam;
	fflush(stdin);
}
void NGUOI::xuat()
{
	cout<<so_cmt<<","<<ho_ten<<","<<que_quan<<",";
}
int NGUOI::age(int nam_hien_tai)
{
	return nam_hien_tai - nam;
}
int main()
{
/*
	NGUOI n = NGUOI("123","NGUYEN VAN A","BAC KAN",2001);
	n.nhap();
	n.xuat();
	cout<<n.age(2020)<<endl;
*/
	SINH_VIEN sv;
	sv.nhap_ds();
	sv.xuat_ds();
}
