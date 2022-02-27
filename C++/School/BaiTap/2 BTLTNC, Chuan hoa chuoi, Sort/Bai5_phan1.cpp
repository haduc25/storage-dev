#include <stdio.h>
#include <iostream>
#include <fstream>
#include <iomanip>
using namespace std;
struct Hocsinh{
	char ma[5];
	char hoten[20];
	char diachi[20];
	char phai[4];
	int ngay, thang, nam;
	float dtb;
};

Hocsinh *p;
FILE *f;
int i,n;

Hocsinh *nhap()
{
	Hocsinh *x=new Hocsinh[1];
	cout<<"Ma hoc sinh:"; cin.getline(x->ma,5);
	cout<<"Ho ten: "; cin.getline(x->hoten,20);
	cout<<"Dia chi: "; cin.getline(x->diachi,20);
	cout<<"Gioi tinh: "; cin.getline(x->phai,4);
	cout<<"Ngay thang nam sinh:"; cin>>x->ngay>>x->thang>>x->nam;
	cout<<"Diem trung binh:"; scanf("%f",&x->dtb); 
	cin.get();
	return x;
}

void ghifile(Hocsinh &x, char *fname)
{
	ofstream f(fname, ios::app);
	f<<x.ma<<','<<x.hoten<<','<<x.diachi<<','<<x.phai<<','<<x.ngay<<' '<<x.thang<<' '<<x.nam<<' '<<x.dtb<<endl;
	f.close();
}

void in_ds(Hocsinh &x)
{
	cout<<setw(5)<<x.ma<<setw(20)<<x.hoten<<setw(20)<<x.diachi<<"  "<<x.ngay<<"/"<<x.thang<<"/"<<x.nam<<setw(5)<<x.phai<<setw(5)<<x.dtb<<endl;
}

int main()
{
	cout<<"Nhap so hoc sinh:"; cin>>n; cin.get();
	p=new Hocsinh[n];
	for (i=1; i<=n; i++)
	{
		cout<<"Nhap thong tin hoc sinh thu "<<i<<":"<<endl;
		p[i]=*nhap();
		ghifile(*(p+i),"c:\\data\\hocsinh1.txt");
	}
	float max_tb=0; int vt=0;
	ifstream f("c:\\data\\hocsinh1.txt", ios::in);
	
	for (i=1; i<=n; i++)
		{
			f.getline((p+i)->ma,5,',');
			f.getline((p+i)->hoten,20,',');
			f.getline((p+i)->diachi,20,',');
			f.getline((p+i)->phai,4,',');
			f>>(p+i)->ngay>>(p+i)->thang>>(p+i)->nam>>(p+i)->dtb;
			f.get();		
			in_ds(*(p+i));
			if (p[i].dtb>max_tb)
				{
					max_tb=p[i].dtb;
					vt=i;
				}			
		}
	cout<<"Hoc sinh co diem trung binh cao nhat la:"<<max_tb<<endl;
	in_ds(*(p+vt));
	f.close();
}

