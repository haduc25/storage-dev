//con tro "this"
#include <iostream>
#include <cmath>
#include <cstring>

using namespace std;

class da_giac
{
	protected:
		int n,i;
		int a[];
	public:
		da_giac(){};
		da_giac(int so_canh, int a[])
		{
			this->n=so_canh;
			for(i=0;i<n;i++)
			{
				this->a[i]=a[i];
			}
		}
};

class tam_giac:public da_giac
{
	public:
		tam_giac()
		{
			this->n=3;
			da_giac *a = new da_giac[n];
		}
		nhap()
		{
			for(i=0;i<3;i++)
			{
				cout<<"Nhap canh ["<<i+1<<"]=";
				cin>>this->a[i];
			}
		}
		bool kt()
		{
			if(a[0]<a[1]+a[2] && a[1]<a[2]+a[0] && a[2]<a[0]+a[1])
			{
				return 0;
			}else
			{
				return 1;
			}
		}
		xuat()
		{
			for(i=0;i<this->n;i++)
			{
				cout<<"Canh thu ["<<i+1<<"]=";
				cout<<a[i]<<endl;
			}
		}
		float tinh_dien_tich()
		{
			float chu_vi,dien_tich;
			for(i=0;i<this->n;i++)
			{
				chu_vi+=a[i];
			}
				dien_tich=sqrt(chu_vi/2*(chu_vi/2-this->a[0])*(chu_vi/2-this->a[1])*(chu_vi/2-this->a[2]));
				return dien_tich;
		}
	//	tam_giac(int , int , int)
};

class quan_ly
{
		private:
			int sl,i;
			float kq,max=0;
		public:
			void nhap_ds()
			{
				cout<<"Nhap so luong tam giac: ";
				cin>>sl;
				for(i=0;i<sl;i++)
				{
					cout<<"Nhap canh tam giac thu ["<<i+1<<"]"<<endl;
					tam_giac *tg = new tam_giac();
					do
					{
						tg->nhap();
					}while(tg->kt()==true);
					cout<<"Dien tich tam giac: "<<tg->tinh_dien_tich()<<endl;
					float kq=tg->tinh_dien_tich();
					if(max<kq)
					{
						max=kq;
					}
					tg->xuat();
					cout<<endl;
				}
				cout<<"Max= "<<max;
			}
};

int main()
{
	quan_ly ql;
	ql.nhap_ds();
}
