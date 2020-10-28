///Merge 2 arrays such tht the resulting array should have alternate elements from both arrays

#include<stdio.h>
#include<conio.h>
#inlcude<string.h>
using namespace std;

void PrintArray(int a[], int n=10) {
	int i;
	cout << "\nArray:";
	for (i = 0; i < n; i++) {
		cout << a[i] << " ";
	}
}

void Sort(int a[], int n) {
	//sorts min-max ">"
	int i, j;
	for (i = 0; i < n - 1; i++) {
		for (j = 0; j < n - i - 1; j++) {
			if (a[j] > a[j + 1])
				Swap(&a[j], &a[j + 1]);
		}
	}
	PrintArray(a, n);
}

void AlternateElements(int a[], int n, int b[], int m) {
	Sort(a, n);
	Sort(b, m);
	
	int i = 0, j = 0, k = 0, x=m+n;
	int c[100];

	//alternatively put vals from each array to c[]
	while (i < n && j < m) {
		c[k++] = a[i++];
		c[k++] = b[j++];
	}
	//put remaining elemnets
	while (i < n)	c[k++] = a[i++];
	while (j < m)	c[k++] = b[j++];

	cout << "\n merged array: ";
	for (i = 0; i < (m + n); i++)	cout << c[i]<<" ";
	
}

int main(){
  int a[100]={};
  int b[100]={};
  
  int i,j,n,m;
  cout<<"n:? ";
  cin>>n;
  for(i=0; i<n; i++){
    cin>>a[i];
  }
  cout<<"m:? ";
  cin>>m;
  for(i=0; i<n; i++){
    cin>>a[i];
  }
  
  PrintArray(a,n);
  cout<<"\n";
  PrintArray(b,m);
  cout<<endl;
  AlternateElements(a, n, b, m);

return 0;
}
