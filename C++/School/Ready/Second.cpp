#include <iostream>
#include <cstring>

using namespace std;

class Per
{
	private:
		string cmt,ht,qq;
		int ns;
	public:
		Per()
		{
			cmt="";
			ht="";
			qq="";
		}
		Per(string cmt1,string ht1, string qq1, int ns1)
		{
			cmt=cmt1;
			ht=ht1;
			qq=qq1;
			ns=ns1;
		}
		void set_cmt(string cmt1)
		{
			cmt=cmt1;
		}
		string get_cmt()
		{
			return cmt;
		}
		void set_ht(string ht1)
		{
			ht=ht1;
		}
		string get_ht()
		{
			return ht;
		}
		void set_qq(string qq1)
		{
			qq=qq1;
		}
		string get_qq()
		{
			return qq;
		}
		void set_ns(int ns1)
		{
			ns=ns1;
		}
		int get_ns()
		{
			return ns;
		}
		void nhap()
		{
			fflush(stdin);
			cout<<"Ho Ten: ";
			getline(cin,ht);
			fflush(stdin);
			cout<<"Nam Sinh: ";
			cin>>ns;
			fflush(stdin);
		}
		void xuat()
		{
			cout<<ht<<", "<<ns<<", ";
		}
};

class SV : public Per
{
	private:
		string msv,nganh;
	public:
		SV()
		{
			msv="";
			nganh="";
		}
		SV(string cmt1,string ht1, string qq1, int ns1, string msv1, string nganh1):Per(cmt1,ht1,qq1,ns1)
		{
			msv=msv1;
			nganh=nganh1;
		}
		void nhap_()
		{
			Per::nhap();
			fflush(stdin);
			cout<<"Ma SV: ";
			getline(cin,msv);
			fflush(stdin);
		}
		void xuat_()
		{
			Per::xuat();
			cout<<msv<<endl;
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
			cout<<"So sv: ";
			cin>>n;
			for(i=0;i<n;i++)
			{
				cout<<"SV ["<<i+1<<"]\n";
				sv[i].nhap_();
			}
		}
		void xuatds()
		{
			for(i=0;i<n;i++)
			{
				cout<<"SV ["<<i+1<<"]\n";
				sv[i].xuat_();
			}
		}
		
};

int main()
{
	QLSV ql;
	ql.nhapds();
	ql.xuatds();
}
