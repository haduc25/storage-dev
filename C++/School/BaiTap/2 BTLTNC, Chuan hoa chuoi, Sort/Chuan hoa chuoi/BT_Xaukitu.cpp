#include <iostream>
#include <cstring>

using namespace std;
bool Space(char a){
	return a==' ';
}
int main()
{
	int temp,i,j,n,left = 0;
	char xau1[100];
	char xau2[100];
	cout<<"Nhap vao xau ki tu: ";
	gets(xau1);
	string st1 =  xau1;
		strcpy(xau2,xau1);
	cout<<"Xau vua nhap la: "<<xau1;
	//dem ki tu
	cout<<"\nSo ki tu trong xau la: "<<strlen(xau1);
	//chuan hoa xau
	//xoa khoang trang 
	n = strlen(xau1);
	for(i=0;i<n;i++){
		if(Space(xau1[i]) && Space(xau1[i+1])){
			for(j=i+1;j<n;j++){
				xau1[j]=xau1[j+1];
			}
			i--;
			n--;
		}
	}
	cout<<"\nXau ki tu sau khi xoa khoang trang: "<<xau1;
	//chuyen ve chu thuong
	cout<<"\nXau chu thuong: "<<strlwr(xau1);
	//chuyen ve chu hoa
	cout<<"\nXau chu hoa: "<<strupr(xau1);
	//Chu cuoi cung trong xau
	size_t finally = st1.find_last_of(st1)-1;
	cout << "\nChu cuoi cung trong xau: " << st1.substr(finally+1);
	//substr: chuoi con
	//chu cuoi cung tu trong xau
	//tach ten vd: nguyen van a
	//tach lay : a+
}
