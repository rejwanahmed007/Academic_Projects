#include <iostream>
#include <stdlib.h>
#include<GL/gl.h>
#include <GL/glut.h>
#include<math.h>
#include<cstring>
#include<windows.h>
#include<mmsystem.h>
#include <string>
#include <sstream>
#include<cstdio>
#include <windows.h>
#include<math.h>
#include <vector>
#include <cstdlib>
# define PI 3.14159265358979323846
#include <GL/gl.h>
#include <GL/glut.h>
#include<MMSystem.h>
using namespace std;

void update(int);
float speed = 0.0f;
float speed1 = 0.0f;
float transFactor = 0.0f;
float transFactor1 = 0.0f;
float transFactor2 = 0.0f;
float transFactor3 = 0.0f;
float transFactor4 = 0.0f;
float transFactor5 = 0.0f;
float transFactor6 = 0.0f;
float transFactor7 = 0.0f;
float transFactor8 = 0.0f;
float transFactor9 = 0.0f;
int count1 = 0;
int stage = 0;
string s1 = "Stage: ";
float xr=0,yr=0;
float w=65,h=110;
//char a[6]={'C','O','U','N','T','='};
string s = "Count: ";
string ys="your score: ";
bool collide = false;
int i,q,dir=0;
//string s2 = "COUNT: ";

    float getX(int val)
    {
        int width = glutGet(GLUT_WINDOW_WIDTH);
        float frac = (float)val/((float)width/2);
        return frac;
    }
    float getY(int val)
    {
        int height = glutGet(GLUT_WINDOW_HEIGHT);
        float frac = (float)val/((float)height/2);
        return frac;
    }
    void Sprint( float x, float y, char *st)
    {
        int l,i;
        l=strlen( st ); // see how many characters are in text string.
        glColor3f(0.0,1.0,0.7);
        //glDisable(GL_LIGHTING);
        glRasterPos2f( x, y); // location to start printing text
        for( i=0; i < l; i++) // loop until i is greater then l
        {
            glutBitmapCharacter(GLUT_BITMAP_HELVETICA_18, st[i]);
        }
    }

    void Sprint1( float x, float y, char *st)
    {
        int l,i;
        l=strlen( st ); // see how many characters are in text string.
        glColor3f(1.0,0.0,0.0);
        //glDisable(GL_LIGHTING);
        glRasterPos2f( x, y); // location to start printing text
        for( i=0; i < l; i++) // loop until i is greater then l
        {
            glutBitmapCharacter(GLUT_BITMAP_HELVETICA_18, st[i]);
        }
    }

