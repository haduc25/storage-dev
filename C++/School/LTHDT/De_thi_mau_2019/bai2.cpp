#include <iostream>
#include <cstring>

using namespace std;
//1
class Person
{
	private:
		string scmt,ho_ten,que_quan;
		int nam_sinh;
	public:
		Person();
		Person(string, string, string, int);
		void Nhap();
		void Xuat();
};
//xu ly => class
Person::Person()
{
	scmt="";
	ho_ten="";
	que_quan="";
}
Person::Person(string scmt1, string ho_ten1, string que_quan1, int nam_sinh1)
{
	scmt=scmt1;
	ho_ten=ho_ten1;
	que_quan=que_quan1;
	nam_sinh=nam_sinh1;
}
void Person::Nhap()
{
	fflush(stdin);
	cout<<"So cmt: ";
	getline(cin,scmt);
	fflush(stdin);
	cout<<"Ho ten: ";
	getline(cin,ho_ten);
	fflush(stdin);
	cout<<"Que quan: ";
	getline(cin,que_quan);
	fflush(stdin);
	cout<<"Nam sinh: ";
	cin>>nam_sinh;
	fflush(stdin);
}
void Person::Xuat()
{
	cout<<scmt<<", "<<ho_ten<<", "<<que_quan<<", "<<nam_sinh<<", ";
}
//2
class Sinh_Vien:public Person
{
	private:
		string ma_sv,nganh_hoc;
	public:
		Sinh_Vien();
		Sinh_Vien(string, string, string, int, string, string);
		void Nhap_ds();
		void Xuat_ds();
};
//xu ly => class
Sinh_Vien::Sinh_Vien()
{
	ma_sv="";
	nganh_hoc="";
}
Sinh_Vien::Sinh_Vien(string scmt1, string ho_ten1, string que_quan1, int nam_sinh1, string ma_sv1, string nganh_hoc1):Person(scmt1, ho_ten1, que_quan1, nam_sinh1)
{
	ma_sv=ma_sv1;
	nganh_hoc=nganh_hoc1;	
}
void Sinh_Vien::Nhap_ds()
{
	Person::Nhap();
	fflush(stdin);
	cout<<"Ma SV: ";
	getline(cin,ma_sv);
	fflush(stdin);
	cout<<"Nganh Hoc: ";
	getline(cin,nganh_hoc);
	fflush(stdin);
}
void Sinh_Vien::Xuat_ds()
{
	Person::Xuat();
	cout<<ma_sv<<", "<<nganh_hoc<<endl;
}
int main()
{
	///=>75%
	//2
	Sinh_Vien sv;
	sv.Nhap_ds();
	sv.Xuat_ds();
	//1
	/*
	Person ps;
	ps.Nhap();
	ps.Xuat();
	*/
}
