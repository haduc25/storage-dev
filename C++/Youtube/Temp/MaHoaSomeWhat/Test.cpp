
#include <iostream>
#include <string>
using namespace std;
 // h�m t�m r� s? c?a ch? c�i
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
// h�m t�m m� ch?
string TimMaChu(string BangChuCai, string Chuoi, int k){
 string MaChu = "";
 int MaSo;
 for (int i = 0; i < Chuoi.length(); i++) { // t�m t?ng ch? c�i m?t
  MaSo = TimRoSo(BangChuCai, Chuoi[i]); // t�m r� s? c?a ch? c�i d�
  int temp = (MaSo + k) % 26; // c?ng th�m khoa k mod 26
  MaChu += BangChuCai[temp]; // t�m ch? c�i c� m� s? l� temp v� n?i v�o chu?i MaChu
 }
 return MaChu;
}
// h�m gi?i m�.
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
 string BangChuCai = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // c� th? th�m nhi?u k� t? kh�c v�o d? m� h�a
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