void drawText(char ch[],int xpos, int ypos)//draw the text for score and game over
{
    int numofchar = strlen(ch);
    glLoadIdentity ();
    glRasterPos2f( xpos , ypos);
    for (i = 0; i <= numofchar - 1; i++)
    {

    glutBitmapCharacter(GLUT_BITMAP_HELVETICA_18, ch[i]);//font used here, may use other font also
    }
}


    void specialKeys(int key, int x, int y)
    {
        switch (key)
        {

            case GLUT_KEY_RIGHT:
            if(xr<0)
            {
                if (dir==0)
                {
                    dir=1;
                }
                else

                     dir=0;


                xr=xr+0.32;

                break;
            }
            else
            {
                dir=1;
                xr=0.32;
                break;
            }
            case GLUT_KEY_LEFT:
            if(xr>-0.1)
            {
                if (dir==1)
                {
                    dir=0;
                }
                else
                dir=2;
                xr=xr-0.32;
                break;
            }
            else
            {
                dir=dir;
                xr=-0.32;
                break;
            }
        }

        //if(transFactor<getY(-4500))
        //{
          //  speed+=0.02f;
            //update(0);
        //}
        if(transFactor1<getY(-650))
        {
            speed+=0.1f;
            update(0);
        }
        if(transFactor2<getY(-750))
        {
            speed+=0.1f;
            update(0);
        }

        if(transFactor3<getY(-2050))
        {
            speed+=0.1f;
            update(0);
        }
    }
    void randomobj(int x, int y)
    {

        glBegin(GL_QUADS);
        ///starting
        glColor3f (1.0, 0.0, 0.0);
        glVertex2f(getX(x+15),getY(y));
        glVertex2f(getX(x+w-15),getY(y));
        glVertex2f(getX(x+w),getY(y+h-100));
        glVertex2f(getX(x),getY(y+h-100));
        /// body
         glColor3f (1.0, 0.0, 0.0);
         glVertex2f(getX(x),getY(y+h-100));
         glVertex2f(getX(x+w),getY(y+h-100));
         glVertex2f(getX(x+w),getY(y+h-5));
         glVertex2f(getX(x),getY(y+h-5));

         /// back side glass
         glColor3f (0.0, 0.0, 0.0);
         glVertex2f(getX(x+20),getY(y+h-20));
         glVertex2f(getX(x+w-20),getY(y+h-20));
         glVertex2f(getX(x+w-10),getY(y+h-10));
         glVertex2f(getX(x+10),getY(y+h-10));
         /// front side glass
         glColor3f (0.0, 0.0, 0.0);
        glVertex2f(getX(x+10),getY(y+h-80));
         glVertex2f(getX(x+20),getY(y+h-70));
         glVertex2f(getX(x+w-20),getY(y+h-70));
         glVertex2f(getX(x+w-10),getY(y+h-80));
         /// left side glass
          glColor3f (0.0, 0.0, 0.0);
          glVertex2f(getX(x+5),getY(y+h-78));
          glVertex2f(getX(x+15),getY(y+h-68));
          glVertex2f(getX(x+15),getY(y+h-22));
          glVertex2f(getX(x+5),getY(y+h-12));
          /// right side glass
          glColor3f (0.0, 0.0, 0.0);
          glVertex2f(getX(x+w-5),getY(y+h-78));
          glVertex2f(getX(x+w-15),getY(y+h-68));
          glVertex2f(getX(x+w-15),getY(y+h-22));
          glVertex2f(getX(x+w-5),getY(y+h-12));
        /// ending
        glColor3f (1.0, 0.0, 0.0);
        glVertex2f(getX(x),getY(y+h-5));
        glVertex2f(getX(x+w),getY(y+h-5));
        glVertex2f(getX(x+w-15),getY(y+h));
        glVertex2f(getX(x+15),getY(y+h));


        glEnd();

    }


    void car()
    {

        glBegin(GL_QUADS);
        glColor3f (0.0, 0.0, 1.0);
        glVertex2f(getX(-30)+xr,getY(-280)+yr);
        glVertex2f(getX(30)+xr,getY(-280)+yr);
        glVertex2f(getX(40)+xr,getY(-290)+yr);
        glVertex2f(getX(-40)+xr,getY(-290)+yr);
        glColor3f (0.0, 0.0, 1.0);
        glVertex2f(getX(-40)+xr,getY(-290)+yr);
        glVertex2f(getX(40)+xr,getY(-290)+yr);
        glVertex2f(getX(40)+xr,getY(-380)+yr);
        glVertex2f(getX(-40)+xr,getY(-380)+yr);
        /// top glass
        glColor3f (0.0, 0.0, 0.0);
        glVertex2f(getX(-30)+xr,getY(-315)+yr);
        glVertex2f(getX(30)+xr,getY(-315)+yr);
        glVertex2f(getX(22)+xr,getY(-321)+yr);
        glVertex2f(getX(-22)+xr,getY(-321)+yr);
        /// back side glass
        glColor3f (0.0, 0.0, 0.0);
        glVertex2f(getX(-28)+xr,getY(-376)+yr);
        glVertex2f(getX(28)+xr,getY(-376)+yr);
        glVertex2f(getX(18)+xr,getY(-370)+yr);
        glVertex2f(getX(-18)+xr,getY(-370)+yr);
        ///left side glass
         glColor3f (0.0, 0.0, 0.0);
        glVertex2f(getX(-32)+xr,getY(-375)+yr);
        glVertex2f(getX(-24)+xr,getY(-368)+yr);
        glVertex2f(getX(-24)+xr,getY(-323)+yr);
        glVertex2f(getX(-32)+xr,getY(-316)+yr);
        ///right side glass
        glColor3f (0.0, 0.0, 0.0);
        glVertex2f(getX(32)+xr,getY(-375)+yr);
        glVertex2f(getX(24)+xr,getY(-368)+yr);
        glVertex2f(getX(24)+xr,getY(-323)+yr);
        glVertex2f(getX(32)+xr,getY(-316)+yr);
        glEnd();

    }






    void StartingText()
{
    char text[120];
    sprintf(text, "Car racing .......",5.00,8.00);
    //sprintf(text, "Press Space to start the game",5.00,7.00);
    glColor3f(0, 0, 0);
    glRasterPos2f( -28 , 12 );

    for(int i = 0; text[i] != '\0'; i++)
    {
        if(text[i]==' ' && text[i+1]==' ')
        {
            glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, text[i]);
            glRasterPos2f( -42 , 02 );
        }
        else glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, text[i]);
    }
}

    void StartingText1()
{
    char text[120];
    //sprintf(text, "Press",5.00,8.00);
    sprintf(text, "Press Space to start the game",2.00,3.00);
    glColor3f(0, 0, 0);
    glRasterPos2f( -28 , 12 );
    for(int i = 0; text[i] != '\0'; i++)
    {
        if(text[i]==' ' && text[i+1]==' ')
        {
            glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, text[i]);
            glRasterPos2f( -42 , 02 );
        }
        else glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, text[i]);
    }
}


