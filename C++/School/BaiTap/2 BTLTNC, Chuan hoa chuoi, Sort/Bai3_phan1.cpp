#include <stdio.h>
#include <iostream>
#include <fstream>
#include <iomanip>
#include <string.h>
using namespace std;

struct Video{
	char Tenp[20];
	char loai[10];
	char ddien[20];
	char namc[20];
	char nuc[20];
	char hang[20];
	int nam;
};
Video *p;
int i,n;
char theloai[10];

Video *nhap()
{
	Video *x=new Video[1];
	cout<<"Ten phim:"; cin.getline(x->Tenp, 20);	
	cout<<"The loai:"; cin.getline(x->loai,20);
	cout<<"Dao dien:"; cin.getline(x->ddien,20);
	cout<<"Nam chinh:"; cin.getline(x->namc,20);
	cout<<"Nu chinh:"; cin.getline(x->nuc,20);
	cout<<"Nam san xuat:"; cin>>x->nam; cin.get();
	cout<<"Hang san xuat:"; cin.getline(x->hang,20);
	return x;
}

void in_phim(Video &x)
{
	cout<<setw(20)<<x.Tenp<<setw(20)<<x.loai<<setw(20)<<x.ddien<<setw(20)<<x.namc;
	cout<<setw(20)<<x.nuc<<setw(6)<<x.nam<<setw(20)<<x.hang<<endl;
}


int main()
{
	cout<<"Nhap so luong bo phim:"; cin>>n; cin.get();
	p=new Video[n];
	ofstream f("d:\\video.txt", ios::out);
	f<<"Danh sach cac bo phim:"<<endl;
	for (i=1; i<=n; i++)
	{
		p[i]=*nhap();
		f<<p[i].Tenp<<','<<p[i].loai<<','<<p[i].ddien<<','<<p[i].namc<<','<<p[i].nuc<<','<<p[i].nam<<','<<p[i].hang<<endl;
	}
	
	cout<<"Nhap loai phim can tim:"; cin.getline(theloai,10);
	int kt=0;
	for (i=1; i<=n; i++)
	{
		if (strcmp(p[i].loai, theloai)==0) 
		{
			in_phim(*(p+i));
			kt=1;
		}
	}
	if (kt==0) cout<<"Khong co loai phim ban can tim !"<<endl;
	f.close();
}
