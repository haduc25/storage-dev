#include <iostream>
#include <fstream>
#include <iomanip>
#include <cstdio>

using namespace std;

struct Bangxephang
{
	char tenDB[20];
	int thang,thua,hoa,point1,point2,point3;
	int total = 0;
};
Bangxephang *p;
int won = 3;
int drew = 1;
int lost = 0;

/*void sort(Bangxephang &a, Bangxephang &b)
{
   Bangxephang temp;
   temp = a;
   a = b;
   b = temp;
}*/
int i,j,n;
int main()
{
	//Nhap danh sach
	cout<<"Danh sach doi bong: ";
	cin>>n;
	cin.get();
	p = new Bangxephang[n];
	//Nhap thong cua doi bong
	for(i=0;i<n;i++)
	{
		cout<<"THONG TIN CUA DOI BONG THU: "<<i+1<<endl;
        cout<<"ten doi bong: ";
        cin.getline(p[i].tenDB,20);
        cout<<"So tran Thang: ";
        cin>>p[i].thang;
        p[i].point1 = won*p[i].thang;
        cout<<"So tran Thua: ";
        cin>>p[i].thua;
        p[i].point2 = lost*p[i].thua;
		cout<<"So tran Hoa: ";
		cin>>p[i].hoa;
		p[i].point3 = drew*p[i].hoa;
		cin.get();
		p[i].total = p[i].point1+p[i].point2+p[i].point3;
		cout<<endl;
	}
	/*
	//Xuat
	for(i=0;i<n;i++)
	{
		cout<<"\n(BEFORE SORT) THONG TIN VUA NHAP DOI BONG THU:"<<i+1<<endl;
		cout<<"Ten: "<<p[i].tenDB,20;
		cout<<"\nThang: "<<p[i].thang;
		cout<<"\nThua: "<<p[i].thua;
		cout<<"\nHoa: "<<p[i].hoa;
		
		cout<<"\nVALUE IS WON: "<<p[i].point1<<endl;
		cout<<"\nVALUE IS LOST: "<<p[i].point2<<endl;
		cout<<"\nVALUE IS DREW: "<<p[i].point3<<endl;
		cout<<"\nTOTAL OF BATTLE FOOTBALL IS: "<<p[i].total;
	}
	*/
	//Sort
	for(i=0;i<n-1;i++)
	{
		for(j=i+1;j<n;j++)
		{
		//cach 1
		/* if(p[i].total < p[j].total)
		 {
		 	sort(p[i],p[j]);
		 }
		 */
	     
		  if(p[i].total < p[j].total)
		  {
		  	Bangxephang temp;
		  	temp = p[i];
		  	p[i] = p[j];		 
			p[j] = temp;		  
		  }
		  
		}
	}
	/*
	for(i=0;i<n;i++)
	{
		cout<<"\n(AFTER SORT) THONG TIN VUA NHAP DOI BONG THU:"<<i+1<<endl;
		cout<<"Ten: "<<p[i].tenDB,20;
		cout<<"\nThang: "<<p[i].thang;
		cout<<"\nThua: "<<p[i].thua;
		cout<<"\nHoa: "<<p[i].hoa;
		cout<<"\nTOTAL OF BATTLE FOOTBALL IS: "<<p[i].total;
	}
	*/
	ofstream ofs;
	ofs.open("C:\\Users\\Admin\\Desktop\\danhsach.txt",ios::out);
	if(!ofs)
	{
		cout<<"da xay ra loi voi file [001]";
	}
	else
	{
	cout<<"\nSuccessfully !";
	ofs<<"DAY LA FILE XUAT RA SAU KHI SAP XEP: ";
	for(i=0;i<n;i++)
	{
		ofs<<"\nTHONG TIN VUA NHAP DOI BONG THU:"<<i+1<<endl;
		ofs<<"Ten: "<<p[i].tenDB,20;
		ofs<<"\nThang: "<<p[i].thang;
		ofs<<"\nThua: "<<p[i].thua;
		ofs<<"\nHoa: "<<p[i].hoa;
		ofs<<"\nTOTAL OF BATTLE FOOTBALL IS: "<<p[i].total;
	}
	}
	ofs.close();
}
