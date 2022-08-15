// Arafat Md. Yeasin
// 11-18279-1
// Sec :D
#include <stdio.h>
#include <math.h>
#include <GL/glut.h>

void myDisplay(void)
{
	glClear(GL_COLOR_BUFFER_BIT);
	glColor3f(1.0, 0.0, 0.0);
	//Rectangle
	glBegin(GL_POLYGON);
	glVertex2i(-300,-100);
	glVertex2i(0,-100);
	glVertex2i(0,200);
	glVertex2i(-300,200);
	glEnd();
	// Triangle
	glColor3f(0.0, 1.0, 0.0);
	glBegin(GL_POLYGON);
	glVertex2i(100, -100);
	glVertex2i(400, -100);
	glVertex2i(250, 200);
	glEnd();
	glFlush();
}
void myInit()
{
	glClearColor(0.5, 0.5, 0.5, 0.0);
	glColor3f(0.0f, 0.0f, 0.0f);
	glPointSize(5.0);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	gluOrtho2D(-680, 680, -380, 380);

}
void main(int argc, char** argv)
{
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB);
	glutInitWindowSize(700, 400);
	glutInitWindowPosition(600, 50);
	glutCreateWindow("***First Lab***");
	glutDisplayFunc(myDisplay);
	myInit();
	glutMainLoop();

}
