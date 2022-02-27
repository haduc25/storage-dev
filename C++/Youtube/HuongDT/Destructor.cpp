/* Constructor
   Destructor :de huy doi tuong,con tro.. || Khac Constructor "~"
*/
#include <iostream>
using namespace std;
class SinhVien{
	private:
		string MaSV;
		string Ten;
		string Lop;
	public:
		SinhVien(){ //Constructor
		MaSV = "12345";
		Ten = "Ha Duc";
		Lop = "K18E";
		}
		~SinhVien(){ //Destructor
		cout<<"HUY DOI TUONG "<<endl; //Auto xuat hien 
		}
		void DiHoc(){
			cout<<"SV Di Hoc "<<endl;
		}
};

int main(){
	SinhVien a;
	a.DiHoc();
}
