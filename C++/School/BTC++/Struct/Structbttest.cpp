#include <iostream>
#include <stdio.h>

using namespace std;
struct importInfo
{
	char teamName[20];
	int won,lost,mDraw,point;
};
importInfo a,b,*p;
int i,n;
int main()
{
	cout<<"So doi bong la: "<<endl;
	cin>>n;
	cin.get();
	//create Array use poiter
	p = new importInfo[n];
	for(i=0;i<=n;i++)
	{
		cout<<"Nhap thong tin cua doi bong ["<<i<<"] la: "<<endl;
		cout<<"Ten doi bong: ";
		cin.getline((p+i)->teamName,20);
		cout<<"Match Won: ";
		cin>>(p+i)->won;
		cout<<"Match Lost: ";
		cin>>(p+i)->lost;
		cout<<"Match Draw: ";
		cin>>(p+i)->mDraw;
		cout<<"Point of Team is: ";
		cin>>(p+i)->point;
		cout<<endl<<endl;
		cin.get();
	}
	cout<<"THONG TIN SO DOI BONG VUA NHAP LA: \n\n";
	for(i=0;i<=n;i++)
	{
		cout<<"Doi bong ["<<i<<"]: "<<endl;
		cout<<"Team name is: "<<(p+i)->teamName<<endl;
		cout<<"Match Won is: "<<(p+i)->won<<endl;
		cout<<"Match Lost is: "<<(p+i)->lost<<endl;
		cout<<"Match Draw is: "<<(p+i)->mDraw<<endl;
		cout<<"Point of Team is: "<<(p+i)->point<<endl;
		cout<<"END ["<<i<<"]"<<endl<<endl;
	}
}
