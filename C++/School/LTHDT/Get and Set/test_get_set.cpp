#include <iostream>
#include <cstring>

using namespace std;

class PERSON
{
	private:
		string so_cmt, ho_ten, que_quan;
		int nam_sinh, nam_ht=2020;
	public:
		PERSON()
		{
			so_cmt="";
			ho_ten="";
			que_quan="";
		}
		PERSON(string so_cmt1, string ho_ten1, string que_quan1, int nam_sinh1)
		{
			so_cmt=so_cmt1;
			ho_ten=ho_ten1;
			que_quan=que_quan1;
		}
		
		//set so_cmt
		void set_socmt(string cmt)
		{
			so_cmt=cmt;
		}
		//get so_cmt
		string get_socmt(){ return so_cmt;}
		//set ho_ten
		void set_hoten(string hoten)
		{
			ho_ten=hoten;
		}
		//get ho_ten
		string get_hoten(){ return ho_ten;}
		//set que_quan
		void set_quequan(string qq)
		{
			que_quan=qq;
		}
		//get que_quan
		string get_quequan(){ return que_quan;}
		//set nam_sinh
		void set_namsinh(int ns)
		{
			nam_sinh=ns;
		}
		//get nam_sinh
		int get_namsinh(){return nam_sinh;}
		
		//nhap
		void nhap()
		{
			set_hoten("Ha Minh Duc");
			set_socmt("0123456789");
			set_quequan("Bac Kan");
			set_namsinh(2001);
		}
		//xuat
		void xuat()
		{
			cout<<"|=========>Result<=========|"<<endl;
			cout<<"-"<<get_hoten()<<endl;
			cout<<"-"<<get_socmt()<<endl;
			cout<<"-"<<get_quequan()<<endl;
			cout<<"-"<<get_namsinh()<<endl;
			cout<<"|=========>The End<=========|";
		}
		//tinh tuoi
		int age()
		{
			return nam_ht-get_namsinh();
		}
}; 

class SINH_VIEN : public PERSON
{
	private:
		
	public:
		SINH_VIEN()
		{
			
		}
		SINH_VIEN()
		{
			
		}
};

int main()
{
	PERSON per;
	per.nhap();
	per.xuat();
	cout<<"\nAge: "<<per.age();
}
