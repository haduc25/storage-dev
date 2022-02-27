/*
 strlen() : dem chuoi
 strcmp() : so sanh chuoi
*/
#include <iostream>
#include <cstdio>
#include <cstring>

using namespace std;
int main(){
	char tuoi[2];
	char hoten[100];
	char chuoi1[50];
	char chuoi2[50];
	cout<<"Nhap tuoi : ";
	gets(tuoi);
	cout<<"Nhap ten : ";
	gets(hoten);
	cout<<"Nhap chuoi 1 : ";
	gets(chuoi1);
	cout<<"Nhap chuoi 2 : ";
	gets(chuoi2);
	cout<<"tuoi la : "<<tuoi<<endl;
	cout<<"Ho ten la : "<<hoten;
    cout<<"\nSo ki tu cua ten la : "<<strlen(hoten)<<endl;
    cout<<"Gia tri cua CMP la : "<<strcmp(chuoi1,chuoi2);
}

