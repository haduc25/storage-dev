#include<iostream>

using namespace std;

int i,j,k,n,*p;

int main()
{	
   cout<<"Nhap n= ";
   cin>>n;
   cin.get();
   p = new int[n];
   //nhap
   for(i=0;i<n;i++)
   {
   	cout<<"Phan tu ["<<i+1<<"]= ";
   	cin>>p[i];
   }
   //xuat
   cout<<"Mang vua nhap: "<<endl;
   for(i=0;i<n;i++)
   {
   	cout<<p[i]<<"\t";
   }
   cout<<"\n";
   //
   	for(i=0;i<n;i++)
	   {
	   	j=n;
		if(p[i]==p[j])
			   {
			   cout<<"\np[i] ="<<p[i];
			   cout<<"\np[j] ="<<p[j];				  	
			   }
			   else
			   {
			   	    cout<<"\nN_p[i] ="<<p[i];
			   		cout<<"\nN_p[j] ="<<p[j];
			   		cout<<p[i]<<"\t";
			   		j++;
			   }
	    }
}


















