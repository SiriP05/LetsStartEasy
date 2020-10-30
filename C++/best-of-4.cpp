#include <stdio.h>
void best_of_four (int,int,int,int)
int main()
{
    int a,b,c,d;
    scanf("%d %d %d %d",&a,&b,&c,&d);
   best_of_four(a,b,c,d);
    return(0);
}
void best_of_four(int p,int q,int r,int s)
{

  if((p>q)&&(p>r)&&(p>s))
    printf("%d",p);
  else
    {
      if ((q>r) && (q>s))
        printf("%d",q);
      else
        {
          if (r>s)
            printf("%d",r);
          else
            printf("%d",s);}
        }
    }
   }
}
