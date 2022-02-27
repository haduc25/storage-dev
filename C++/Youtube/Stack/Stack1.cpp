#include <iostream>
#include <stack>
using namespace std;

 int main(){
 	stack<int> Dayso;
 	Dayso.push(1);
 	Dayso.push(2);
 	Dayso.push(3);
 	Dayso.push(4);
 	Dayso.push(5);
 	Dayso.push(6);
 	Dayso.push(7);
 	Dayso.push(8);
	Dayso.push(9);
	Dayso.push(10);
	cout<<"Top cua Stack la: "<<Dayso.top(); 
	cout<<"\nKick Thuoc cua Stack la: "<<Dayso.size();
	cout<<"\nKiem Tra Stack co rong khong: "<<Dayso.empty(); //.empty(): Kiem tra stack rong hay k, return 0: k rong, return 1: rong
	Dayso.pop();//Dayso.pop(): Xoa top cua Stack   
	cout<<"\nTop cua Stack sau khi xoa la: "<<Dayso.top();
 	
 }
