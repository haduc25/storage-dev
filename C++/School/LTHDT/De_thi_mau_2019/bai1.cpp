#include <iostream>
#include <cstring>

using namespace std;

class Nguoi
{
	private:
		string scmt;
		string ho_ten;
		string que_quan;
		int nam_sinh;
		int nam_ht=2020; //1
	public:	
		Nguoi()
		{
			scmt="";
			ho_ten="";
			que_quan="";
		}
		Nguoi(string, string, string, int);
 		void Nhap()
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
 		void Xuat()
		 {
		 	cout<<scmt<<", "<<ho_ten<<", "<<que_quan<<", "<<nam_sinh<<", "<<tuoi()<<", ";
		 }
		 /*
		 void sap_xep(string &ten1, string &ten2)
		 {
        	string temp;
        	temp=ten1;
        	ten1=ten2;
        	ten2=temp;
        	/*
            strcpy(temp,ten1);
            strcpy(ten1,ten2);
            strcpy(ten2,temp);
            */
		 }
		 */
 		//int tuoi(int); //2
 		int tuoi(){return nam_ht-nam_sinh;} //1
};
Nguoi::Nguoi(string scmt1, string ho_ten1, string que_quan1, int nam_sinh1)
{
	scmt=scmt1;
	ho_ten=ho_ten1;
	que_quan=que_quan1;
	nam_sinh=nam_sinh1;
}
/* //2
int Nguoi::tuoi(int nam_ht)
{
	return nam_ht-nam_sinh;
}
*/

//class Sinh_Vienke thua lop nguoi
class Sinh_Vien : public Nguoi
{
	//them thuoc tinh
	private:
		string ma_sv;
		string nganh_hoc;
	public:
		Sinh_Vien()
		{
			ma_sv="";
			nganh_hoc="";
		}
		Sinh_Vien(string, string, string, int, string, string);
		void Nhap_ds()
		{
			//ke thua tu nguoi
			Nguoi::Nhap();
			fflush(stdin);
			cout<<"Ma SV: ";
			getline(cin,ma_sv);
			fflush(stdin);
			cout<<"Nganh Hoc: ";
			getline(cin,nganh_hoc);
			fflush(stdin);
		}
		void Xuat_ds()
		{
			//ke thua tu nguoi
			Nguoi::Xuat();
			cout<<ma_sv<<", "<<nganh_hoc<<endl;
		}
};
Sinh_Vien::Sinh_Vien(string scmt1, string ho_ten1, string que_quan1, int nam_sinh1, string ma_sv1, string nganh_hoc1):Nguoi(scmt1,ho_ten1,que_quan1,nam_sinh1)//ke thua tu nguoi
{
	ma_sv=ma_sv1;
	nganh_hoc=nganh_hoc1;
}
//class quan ly sv
class QLSV
{
	private:
		Sinh_Vien sv[100];
		int i,j,n;
	public:
		//QLSV(); //int ssv
		//QLSV(); //
		void Nhap_dssv()
		{
			cout<<"Thong tin sinh vien"<<endl;
			cout<<"So luong sinh vien: ";			
			cin>>n;
			for(i=0;i<n;i++)
			{
				cout<<"\nSV thu ["<<i+1<<"]"<<endl;
				sv[i].Nhap_ds();
			}
		}
		void Xuat_dssv()
		{
			for(i=0;i<n;i++)
			{
				cout<<"\nSV thu ["<<i+1<<"]"<<endl;
				sv[i].Xuat_ds();
			}
		}
		void sapxep()
		{
			for (int i = 0; i < n - 1; i++)
        		for (int j = i + 1; j < n; j++)
			if(strcmp(sv[i].ho_ten,sv[j].ho_ten)>0)
			{
				sap_xep(sv[i],sv[j]);
			}
		}

};
int main()
{
	//cau3
	//=>80%
	QLSV ql;
	ql.Nhap_dssv();
	ql.Xuat_dssv();
	cout<<"SX\n";
	ql.sapxep();
	ql.Xuat_dssv();
	/*
	//cau2
	Sinh_Vien sv;
	sv.Nhap_ds();
	sv.Xuat_ds();
	*/
	/*
	//cau1
	Nguoi ng;
	ng.Nhap();
	ng.Xuat();
	*/
	//cout<<"Tuoi: "<<ng.tuoi()<<endl; //1
	//cout<<ng.tuoi(2020)<<endl; //2
}
