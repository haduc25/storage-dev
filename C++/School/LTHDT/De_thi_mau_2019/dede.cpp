#include <iostream>

using namespace std;


class Sach
{
	private:
		string ten_sach,ten_tac_gia;
		int nam_xb;
	public:
		Sach();
		Sach(string ten_sach,string ten_tac_gia,int nam_xb);
		void nhap()
		{
			fflush(stdin);
			cout<<"Nhap ten sach: ";
			getline(cin,ten_sach);
			fflush(stdin);
			cout<<"Nhap ten tac gia: ";
			getline(cin,ten_tac_gia);
			fflush(stdin);
			cout<<"Nam xb: ";
			cin>>nam_xb;
			fflush(stdin);
		}
		void xuat()
		{
			cout<<ten_sach<<", "<<ten_tac_gia<<", "<<nam_xb<<endl;
		}
};

//ke thua tu class Sach
class GiaoTrinh : public Sach
{
	private:
		string linh_vuc;
		int gia;
	public:
		GiaoTrinh()
		{
		}
		GiaoTrinh(string ten_sach, string ten_tac_gia, )
		{
			
		}
};

int main()
{
	
}
























