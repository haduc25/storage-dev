#include <iostream>
#include <queue>
using namespace std;

int main(){
	queue<int> DS; //DS: day so
	DS.push(1);
	DS.push(2);
	DS.push(3);
	DS.push(4);
	DS.push(5);
	DS.push(6);
	DS.push(7);
    DS.push(8);
	DS.push(9);
	DS.push(10);
	cout<<"Vi Tri Dau: "<<DS.front()<<endl; //front(): Vi tri TOP
	cout<<"Vi Tri Cuoi "<<DS.back()<<endl;//back(): Vi tri Last
	cout<<"Kiem Tra Queue co rong khong: "<<DS.empty(); //.empty(): Kiem tra queue rong hay k, return 0: k rong, return 1: rong
	DS.pop();//.pop(): Xoa top cua Queue   
	cout<<"\nTop cua Queue sau khi xoa la: "<<DS.front();
										
}
