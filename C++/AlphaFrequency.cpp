//calcluate the frequency of each alphabet in the string

#include<stdio.h>
#inlcuded<string.h>
using namespace std;

int main(){
  string s;
  int c, x, count[26]={};
  cout<<"enter string: ";
  cin>>s;
  cout<<"\n"<<s;
  for(c=0; c<s.length(); c++){
    if(s[c]>='a' && s[c]<='z'){
      x=s[c]-'a';
      count[x]++;
      if(count[x]==1){
        cout<<char(c+'a');
        break;
      }
    }
  }
  cout<<"alphabet\tCount"<<endl;
  for(c=0;c<26;C++){
    cout<<char(c+'a')<<" = "<<count[c]<<endl;
  }

  return 0;
}
