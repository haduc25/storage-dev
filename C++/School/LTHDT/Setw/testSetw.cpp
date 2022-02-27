#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	string b = ".";
	int a = 10;
	cout<<"Hello World\n";
	cout<<setw(a)<<"Hola"<<b<<endl;
	cout<<setw(20)<<left<<"LEFT\n";
	cout<<setw(50)<<right<<"RIGHT\n";
	cout<<setfill('/');
}
