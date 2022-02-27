/*
Con Tro(Pointer)
&:Toan tu dia chi,Dia chi cua bien|| Use: Lay dia chi Bien
*: Poiter(con tro),Toan tu gia tri,gia tri ma con tro n tro toi ||ex: a=1,*p=a,=>*p=1 
*&: Use: Lay gia tri cua dia chi n || ex: *&n = n 
chu y: poiter if *p la "int" thi chi co the chi den "int" ex: float a=10;int *p;p=&a;=>(ERROR);
ex: Khai Bao pointer:
int main(){
inr a=1,b=2;
int *p =&a;// lan 1
p=&b; //lan 2
ex: *p=0;*p=NULL;
Them o trong bo nho ||ex:int *p=0;p=new int;
*/
#include <iostream>
using namespace std;
 int main(){
 	int a,b;
 	int *p = NULL;
 	p=&a;
 	cout<<"Nhap A: ";
 	cin>>a;
 	cout<<"Nhap B: ";
 	cin>>b;
 	cout<<"A= "<<a<<endl;
 	cout<<"Dia Chi Cua Bien A: "<<&a;
 	cout<<"\nDia chi cua con tro P la: "<<&p;
 	cout<<"\nGia tri cua p hien tai: "<<p;
 	cout<<"\nDia cho ma con tro p tro toi la: "<<*&a;
 	*p+=10;
 	cout<<"\nDia chi cua bien sau khi +10: ";
 	cout<<"\nA= "<<a;
 	cout<<"\nDia cho ma con tro p tro toi la: "<<*&a;
 	cout<<"\nDia Chi Cua Bien A: "<<&a;
 	cout<<"\nDia cho ma con tro p tro toi la: "<<*&a;
 	//dung con tro chi den bien B;
 	p=&b;// lan 2 khong can them (*) 
 	cout<<"\n\nB= "<<b<<"\n";
 	cout<<"Dia Chi Cua Bien B: "<<&b;
 	cout<<"\nDia chi cua con tro P la: "<<&p;
 	cout<<"\nGia tri cua p hien tai: "<<p;
 	cout<<"\nDia cho ma con tro p tro toi la: "<<*&b;
 	*p+=15;
 	cout<<"\nDia chi cua bien sau khi +15: ";
 	cout<<"\nB= "<<b;
 	cout<<"\nDia cho ma con tro p tro toi la: "<<*&b;
 	cout<<"\nDia Chi Cua Bien B: "<<&b;
 	cout<<"\nDia cho ma con tro p tro toi la: "<<*&b;
 	
 }
