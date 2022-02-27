#include <iostream>
#include <conio.h>

using namespace std;

class thisinh
{
	private:
		char sbd[25];
		float dtoan,dly,dhoa;
	public:
		void nhap()
		{	
			cout<<"Nhap vao so bao danh :";
			cin>>sbd;
			cout<<"Nhap diem toan :";
			cin>>dtoan;
			cout<<"Nhap diem ly:";
			cin>>dly;
			cout<<"Nhap diem hoa:";
			cin>>dhoa;
		}
		
		void in()
		{
			cout<<"\nSo bao danh "<<sbd<<endl;
			cout<<"\tDiem toan:"<<dtoan<<" Diem ly:"<<dly<<" Diem hoa:"<<dhoa;
			cout<<" => Tong diem: "<<tdiem()<<endl;
		}
		float tdiem(){	return(dtoan+dly+dhoa);	}
};


class dsts
{
	private:
		int n;
		thisinh dsts[100];
	public:
		void nhapds()
		{
			cout<<"Nhap vao so luong thi sinh:";
			cin>>n;
			for(int i=0;i<n;i++)
			dsts[i].nhap();	
		}
		void inds()
		{
			for(int i=0;i<n;i++)
			dsts[i].in();
		}
		void sapxep()
		{
			for(int i=0;i<n-1;i++)
			for(int j=i+1;j<n;j++)
			if(dsts[i].tdiem()>dsts[j].tdiem())
			{
				thisinh temp;
				temp= dsts[i];
				dsts[i]=dsts[j];
				dsts[j]=temp;
			}
		}
		void tdtren18()
		{
			for(int i=0;i<n;i++)
			if(dsts[i].tdiem()>18)
			dsts[i].in();
		}
};

int main()
{
	dsts ds;
	ds.nhapds();
	cout<<"\n1.Sap xep danh sach cac thi sinh theo thu tu tang dan ve tong diem:"<<endl;
	ds.sapxep();
	ds.inds();
	cout<<"\n2.Danh sach cac thi sinh co tong diem tren 18 la:"<<endl;
	ds.tdtren18();
	getch();
}
