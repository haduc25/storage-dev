#include <iostream>
#include <cstring>

using namespace std;

class N
{
	private:
		string scmt,ht,qq;
		int ns;
		int nam_ht=2020;
	public:
		N()
		{
			scmt="";
			ht="";
			qq="";
		}
		N(string scmt1, string ht1, string qq1, int ns1)
		{
			scmt=scmt1;
			ht=ht1;
			qq=qq1;
			ns=ns1;
		}
		//set&get
		void set_scmt(string scmt1)
		{
			scmt=scmt1;
		}
		string get_scmt(){return scmt;}
		void set_ht(string ht1)
		{
			ht=ht1;
		}
		string get_ht(){return ht;}
		void set_qq(string qq1)
		{
			qq=qq1;
		}
		string get_qq(){return qq;}
		void set_ns(int ns1)
		{
			ns=ns1;
		}
		int get_ns(){return ns;}
		
		void nhap()
		{
			fflush(stdin);
			cout<<"\nSCMT: ";
			getline(cin,scmt);
			fflush(stdin);
			cout<<"Ho Ten: ";
			getline(cin,ht);
			fflush(stdin);
			cout<<"Que Quan: ";
			getline(cin,qq);
			fflush(stdin);
			cout<<"Nam Sinh: ";
			cin>>ns;
			fflush(stdin);
		}
		void xuat()
		{
			cout<<scmt<<", "<<ht<<", "<<qq<<", "<<ns<<"Tuoi: "<<tuoi()<<endl;
		}
		int tuoi()
		{
			return nam_ht - ns;
		}
		
		friend void swap(N ng[], int n)
		 {			 	
			int i,j;
			for(i=0;i<n-1;i++)
				{
				for(j=i+1;j<n;j++)
					{
					if(strcmp(ng[i].ht.c_str(),ng[j].ht.c_str())>0)
						{
							N temp;
							temp=ng[i];
							ng[i]=ng[j];
							ng[j]=temp;
						}
					}
				}
		 }
		 
};

class SV : public N
{
	private:
		string masv,nganh;
	public:
		SV()
		{
			masv="";
			nganh="";
		}
		SV(string scmt1, string ht1, string qq1, int ns1, string masv1, string nganh1):N(scmt1,ht1,qq1,ns1)
		{
			masv=masv1;
			nganh=nganh1;
		}
		void nhap1()
		{
			N::nhap();
			fflush(stdin);
			cout<<"Ma SV: ";
			getline(cin,masv);
			fflush(stdin);
			cout<<"Nganh: ";
			getline(cin,nganh);
			fflush(stdin);
		}
		void xuat1()
		{
			N::xuat();
			cout<<", "<<masv<<", "<<nganh<<endl;
		}
};

class QLSV
{
		private:
			int i,j,n;
			SV sv[100];
		public:
			void nhapds()
			{
				cout<<"Nhap so sv: ";
				cin>>n;
				for(i=0;i<n;i++)
				{
					cout<<"SV ["<<i+1<<"]"<<endl;
					sv[i].nhap1();
				}
			}
			void xuatds()
			{
				for(i=0;i<n;i++)
				{
					cout<<"SV ["<<i+1<<"]"<<endl;
					sv[i].xuat1();
				}
			}

};


int main()
{
	/*
	QLSV ql;
	ql.nhapds();
	ql.xuatds();
	*/
	//test
	N ng[100];
	int n,i;
	cout<<"Nhap n: ";
 	cin>>n;
	for(i=0;i<n;i++)
	{
		
		ng[i].nhap();
	}
	for(i=0;i<n;i++)
	{
		ng[i].xuat();
	}
	cout<<"\nSort successfully !"<<endl;
	swap(ng,n);
	for(i=0;i<n;i++)
	{
		ng[i].xuat();
	}
}
