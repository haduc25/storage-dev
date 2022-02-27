#include <iostream>
using namespace std;
int main(){
	int a = 110;
	cout<<"gia tri cua a = "<<a<<endl;
	cout<<"vi tri cua a = "<<&a<<endl;
	int *p = &a;
	cout<<"gia tri cua p = "<<p<<endl;
	cout<<"vi tri cua p = "<<&p<<endl;
	cout<<"gia tri tai dia chi p tro toi a = "<<*p<<endl;
	*p+=50;
	cout<<"gia tri con tro (p) sau khi + 50 = "<<*p<<endl;
	int b =100;
	p = &b;
	cout<<"gia tri cua con tro (p) sau khi gan vao b = "<<*p<<endl;	
	
}
