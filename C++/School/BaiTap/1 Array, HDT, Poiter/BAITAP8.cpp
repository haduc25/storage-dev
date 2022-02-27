#include <iostream>
#include <fstream>
#include <iomanip>
#include <cstring>

using namespace std;

struct ThueBao
{
	char ma[10], ten[32];
	int so, d, m, y;	
};

ThueBao tb[100];
int i;

int main()
{	i=0;
	while (true) {
		cout << "Nhap thue bao thu: " << i + 1 << endl;
		cout << "Nhap ma vung: ";
		cin.getline(tb[i].ma, 10);
		if (strlen(tb[i].ma) == 0) break;
		cout << "Nhap so: ";
		cin >> tb[i].so;
		cin.ignore();
		cout << "Nhap ten khac hang: ";
		cin.getline(tb[i].ten, 32);
		cout << "Nhap ngay/thang/nam cap so:" << endl;
		cin >> tb[i].d >> tb[i].m >> tb[i].y;
		cin.ignore();
		i++;
	}	
	ofstream f;
	f.open("d:/folder/Dulieuhotro.txt");
	int n = i;
	for (i = 0; i < n; i++) {
		cout
			<< setw(10) << tb[i].ma
			<< setw(10) << tb[i].so
			<< setw(32) << tb[i].ten
			<< setw(20) << tb[i].d << "/" << tb[i].m << "/" << tb[i].y
			<< endl;
	}
	if (! f)
	{
	 cout << "Doc file that bai";
	}
	else {
		for (i = 0; i < n; i++) {
			f
				<< setw(10) << tb[i].ma
				<< setw(10) << tb[i].so
				<< setw(32) << tb[i].ten
				<< setw(20) << tb[i].d << "/" << tb[i].m << "/" << tb[i].y
				<< endl;
		}
	}
	f.close();
}
