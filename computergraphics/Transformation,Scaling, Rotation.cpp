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
	scanf("%f", &dix);
	printf("Enter Disparate Y= ");
	scanf("%f", &diy);

	glBegin(GL_POLYGON);
	glColor3f(1.f, 0.2f, 0.2f);
	glVertex2f(ax, ay);
	glVertex2f(bx, by);
	glVertex2f(cx, cy);
	glVertex2f(dx, dy);
	glEnd();
	
	glBegin(GL_POLYGON);
	glColor3f(0.2f, 1.0f, 0.2f);
	glVertex2f(ax + dix, ay + diy);
	glVertex2f(bx + dix, by + diy);
	glVertex2f(cx + dix, cy + diy);
	glVertex2f(dx + dix, dy + diy);
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
	float ext = 200;
	glBegin(GL_POLYGON);
	glColor3f(0.2f, 1.0f, 0.2f);
	glVertex2f(ax + ext, ay);
	glVertex2f(bx + ext, by);
	glVertex2f(cx + ext, cy);
	glVertex2f(dx + ext, dy);
	glEnd();
	glFlush();

	float sx, sy;
	printf("Enter Scaling X= ");
	scanf("%f", &sx);
	printf("Enter Scaling Y= ");
	scanf("%f", &sy);

	glClear(GL_COLOR_BUFFER_BIT);
	glColor3f(0.0, 0.0, 0.0);
	glBegin(GL_POLYGON);
	glColor3f(1.f, 0.2f, 0.2f);
	glVertex2f(ax, ay);
	glVertex2f(bx, by);
	glVertex2f(cx, cy);
	glVertex2f(dx, dy);
	glEnd();

	glBegin(GL_POLYGON);
	glColor3f(0.2f, 1.0f, 0.2f);
	glVertex2f(ax + ext, ay);
	glVertex2f((bx - ax)*sx + ax + ext, (by - ay)*sy + ay);
	glVertex2f((cx - ax)*sx + ax + ext, (cy - ay)*sy + ay);
	glVertex2f((dx - ax)*sx + ax + ext, (dy - ay)*sy + ay);
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
	float aax,abx,acx,adx,aay,aby,acy,ady;
	printf("\n Rotation angel= ");
	scanf("%f", &an);
	an *= (float)0.01744;
	aax = (ax* cos(an)) - (ay* sin(an));
	abx = (bx* cos(an)) - (by* sin(an));
	acx = (cx* cos(an)) - (cy* sin(an));
	adx = (dx* cos(an)) - (dy* sin(an));
	aay = (ax* sin(an)) + (ay* cos(an));
	aby = (bx* sin(an)) + (by* cos(an));
	acy = (cx* sin(an)) + (cy* cos(an));
	ady = (dx* sin(an)) + (dy* cos(an));

	float addx = 220, addy = 0;
	glBegin(GL_POLYGON);
	glColor3f(0.2f, 1.0f, 0.2f);
	glVertex2f(aax + addx, aay + addy);
	glVertex2f(abx + addx, aby + addy);
	glVertex2f(acx + addx, acy + addy);
	glVertex2f(adx + addx, ady + addy);
	glEnd();
	glFlush();
}

void myDisplay()
{
	glClear(GL_COLOR_BUFFER_BIT);
	glColor3f(0.0, 0.0, 0.0);
	int select;
L1:	printf("Rectan Selection\n\t 1.Auto\n\t 2.Manual\n");
	scanf("%d", &select);
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
		scanf("%f", &ax);
		printf("\tY= ");
		scanf("%f", &ay);
		printf("2nd Co-Ordinator \n\tX= ");
		scanf("%f", &bx);
		printf("\tY= ");
		scanf("%f", &by);
		printf("3rd Co-Ordinator \n\tX= ");
		scanf("%f", &cx);
		printf("\tY= ");
		scanf("%f", &cy);;
		printf("4th Co-Ordinator \n\tX= ");
		scanf("%f", &dx);
		printf("\tY= ");
		scanf("%f", &dy);
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
	scanf("%d", &choose);
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
