#include <stdio.h>
#include <iostream>
#include <fstream>

using namespace std;
 
 int  i,j,n;
 
 struct infoHang
 {
 char matHang[10];
 char tenHang[10];
 char Ton[5];
 int Sl,Price,TimeBH;
 };
 infoHang *p;
 int  main()
 {
 	cout<<"So doi bong: ";
 	cin>>n;
 	cin.get();
 	p = new infoHang[n];
	 for(i=0;i<n;i++)
	 {
	 	 	cout<<"Nhap thong tin mat hang "<<i<<endl;
	 	 	cout<<"Mat hang: ";
	 	 	cin.get();
	 	 	cin.getline((p+i)->matHang,10);
	 	 	cout<<"\nTen mat hang: ";
	 	 	cin.getline((p+i)->tenHang,10);
	 	 	cout<<"\nTon is: ";
	 	 	cin.getline((p+i)->Ton,5);
	 	 	cout<<"\nSo luong hang: ";
	 	 	cin>>(p+i)->Sl;
	 	 	cout<<"\nGia mat hang: ";
	 	 	cin>>(p+i)->Price;
	 	 	cout<<"\nThoi gian BH: ";
	 	 	cin>>(p+i)->TimeBH;
	 	 	cin.get();
	 }
 }
 /*
 Kiem tra mo file
 odstream ofs("d:\\hello.txt",ios::out)
 if(!f)
 {cout<<"Khong mo duoc file"};
 else{ofs>>p[vt].mah<<','<<p[vt].tenh<<','<<p[vt].dg<<' '<<p[vt].ton<<endl;}
 ofs.close();
 */
