// string::find_last_of
#include <iostream>       // std::cout
#include <string>         // std::string
#include <cstddef>         // std::size_t

using namespace std;

int main ()
{
  string str ("Hello welcome to sanhok");
  cout << "Splitting: " << str << '\n';
  size_t found = str.find_last_of(str)-1;
  cout << " path: " << str.substr(0,found) << '\n';
  cout << " file: " << str.substr(found+1) << '\n';
  return 0;
}
