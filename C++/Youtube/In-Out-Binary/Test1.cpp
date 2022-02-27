#include <iostream>
#include <fstream>
using namespace std;
int main(){
	ifstream a ("Hello.jpg",ifstream ::binary);
	ofstream b ("Recode.jpg",ofstream :: binary);
	if(a){
		a.seekg(0,a.end);// do dai file
		int length = a.tellg();
		a.seekg(0,a.beg);
		 char *buffer = new char[length]; //lenght: chieu dai
		 a.read(buffer,length);
		 for(int i=0;i<length;i++)
		 buffer[i] = (buffer[i]+2);
		 b.write(buffer,length);
		 delete[] buffer;
		 
	}
	a.close();
	b.close();
	remove("Hello.jpg");
	return 0;
}
