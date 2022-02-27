/*
//static
static <kieu dl> tenham
//ham tao
+ten cua ham tao = tenlop
+ham tao k co g.tri tra ve
+ham khoi tao co t.chat public
+co nhieu ham tao trong 1 lop
+----------------giong nhau nhung != tham so
Ex:
SINH_VIEN() //1
SINH_VIEN(string,int,string); //2
main()
{
	SINH_VIEN() // goi ham 1
	SINH_VIEN(ho-ten,tuoi,dia chi) // goi ham 2
}
*/
#include <iostream>
#include <cstring>

using namespace std;


class SINH_VIEN
{
	friend void Sort(SINH_VIEN[], int);
	private:
		int ma_sv,dtb;
		char ho_ten[25];
		static int count;
	public:
		void nhap();
		void xuat();
		static int tang_count(){count++;}
};
int SINH_VIEN::count=1; //tao gia ti cho count = 0
void SINH_VIEN::nhap()
{
	ma_sv=count;
	tang_count();
	//count++;
	/*
	fflush(stdin);
	cout<<"Ma SV";
	cin>>ma_sv;
	*/
	fflush(stdin);
	cout<<"Ho Ten: ";
	cin.getline(ho_ten,25);
	fflush(stdin);
	cout<<"Diem TB: ";
	cin>>dtb;
	fflush(stdin);
}
void SINH_VIEN::xuat()
{
	cout<<"Ma SV: "<<ma_sv<<endl;
	cout<<"Ho Ten: "<<ho_ten<<endl;
	cout<<"Diem TB: "<<dtb<<endl;
	cout<<endl;
}

void Sort(SINH_VIEN sv[], int n)
{
 	SINH_VIEN temp;
 	int i,j;
 	for(i=0;i<n-1;i++)
	 {
	 	for(j=i+1;j<n;j++)
		 {
		 	if(sv[i].dtb>sv[j].dtb)
			 {
			 	temp=sv[i];
			 	sv[i]=sv[j];
			 	sv[j]=temp;
			 }
		 }
	 }
}
int main()
{
	//fix
	int n,i;
	SINH_VIEN sv[100];
	cout<<"Nhap n: ";
 	cin>>n;
	for(i=0;i<n;i++)
	{
		sv[i].nhap();
	}
	for(i=0;i<n;i++)
	{
		sv[i].xuat();
	}
	
	cout<<"";	
}
