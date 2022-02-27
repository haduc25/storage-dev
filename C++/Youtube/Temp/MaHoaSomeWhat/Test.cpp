
#include <iostream>
#include <string>
using namespace std;
 // hàm tìm rõ s? c?a ch? cái
int TimRoSo(string BangChuCai, char Chuoi) {
 int temp = 0;
 for (int i = 0; i < BangChuCai.length(); i++) {
  if (BangChuCai[i] == Chuoi) {
   temp = i;
   break;
  }
 }
 return temp;
}
// hàm tìm mã ch?
string TimMaChu(string BangChuCai, string Chuoi, int k){
 string MaChu = "";
 int MaSo;
 for (int i = 0; i < Chuoi.length(); i++) { // tìm t?ng ch? cái m?t
  MaSo = TimRoSo(BangChuCai, Chuoi[i]); // tìm rõ s? c?a ch? cái dó
  int temp = (MaSo + k) % 26; // c?ng thêm khoa k mod 26
  MaChu += BangChuCai[temp]; // tìm ch? cái có mã s? là temp và n?i vào chu?i MaChu
 }
 return MaChu;
}
// hàm gi?i mã.
string TimGiaiMa(string BangChuCai, string Chuoi, int k){
 string GiaiMa = "";
 int MaSo;
 for (int i = 0; i < Chuoi.length(); i++) {
  MaSo = TimRoSo(BangChuCai, Chuoi[i]);
  MaSo -= k;
  if (MaSo < 0) {
   int temp = 26 + MaSo;
   MaSo = temp;
  }
  GiaiMa += BangChuCai[MaSo];
 }
 return GiaiMa;
}
int main(){
 string BangChuCai = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // có th? thêm nhi?u ký t? khác vào d? mã hóa
 string Chuoi;
 int k;
 int chon;
 do
 {
  system("cls");
  cout << "1. Lap ma. " << endl;
  cout << "2. Giai ma. " << endl;
  cout << "Chon: ";
  cin >> chon;
  switch (chon)
  {
  case 1: {
   cin.ignore();
   cout << "Nhap chuoi: ";
   getline(cin, Chuoi);
   cout << "Nhap khoa: ";
   cin >> k;
   cout << TimMaChu(BangChuCai, Chuoi, k) << endl;
   system("pause");
   break;
  }
  case 2: {
   cin.ignore();
   cout << "Nhap chuoi: ";
   getline(cin, Chuoi);
   cout << "Nhap khoa: ";
   cin >> k;
   cout << TimGiaiMa(BangChuCai, Chuoi, k) << endl;
   system("pause");
   break;
  }
  }
 } while (chon != 0);
 return 0;
}
