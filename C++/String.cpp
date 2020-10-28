//Create a new string by alternately combining the characters of two halves of the string in reverse

#include<stdio.h>
#include<string.h>
using namespace std;

int main(){
  string str, s1;
  cout<<"Enter string: ";
  cin>>str;
  // cin.getline(str1,25);
  
  int len= str.length();
  int x=len/2;
  int y=len;
  
  while(x>0 && y>len/2){
    s1=s1+str[x-1];
    x--;
    s1+=str[y-1];
    y--;
  }
  
  if(y>len/2){
    s1+=str[y-1];
    y--;
  }
  
  cout<<s1; <<endl;
  retrun 0;
}
