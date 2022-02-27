#include <stdio.h>
#include <iostream>
#include <iomanip>
#include <fstream>

using namespace std;

struct Thongtin
{
	char Hoten[20];
	char Diachi[20];
	int Age;
	int Day,Month,Year;
};
//Thongtin x;
Thongtin x[3];
//int a,b;
//char st[100];
int main()
{
	//Write
	/*
	int a=5;
	int b=10;
	ofstream ofs; //out file
	ofs.open("D:\\hello.txt",ios::out);
	ofs<<"Here is date\n";
	ofs<<a<<"\t"<<b;
	ofs.close();
	*/
	//Read
	/*
	ifstream ifs;
	ifs.open("D:\\hello.txt",ios::in);
	ifs.getline(st,100);
	ifs>>a>>b;
	cout<<"thong tin\n";
	cout<<st<<"\n";
	cout<<"a="<<a;
	cout<<"\nb="<<b;
	ifs.close();
	*/
	/*
	//Ket hop voi Struct
	ifstream ifs;
	ifs.open("D\\hello.txt",ios::in);
	ifs.getline(x.Hoten,20,','); //dung lai khi gap ki tu ','
	ifs.getline(x.Diachi,20,',');
	ifs>>x.Age;
	ifs>>x.Day>>x.Month>>x.Year;
	ifs.close();
	cout<<setw(20)<<x.Hoten<<setw(20)<<x.Diachi<<setw(5)<<x.Age;
	cout<<setw(5)<<x.Day<<"/"<<setw(5)<<x.Month<<"/"<<setw(5)<<"/"<<x.Year;
	*/
	
	//Ket hop voi Struct
	/*
	int i;
	ifstream ifs;
	ifs.open("D\\hello.txt",ios::in);
	for(i=0;i<3;i++)
	{
	ifs.getline(x[i].Hoten,20,','); //dung lai khi gap ki tu ','
	ifs.getline(x[i].Diachi,20,',');
	ifs>>x[i].Age;
	ifs>>x[i].Day>>x[i].Month>>x[i].Year;
	}
	ifs.close();
	for(i=0;i<3;i++)
	{
	cout<<setw(20)<<x[i].Hoten<<setw(20)<<x[i].Diachi<<setw(5)<<x[i].Age;
	cout<<setw(5)<<x[i].Day<<"/"<<setw(5)<<x[i].Month<<"/"<<setw(5)<<"/"<<x[i].Year;
	}
	*/
	//Ket hop voi Struct
	
	int i;
	int n;
	ifstream ifs;
	ifs.open("D\\hello.txt",ios::in); //eof(): Read all
	while(!ifs.eof())
	{
	ifs.getline(x[i].Hoten,20,','); //dung lai khi gap ki tu ','
	ifs.getline(x[i].Diachi,20,',');
	ifs>>x[i].Age;
	ifs>>x[i].Day>>x[i].Month>>x[i].Year;
	i++;
	n=i;
	}
	ifs.close();
	for(i=0;i<n-1;i++)
	{
	cout<<setw(20)<<x[i].Hoten<<setw(20)<<x[i].Diachi<<setw(5)<<x[i].Age;
	cout<<setw(5)<<x[i].Day<<"/"<<setw(5)<<x[i].Month<<"/"<<setw(5)<<"/"<<x[i].Year;
	}
	
}
