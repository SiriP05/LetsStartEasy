//count the number of each vowels only in a string

#include<string.h>
#inlcude<stdio.h>
#inlcude<conio.h>

int main(){
  string s;
  int count_a=0, count_e=0, count_i=0, count_o=0, count_u=0;
  for(int i=0; i<str.length(); i++){
    if(str[i]=='a') count_a++;
    else if(str[i]=='e') count_e++;
    else if(str[i]=='i') count_i++;
    else if(str[i]=='o') count_o++;
    else if(str[i]=='u') count_u++;
  }
  cout<<"a=" <<count_a<<" e=" <<count_e<<" i=" <<count_i<<" o=" <<count_o<<" u=" <<count_u;
  
  return 0;
}
