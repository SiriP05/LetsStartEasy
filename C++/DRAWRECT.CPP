/*initgraph(&gd,&gm,"C:\\TurboC3\\BGI");
 setfillstyle(SOLID_FILL,RED);
  circle(140,150,80);
 floodfill(141,150,WHITE);
*/
#include<iostream.h>
#include<conio.h>
#include<graphics.h>
#include<stdio.h>
class a
{
 public:
 int gd;
 int gm;
 public:
 a()
 {
  gd=DETECT;
  initgraph(&gd,&gm,"C:\\TurboC3\\BGI");
 }
 void draw(int l,int t,int r,int b);
 void draw(int x,int y,int ra);
};
void a::draw(int l,int t,int r,int b)
{
 setfillstyle(SOLID_FILL,RED);
 rectangle(l,t,r,b);
 floodfill(235,335,WHITE);
}
void a::draw(int x,int y,int ra)
{
 setfillstyle(SOLID_FILL,GREEN);
 circle(x,y,ra);
 floodfill(75,75,WHITE);

}
void main()
{
 clrscr();
 a obj;
 obj.draw(200,230,330,390);
 obj.draw(70,70,50);
 getch();
}
