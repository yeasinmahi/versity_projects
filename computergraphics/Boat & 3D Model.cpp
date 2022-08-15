//Arafat, Md. Yeasin
// 11-18279-1
//Sec :D
#include <stdio.h>
#include <math.h>
#include <GL/glut.h>
void DrawCircle(float cx, float cy, float r, int num_segments)
{
	glBegin(GL_POLYGON);
	glColor3f(0.5f, 0.5f, 0.5f);
	for (int ii = 0; ii < num_segments; ii++)
	{
		float theta = 2.0f * 3.1415926f * float(ii) / float(num_segments);//get the current angle 

		float x = r * cosf(theta);//calculate the x component 
		float y = r * sinf(theta);//calculate the y component 

		glVertex2f(x + cx, y + cy);//output vertex 

	}
	glEnd();
}
void myDisplay(void)
{
	glClear(GL_COLOR_BUFFER_BIT);
	glColor3f(0.3, 0.7, 0.2);
	glPointSize(4.0);
	//Full Box
	glBegin(GL_POLYGON);
	glColor3f(0.8f, 0.7f, 0.3f);
	glVertex2i(10, 50);
	glVertex2i(600, 50);
	glVertex2i(600, 600);
	glVertex2i(10, 600);
	glEnd();
	// Half Box
	glBegin(GL_POLYGON);
	glColor3f(0.5f, 0.5f, 0.5f);
	glVertex2i(10, 180);
	glVertex2i(600, 180);
	glVertex2i(600, 600);
	glVertex2i(10, 600);
	glEnd();
	// Line Of Flag
	glBegin(GL_LINES);
	glColor3f(0.0, 0.0, 0.0);
	glVertex2i(100, 250);
	glVertex2i(100, 450);
	glEnd();
	// Red Of Flag
	glBegin(GL_QUADS);
	glColor3f(1.0f, 0.0f, 0.0f);
	glVertex2i(100, 450);
	glVertex2i(20, 450);
	glVertex2i(20, 420);
	glVertex2i(100, 420);
	glEnd();
	// White Of Box
	glBegin(GL_QUADS);
	glColor3f(2.0f, 2.0f, 2.0f);
	glVertex2i(100, 420);
	glVertex2i(20, 420);
	glVertex2i(20, 390);
	glVertex2i(100, 390);
	glEnd();
	// Boat 
	glBegin(GL_POLYGON);
	glColor3f(1.0f, 0.0f, 0.0f);
	glVertex2i(40, 250);
	glVertex2i(120, 150);
	glVertex2i(500, 150);
	glVertex2i(580, 250);
	glEnd();
	// house of boat
	glBegin(GL_POLYGON);
	glColor3f(0.0f, 1.0f, 0.0f);
	glVertex2i(120, 250);
	glVertex2i(500, 250);
	glVertex2i(500, 400);
	glVertex2i(120, 400);
	glEnd();
	// Blue sqr
	glBegin(GL_POLYGON);
	glColor3f(0.0f, 0.0f, 1.0f);
	glVertex2i(400, 400);
	glVertex2i(450, 400);
	glVertex2i(450, 550);
	glVertex2i(400, 550);
	glEnd();
	DrawCircle(180, 325, 30, 10000);
	DrawCircle(310, 325, 30, 10000);
	DrawCircle(440, 325, 30, 10000);

	//***2nd drow***
	//1st Green Box
	glBegin(GL_POLYGON);
	glColor3f(0.0f, 1.0f, 0.0f);
	glVertex2i(1110, 500);
	glVertex2i(1200, 530);
	glVertex2i(1200, 400);
	glVertex2i(1110, 370);
	glEnd();
	//1st Blue Box
	glBegin(GL_POLYGON);
	glColor3f(0.0f, 0.0f, 1.0f);
	glVertex2i(1110, 500);
	glVertex2i(1030, 550);
	glVertex2i(1030, 420);
	glVertex2i(1110, 370);
	glEnd();
	//1st Red Box
	glBegin(GL_POLYGON);
	glColor3f(1.0f, 0.0f, 0.0f);
	glVertex2i(1110, 500);
	glVertex2i(1030, 550);
	glVertex2i(1070, 560);
	glVertex2i(1150, 550);
	glVertex2i(1170, 560);
	glVertex2i(1200, 530);
	glEnd();
	//1st Blue Box
	glBegin(GL_POLYGON);
	glColor3f(0.0f, 1.0f, 0.0f);
	glVertex2i(900, 450);
	glVertex2i(900, 360);
	glVertex2i(1000, 330);
	glVertex2i(1000, 420);
	glEnd();
	//1st Blue Box
	glBegin(GL_POLYGON);
	glColor3f(0.0f, 0.0f, 1.0f);
	glVertex2i(1000, 330);
	glVertex2i(1000, 420);
	glVertex2i(1040, 450);
	glVertex2i(1040, 360);
	glEnd();
	//1st Blue Box
	glBegin(GL_POLYGON);
	glColor3f(0.0f, 1.0f, 0.0f);
	glVertex2i(1040, 450);
	glVertex2i(1080, 420);
	glVertex2i(1080, 330);
	glVertex2i(1040, 360);
	glEnd();
	glFlush();
}

void myInit(void)
{
	glClearColor(2.0, 2.0, 2.0, 0.0);
	glColor3f(0.0f, 0.0f, 0.0f);
	glPointSize(4.0);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	gluOrtho2D(0.0, 1300.0, 0.0, 700.0);
}

void main(int argc, char** argv)
{
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB);
	glutInitWindowSize(1000, 600);
	glutInitWindowPosition(0, 0);
	glutCreateWindow("my first attempt");
	glutDisplayFunc(myDisplay);
	myInit();
	glutMainLoop();
}
