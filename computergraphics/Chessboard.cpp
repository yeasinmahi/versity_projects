// Arafat Md. Yeasin
// 11-18279-1
// Sec :D

#include<stdio.h>
#include<gl/glut.h>

void myDisplay()
{
	glClear(GL_COLOR_BUFFER_BIT);
	glColor3f(0.0, 0.0, 0.0);
	glPointSize(4.0);
	// Outer BOx
	glBegin(GL_POLYGON);
	glColor3f(0.5, 0.5, 0.5);
	glVertex2i(40, 40);
	glVertex2i(860, 40);
	glVertex2i(860, 660);
	glVertex2i(40, 660);
	glEnd();
	// Black & White 
	int ax, bx, ay = 50, by = 125,sts=0;
	float br = 0, bg = 0, bb = 0, wr = 2, wg = 2, wb = 2;
	for (int i = 0; i < 8; i++)
	{
		ax = 50;
		bx = 150;
		if (sts == 0) //For Changing color Of Black & White
		{
			sts = 1;
		}
		else
			sts = 0;
		for (int j = 0; j < 8; j++)
		{
			glBegin(GL_POLYGON);
			if (sts == 0)
			{
				glColor3f(br, bg, bb);
				sts = 1;
			}
			else
			{
				glColor3f(wr, wg, wb);
				sts = 0;
			}

			glVertex2i(ax, ay);
			glVertex2i(bx, ay);
			glVertex2i(bx, by);
			glVertex2i(ax, by);
			glEnd();
			ax += 100;
			bx += 100;

		}
		ay += 75;
		by += 75;
		
	}
	glFlush();
}
void myInit()
{
	glClearColor(0.6, 0.8, 0.5, 0.0);
	glColor3f(0.0f,0.0f,0.0f);
	glPointSize(5.0);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	gluOrtho2D(0.0, 900.0, 0.0, 700.0);

}
void main(int argc, char** argv)
{
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB);
	glutInitWindowSize(700, 600);
	glutInitWindowPosition(0,0);
	glutCreateWindow("***Chess Board***");
	glutDisplayFunc(myDisplay);
	myInit();
	glutMainLoop();

}