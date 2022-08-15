//Arafat, Md. Yeasin
// 11-18279-1
//Sec :D

// Note: Here Scalling Equation is by own created. This scalling percentage of multification of 2,3 is exectly will be 2,3 pesentage of privious axis.


#include<stdio.h>
#include<math.h>
#include<gl/glut.h>
float ax, bx, cx, dx, ay, by, cy, dy;

void transform()
{
	glClear(GL_COLOR_BUFFER_BIT);
	glColor3f(0.0, 0.0, 0.0);

	float dix, diy;
	printf("Enter Disparate X= ");
	scanf_s("%f", &dix);
	printf("Enter Disparate Y= ");
	scanf_s("%f", &diy);

	glBegin(GL_POLYGON);
	glColor3f(1.f, 0.2f, 0.2f);
	glVertex2f(ax, ay);
	glVertex2f(bx, by);
	glVertex2f(cx, cy);
	glVertex2f(dx, dy);
	glEnd();
	ax += dix;
	bx += dix;
	cx += dix;
	dx += dix;
	ay += diy;
	by += diy;
	cy += diy;
	dy += diy;
	glBegin(GL_POLYGON);
	glColor3f(0.2f, 1.0f, 0.2f);
	glVertex2f(ax, ay);
	glVertex2f(bx, by);
	glVertex2f(cx, cy);
	glVertex2f(dx, dy);
	glEnd();

	glFlush();

}
void scaling()
{
	glClear(GL_COLOR_BUFFER_BIT);
	glColor3f(0.0, 0.0, 0.0);

	glBegin(GL_POLYGON);
	glColor3f(1.f, 0.2f, 0.2f);
	glVertex2f(ax, ay);
	glVertex2f(bx, by);
	glVertex2f(cx, cy);
	glVertex2f(dx, dy);
	glEnd();

	float sx, sy;
	printf("Enter Scaling X= ");
	scanf_s("%f", &sx);
	printf("Enter Scaling Y= ");
	scanf_s("%f", &sy);

	bx = (bx - ax)*sx + ax;
	cx = (cx - ax)*sx + ax;
	dx = (dx - ax)*sx + ax;
	by = (by - ay)*sy + ay;
	cy = (cy - ay)*sy + ay;
	dy = (dy - ay)*sy + ay;

	
	glBegin(GL_POLYGON);
	glColor3f(0.2f, 1.0f, 0.2f);
	glVertex2f(ax, ay);
	glVertex2f(bx, by);
	glVertex2f(cx, cy);
	glVertex2f(dx, dy);
	glEnd();
	glFlush();

}
void rotate()
{
	glClear(GL_COLOR_BUFFER_BIT);
	glColor3f(0.0, 0.0, 0.0);

	glBegin(GL_POLYGON);
	glColor3f(1.f, 0.2f, 0.2f);
	glVertex2f(ax, ay);
	glVertex2f(bx, by);
	glVertex2f(cx, cy);
	glVertex2f(dx, dy);
	glEnd();

	float an;
	printf("\n Rotation angel= ");
	scanf_s("%f", &an);
	an *= (float)0.01744;
	ax = (ax* cos(an)) - (ay* sin(an));
	bx = (bx* cos(an)) - (by* sin(an));
	cx = (cx* cos(an)) - (cy* sin(an));
	dx = (dx* cos(an)) - (dy* sin(an));
	ay = (ax* sin(an)) + (ay* cos(an));
	by = (bx* sin(an)) + (by* cos(an));
	cy = (cx* sin(an)) + (cy* cos(an));
	dy = (dx* sin(an)) + (dy* cos(an));

	float addx = 220, addy = 0;
	glBegin(GL_POLYGON);
	glColor3f(0.2f, 1.0f, 0.2f);
	glVertex2f(ax, ay);
	glVertex2f(bx, by);
	glVertex2f(cx, cy);
	glVertex2f(dx, dy);
	glEnd();
	glFlush();
}

void myDisplay()
{
	glClear(GL_COLOR_BUFFER_BIT);
	glColor3f(0.0, 0.0, 0.0);
	int select;
L1:	printf("Rectan Selection\n\t 1.Auto\n\t 2.Manual\n");
	scanf_s("%d", &select);
	switch (select)
	{
	case 1:  // Default Given Rectangle
		ax = 10;
		bx = 110;
		cx = 110;
		dx = 10;
		ay = 10;
		by = 10;
		cy = 110;
		dy = 110;
		break;
	case 2: // manual co- ordinate input.
		printf("Enter Your 4 Co-Ordinator Of A Ractan");
		printf("1st Co-Ordinator \n\tX= ");
		scanf_s("%f", &ax);
		printf("\tY= ");
		scanf_s("%f", &ay);
		printf("2nd Co-Ordinator \n\tX= ");
		scanf_s("%f", &bx);
		printf("\tY= ");
		scanf_s("%f", &by);
		printf("3rd Co-Ordinator \n\tX= ");
		scanf_s("%f", &cx);
		printf("\tY= ");
		scanf_s("%f", &cy);;
		printf("4th Co-Ordinator \n\tX= ");
		scanf_s("%f", &dx);
		printf("\tY= ");
		scanf_s("%f", &dy);
		break;
	default:
		printf("\t\t\t!!! Select Correct One");
		goto L1;
		break;
	}
	glBegin(GL_POLYGON);
	glColor3f(1.f, 0.2f, 0.2f);
	glVertex2f(ax, ay);
	glVertex2f(bx, by);
	glVertex2f(cx, cy);
	glVertex2f(dx, dy);
	glEnd();
	glFlush();

	printf("Select Which You Want To do Your Design");
L2:	printf("\n\t 1.Transformation\n\t 2.scalling\n\t 3.Rotate\n\t 4.Exit\n\n");
	int choose;
	scanf_s("%d", &choose);
	switch (choose)
	{
	case 1: transform();
		goto L2;
	case 2: scaling();
		goto L2;
	case 3: rotate();
		goto L2;
	case 4:
		break;
	default:
		printf("Choose Correct menu");
		goto L2;
	}

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
	glutCreateWindow("***Transformation***");
	glutDisplayFunc(myDisplay);
	myInit();
	glutMainLoop();

}
