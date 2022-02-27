/*
Ham Overloading
abs: Tinh tri tuyet doi
*/
#include <iostream>
using namespace std;

int abs(int a){
	if(a<0){
		return -a;
	}
	else{
		return a;
	}
}
float abs(float a){
	if(a<0){
		return -a;
	}
	else{
		return a;
	}
}
int main(){
	//xep chong ham
	int a = 5;
	float b = 10.5;
	char c = 'a';
	cout<<"Gia tri cua int la: "<<abs(a)<<endl;
	cout<<"Gia tri cua float la: "<<abs(b)<<endl;
	cout<<"Gia tri cua char la: "<<abs(c)<<endl;
}
