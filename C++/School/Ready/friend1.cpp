#include <iostream>
 
using namespace std;
 
class Box
{
	private:
   		double chieurong = 10;
	public:
	   friend void inChieuRong( Box box )
	   {
	   		cout << "Chieu rong cua box la: " << box.chieurong <<endl;
	   }
	   /*
	   void setChieuRong( double rong )
	   {
	   		chieurong = rong;
	   }*/
};

int main( )
{
   Box box;
   //box.setChieuRong(25.3);
   // su dung ham friend de in chieu rong.
   inChieuRong( box );
   return 0;
}
