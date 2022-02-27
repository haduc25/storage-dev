#include <iostream>
#include <cstdio>
#include <fstream>
#include <cmath>

using namespace std;


	//kiem tra snt
    int Nguyento(int x)
    {
    if (x < 2)    
        return 0;
    for (int j = 2; j <= sqrt(x); j ++)
    {
        if (x%j==0)
        {
            return 0;
        }
    }
    return 1;
	}
int i,j,n,*p,empty,temp;

int main()
{
	do
	{
		cout<<"NHAP N: ";
		cin>>n;
		cin.get();
		p = new int[n];
	}//5<=n<=50
	while(n<5 || n>20);
	//nhap mang
	cout<<"NHAP VAO MANG\n";
	for(i=0;i<n;i++)
	{
		cout<<"ARR ["<<i+1<<"]= ";
		cin>>*(p+i);
	}
	//xuat mang
	cout<<"\nMANG VUA NHAP:";
	for(i=0;i<n;i++)
	{
		cout<<"\t"<<*(p+i);
	}
	//xuat file
	ofstream ofs;
	ofs.open("C:\\Users\\Admin\\Desktop\\mang.txt",ios::out);
	if(!ofs)
	{
		cout<<"ERROR !!!";	
	}
	else
	{
	for(i=0;i<n;i++)
	{
		ofs<<"\t"<<*(p+i);
	}
	}
	ofs.close();
	//doc file
	cout<<"\nDOC FILE TU MAN HINH: ";
	ifstream ifs;
	ifs.open("C:\\Users\\Admin\\Desktop\\mang.txt",ios::in);
	i=-1;
	while(!ifs.eof())
	{	
		ifs>>*(p+i);
		i++;
		cout<<"\t"<<*(p+i);
	}
	ifs.close();
	//xuat snt
	cout<<"\nSO NGUYEN TO TRONG FILE: ";
	for(i=0;i<n;i++)
	{
		if(Nguyento(p[i]))
		{
			cout<<"\t"<<*(p+i);
		}
	}
}
