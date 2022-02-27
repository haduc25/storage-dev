#include <iostream>
#include <cstring>

using namespace std;

class NGUOI
{
	private:
		string cmt,ho_ten,que_quan;
		int nam;
		int nam_ht=2020;
	public:
		NGUOI();
		NGUOI(string _socmnd, string _hoTen, string _queQuan, int _namSinh)
		void nhap()
		{
			fflush(stdin);
			cout<<"Nhap ho ten: ";
			getline(cin,ho_ten);
			fflush(stdin);
			cout<<"Nhap so cmt: ";
			getline(cin,cmt);
			fflush(stdin);
			cout<<"Nhap que quan: ";
			getline(cin,que_quan);
			fflush(stdin);
			cout<<"Nhap nam: ";
			cin>>nam;
			fflush(stdin);
		}
		void xuat()
		{
			cout<<"Ho ten: "<<ho_ten<<endl;
			cout<<"So cmt: "<<cmt<<endl;
			cout<<"Que quan: "<<que_quan<<endl;
			cout<<"Nam: "<<nam<<endl;	
		}
		int tinh_Tuoi()
		{
			return nam_ht-nam;	
		}
};

int main()
{
	NGUOI ng;
	ng.nhap();
	ng.xuat();
	cout<<"Tuoi: "<<ng.tinh_Tuoi();
} 