void reshape(int w, int h)
{
//    std::cout<<"Reshape is called"<<std::endl;
    float aspectRatio = (float)w/(float)h;
    glMatrixMode(GL_PROJECTION);
    glLoadIdentity();
    gluPerspective(145, aspectRatio, 1.0, 100.0);
    glMatrixMode(GL_MODELVIEW);

}




    void drawScene()
    {
        glClear(GL_COLOR_BUFFER_BIT);
        glLoadIdentity();
        glMatrixMode(GL_MODELVIEW);
        glColor3ub(255,0,0);
        glPushMatrix();
        glTranslatef(0,transFactor,0);


        //Road
        glBegin(GL_QUADS);
        glColor3f (0.0, 0.0, 0.0);
        glVertex2f(getX(-320),getY(-5070));
        glVertex2f(getX(320),getY(-5070));
        glVertex2f(getX(320),getY(5070));
        glVertex2f(getX(-320),getY(5070));


        //1
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(-270));
        glVertex2f(getX(-90),getY(-270));
        glVertex2f(getX(-90),getY(-370));
        glVertex2f(getX(-110),getY(-370));
        //2
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(-70));
        glVertex2f(getX(-90),getY(-70));
        glVertex2f(getX(-90),getY(-170));
        glVertex2f(getX(-110),getY(-170));
        //3
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(70));
        glVertex2f(getX(-90),getY(70));
        glVertex2f(getX(-90),getY(170));
        glVertex2f(getX(-110),getY(170));
        //4
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(270));
        glVertex2f(getX(-90),getY(270));
        glVertex2f(getX(-90),getY(370));
        glVertex2f(getX(-110),getY(370));
        //5
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(470));
        glVertex2f(getX(-90),getY(470));
        glVertex2f(getX(-90),getY(570));
        glVertex2f(getX(-110),getY(570));
        //6
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(670));
        glVertex2f(getX(-90),getY(670));
        glVertex2f(getX(-90),getY(770));
        glVertex2f(getX(-110),getY(770));
        //7
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(870));
        glVertex2f(getX(-90),getY(870));
        glVertex2f(getX(-90),getY(970));
        glVertex2f(getX(-110),getY(970));

        //8
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(1070));
        glVertex2f(getX(-90),getY(1070));
        glVertex2f(getX(-90),getY(1170));
        glVertex2f(getX(-110),getY(1170));
        //9th
        glBegin(GL_QUADS);
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(1270));
        glVertex2f(getX(-90),getY(1270));
        glVertex2f(getX(-90),getY(1370));
        glVertex2f(getX(-110),getY(1370));
        //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(1470));
        glVertex2f(getX(-90),getY(1470));
        glVertex2f(getX(-90),getY(1570));
        glVertex2f(getX(-110),getY(1570));


                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(1670));
        glVertex2f(getX(-90),getY(1670));
        glVertex2f(getX(-90),getY(1770));
        glVertex2f(getX(-110),getY(1770));
        //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(1870));
        glVertex2f(getX(-90),getY(1870));
        glVertex2f(getX(-90),getY(1970));
        glVertex2f(getX(-110),getY(1970));
        //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(2070));
        glVertex2f(getX(-90),getY(2070));
        glVertex2f(getX(-90),getY(2170));
        glVertex2f(getX(-110),getY(2170));
        //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(2270));
        glVertex2f(getX(-90),getY(2270));
        glVertex2f(getX(-90),getY(2370));
        glVertex2f(getX(-110),getY(2370));
        //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(2470));
        glVertex2f(getX(-90),getY(2470));
        glVertex2f(getX(-90),getY(2570));
        glVertex2f(getX(-110),getY(2570));
        //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(2670));
        glVertex2f(getX(-90),getY(2670));
        glVertex2f(getX(-90),getY(2770));
        glVertex2f(getX(-110),getY(2770));
        //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(2870));
        glVertex2f(getX(-90),getY(2870));
        glVertex2f(getX(-90),getY(2970));
        glVertex2f(getX(-110),getY(2970));
        //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(3070));
        glVertex2f(getX(-90),getY(3070));
        glVertex2f(getX(-90),getY(3170));
        glVertex2f(getX(-110),getY(3170));
        //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(3270));
        glVertex2f(getX(-90),getY(3270));
        glVertex2f(getX(-90),getY(3370));
        glVertex2f(getX(-110),getY(3370));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(3470));
        glVertex2f(getX(-90),getY(3470));
        glVertex2f(getX(-90),getY(3570));
        glVertex2f(getX(-110),getY(3570));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(3670));
        glVertex2f(getX(-90),getY(3670));
        glVertex2f(getX(-90),getY(3770));
        glVertex2f(getX(-110),getY(3770));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(3870));
        glVertex2f(getX(-90),getY(3870));
        glVertex2f(getX(-90),getY(3970));
        glVertex2f(getX(-110),getY(3970));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(4070));
        glVertex2f(getX(-90),getY(4070));
        glVertex2f(getX(-90),getY(4170));
        glVertex2f(getX(-110),getY(4170));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(4270));
        glVertex2f(getX(-90),getY(4270));
        glVertex2f(getX(-90),getY(4370));
        glVertex2f(getX(-110),getY(4370));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(4470));
        glVertex2f(getX(-90),getY(4470));
        glVertex2f(getX(-90),getY(4570));
        glVertex2f(getX(-110),getY(4570));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(4670));
        glVertex2f(getX(-90),getY(4670));
        glVertex2f(getX(-90),getY(4770));
        glVertex2f(getX(-110),getY(4770));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(4870));
        glVertex2f(getX(-90),getY(4870));
        glVertex2f(getX(-90),getY(4970));
        glVertex2f(getX(-110),getY(4970));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(5070));
        glVertex2f(getX(-90),getY(5070));
        glVertex2f(getX(-90),getY(5170));
        glVertex2f(getX(-110),getY(5170));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(5270));
        glVertex2f(getX(-90),getY(5270));
        glVertex2f(getX(-90),getY(5370));
        glVertex2f(getX(-110),getY(5370));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(5470));
        glVertex2f(getX(-90),getY(5470));
        glVertex2f(getX(-90),getY(5570));
        glVertex2f(getX(-110),getY(5570));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(5670));
        glVertex2f(getX(-90),getY(5670));
        glVertex2f(getX(-90),getY(5770));
        glVertex2f(getX(-110),getY(5770));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(5870));
        glVertex2f(getX(-90),getY(5870));
        glVertex2f(getX(-90),getY(5970));
        glVertex2f(getX(-110),getY(5970));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(6070));
        glVertex2f(getX(-90),getY(6070));
        glVertex2f(getX(-90),getY(6170));
        glVertex2f(getX(-110),getY(6170));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(6270));
        glVertex2f(getX(-90),getY(6270));
        glVertex2f(getX(-90),getY(6370));
        glVertex2f(getX(-110),getY(6370));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(-110),getY(6470));
        glVertex2f(getX(-90),getY(6470));
        glVertex2f(getX(-90),getY(6570));
        glVertex2f(getX(-110),getY(6570));


        //right bar
        //1
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(-270));
        glVertex2f(getX(90),getY(-270));
        glVertex2f(getX(90),getY(-370));
        glVertex2f(getX(110),getY(-370));
        //2
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(-70));
        glVertex2f(getX(90),getY(-70));
        glVertex2f(getX(90),getY(-170));
        glVertex2f(getX(110),getY(-170));
        //3
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(70));
        glVertex2f(getX(90),getY(70));
        glVertex2f(getX(90),getY(170));
        glVertex2f(getX(110),getY(170));
        //4
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(270));
        glVertex2f(getX(90),getY(270));
        glVertex2f(getX(90),getY(370));
        glVertex2f(getX(110),getY(370));
        //5
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(470));
        glVertex2f(getX(90),getY(470));
        glVertex2f(getX(90),getY(570));
        glVertex2f(getX(110),getY(570));
        //6
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(670));
        glVertex2f(getX(90),getY(670));
        glVertex2f(getX(90),getY(770));
        glVertex2f(getX(110),getY(770));
        //7
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(870));
        glVertex2f(getX(90),getY(870));
        glVertex2f(getX(90),getY(970));
        glVertex2f(getX(110),getY(970));

        //8
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(1070));
        glVertex2f(getX(90),getY(1070));
        glVertex2f(getX(90),getY(1170));
        glVertex2f(getX(110),getY(1170));
        //9th
        glBegin(GL_QUADS);
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(1270));
        glVertex2f(getX(90),getY(1270));
        glVertex2f(getX(90),getY(1370));
        glVertex2f(getX(110),getY(1370));
        //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(1470));
        glVertex2f(getX(90),getY(1470));
        glVertex2f(getX(90),getY(1570));
        glVertex2f(getX(110),getY(1570));




                        //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(1670));
        glVertex2f(getX(90),getY(1670));
        glVertex2f(getX(90),getY(1770));
        glVertex2f(getX(110),getY(1770));
        //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(1870));
        glVertex2f(getX(90),getY(1870));
        glVertex2f(getX(90),getY(1970));
        glVertex2f(getX(110),getY(1970));
        //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(2070));
        glVertex2f(getX(90),getY(2070));
        glVertex2f(getX(90),getY(2170));
        glVertex2f(getX(110),getY(2170));
        //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(2270));
        glVertex2f(getX(90),getY(2270));
        glVertex2f(getX(90),getY(2370));
        glVertex2f(getX(110),getY(2370));
        //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(2470));
        glVertex2f(getX(90),getY(2470));
        glVertex2f(getX(90),getY(2570));
        glVertex2f(getX(110),getY(2570));
        //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(2670));
        glVertex2f(getX(90),getY(2670));
        glVertex2f(getX(90),getY(2770));
        glVertex2f(getX(110),getY(2770));
        //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(2870));
        glVertex2f(getX(90),getY(2870));
        glVertex2f(getX(90),getY(2970));
        glVertex2f(getX(110),getY(2970));
        //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(3070));
        glVertex2f(getX(90),getY(3070));
        glVertex2f(getX(90),getY(3170));
        glVertex2f(getX(110),getY(3170));
        //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(3270));
        glVertex2f(getX(90),getY(3270));
        glVertex2f(getX(90),getY(3370));
        glVertex2f(getX(110),getY(3370));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(3470));
        glVertex2f(getX(90),getY(3470));
        glVertex2f(getX(90),getY(3570));
        glVertex2f(getX(110),getY(3570));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(3670));
        glVertex2f(getX(90),getY(3670));
        glVertex2f(getX(90),getY(3770));
        glVertex2f(getX(110),getY(3770));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(3870));
        glVertex2f(getX(90),getY(3870));
        glVertex2f(getX(90),getY(3970));
        glVertex2f(getX(110),getY(3970));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(4070));
        glVertex2f(getX(90),getY(4070));
        glVertex2f(getX(90),getY(4170));
        glVertex2f(getX(110),getY(4170));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(4270));
        glVertex2f(getX(90),getY(4270));
        glVertex2f(getX(90),getY(4370));
        glVertex2f(getX(110),getY(4370));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(4470));
        glVertex2f(getX(90),getY(4470));
        glVertex2f(getX(90),getY(4570));
        glVertex2f(getX(110),getY(4570));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(4670));
        glVertex2f(getX(90),getY(4670));
        glVertex2f(getX(90),getY(4770));
        glVertex2f(getX(110),getY(4770));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(4870));
        glVertex2f(getX(90),getY(4870));
        glVertex2f(getX(90),getY(4970));
        glVertex2f(getX(110),getY(4970));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(5070));
        glVertex2f(getX(90),getY(5070));
        glVertex2f(getX(90),getY(5170));
        glVertex2f(getX(110),getY(5170));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(5270));
        glVertex2f(getX(90),getY(5270));
        glVertex2f(getX(90),getY(5370));
        glVertex2f(getX(110),getY(5370));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(5470));
        glVertex2f(getX(90),getY(5470));
        glVertex2f(getX(90),getY(5570));
        glVertex2f(getX(110),getY(5570));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(5670));
        glVertex2f(getX(90),getY(5670));
        glVertex2f(getX(90),getY(5770));
        glVertex2f(getX(110),getY(5770));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(5870));
        glVertex2f(getX(90),getY(5870));
        glVertex2f(getX(90),getY(5970));
        glVertex2f(getX(110),getY(5970));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(6070));
        glVertex2f(getX(90),getY(6070));
        glVertex2f(getX(90),getY(6170));
        glVertex2f(getX(110),getY(6170));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(6270));
        glVertex2f(getX(90),getY(6270));
        glVertex2f(getX(90),getY(6370));
        glVertex2f(getX(110),getY(6370));
                //10rd
        glBegin(GL_QUADS);
        glColor3f (1.0, 1.0, 1.0);
        glVertex2f(getX(110),getY(6470));
        glVertex2f(getX(90),getY(6470));
        glVertex2f(getX(90),getY(6570));
        glVertex2f(getX(110),getY(6570));

        glEnd();
        glPopMatrix();

        car();

       if ((transFactor3<-4.4&&dir==0)||(transFactor1<-1.16&&dir==2)||(transFactor2<-1.38&&dir==1))
        {
            StartingText();
            exit(0);
            //glutDisplayFunc(StartingText1);
        //glTranslatef(0,0,-50);
        //glutDisplayFunc(StartingText1);
            //glutCreateWindow("Car Race");
            //glutFullScreen();
            //StartingText();
            //glFlush();
        }
        else
        {
        glPushMatrix();
        glTranslatef(0,transFactor1,0);
        if (transFactor1<-2.0)
        {
            transFactor1=0.0;

        }
        randomobj(-269,200);
        glPopMatrix();


        glPushMatrix();
        glTranslatef(0,transFactor2,0);

        if (transFactor2<-2.0)
        {
            transFactor2=0.0;
        }

        randomobj(169,300);
        glPopMatrix();

        glPushMatrix();
        glTranslatef(0,transFactor3,0);
        if (transFactor3<-5.0)
        {
            transFactor3=0.0;
        }
        randomobj(-50,1500);//starting point define
        glPopMatrix();
        }
        char *cstr = new char[s.length() + 1];
        strcpy(cstr, s.c_str());
        Sprint (-0.45,0.8,cstr);
        glTranslatef(0,0,-20);
        StartingText();
        glTranslatef(0,0,-30);
        StartingText1();

        //glFlush();
        glutPostRedisplay();
        glutSwapBuffers();
    }
    void update(int value)
    {
        transFactor-=0.01f;
        if(transFactor<getY(-4500))
        {

        char *cstr1 = new char[s1.length() + 1];
        strcpy(cstr1, s1.c_str());
        Sprint1 (-0.45,0.7,cstr1);
            stage++;
            ostringstream str2;
            str2<<stage;
            s="Stage: "+str2.str();
            transFactor = -1 * getY(950);
            glutPostRedisplay();
            //glutTimerFunc(5,update,0);
        }
        transFactor1-=0.01f;
        if(transFactor1<getY(-650))
        {
            count1++;
            ostringstream str1;
            str1<<count1;
            s="Count: "+str1.str();

            transFactor1 = 1 * getY(00);
            glutPostRedisplay();
       // glutTimerFunc(30,update,0);
        }
        transFactor2-=0.01f;
        if(transFactor2<getY(-750))
        {
            count1++;
            ostringstream str1;
            str1<<count1;
            s="Count: "+str1.str();
            transFactor2 = 1 * getY(00);
            glutPostRedisplay();
            // glutTimerFunc(30,update,0);
        }
        transFactor3-=0.01f;
        if(transFactor3<getY(-2050))
        {
            count1++;
            ostringstream str1;
            str1<<count1;
            s="Count: "+str1.str();
            transFactor3 = 1 * getY(00);
            glutPostRedisplay();
            // glutTimerFunc(30,update,0);
        }
        glutPostRedisplay();
        glutTimerFunc(40,update,0);
    }
    void myInit(void)
    {
        glClearColor(1.0, 1.0, 1.0, 0.0);
        glMatrixMode(GL_MODELVIEW);
        glLoadIdentity();
        //gluOrtho2D(-400.0, 400.0, -400.0, 400.0);
    }
    void keyboard(unsigned char key, int x, int y)
    {
        //find key codes: https://www.cambiaresearch.com/articles/15/javascript-char-codes-key-codes
        switch (key)
        {

            case  32:
	        glutDestroyWindow(1);
	        glutInitWindowSize(800,800);
            glutCreateWindow("Car Race");
            glutFullScreen();
            glutDisplayFunc(drawScene);
            glutSpecialFunc(specialKeys); //Special Key Handler
            glutKeyboardFunc(keyboard);
            myInit ();
            //PlaySound(TEXT("bird-2.wav"), NULL, SND_ASYNC);
            break;
            case 27:     // ESC key
            exit(0);
            break;
           // case 32;
        }
    }
    int main(int argc, char** argv)
    {
        glutInit(&argc, argv);
        glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB);
        glutInitWindowSize(800,800);
        glutCreateWindow("Car Game");
        glutFullScreen();
        glutKeyboardFunc(keyboard);
        glutReshapeFunc(reshape);
        glutDisplayFunc(drawScene);
        glutSpecialFunc(specialKeys); //Special Key Handler
        glutTimerFunc(20,update,0);
        //PlaySound("NSF.wav", NULL, SND_ASYNC|SND_FILENAME|SND_LOOP);
        myInit ();
        glutMainLoop();
        return 0;
    }
