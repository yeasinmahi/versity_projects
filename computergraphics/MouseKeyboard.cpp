// Arafat Md. Yeasin
// 11-18279-1
// Sec :D

#include<stdio.h>
#include<gl/glut.h>

static GLfloat spin = 0.0; 
static GLfloat spin_speed = 0.5; 
float spin_x = 0; 
float spin_y = 1; 
float spin_z = 0; 
 
float translate_x = 0.0; 
float translate_y = 0.0; 
float translate_z = -30.0; 
 
static GLfloat spin1 = 0.0; 
static GLfloat spin_speed1 = 0.5; 
float spin_x1 = 0; 
float spin_y1 = 1; 
float spin_z1 = 0; 
 
float translate_x1 = 0.0; 
float translate_y1 = 0.0; 
float translate_z1 = -30.0;

static int item;

void init() 
{ 
  glClearColor(0,0,0,0);    
  glShadeModel(GL_SMOOTH);  
  glClearDepth(1.0f);		
  glEnable(GL_DEPTH_TEST);
} 
 
 
void setSpin(float x, float y, float z) 
{ 
  spin_x = x; 
  spin_y = y; 
  spin_z = z; 
} 
 
void setSpin1(float x, float y, float z) 
{ 
  spin_x1 = x; 
  spin_y1= y; 
  spin_z1 = z; 
} 

void reset() 
{ 
  spin_x = 0; 
  spin_y = 1; 
  spin_z = 0; 
  translate_x = 0.0; 
  translate_y = 0.0; 
  translate_z = -30.0; 
} 
 

 void reshape(int w,int h) 
{ 
  glViewport(0,0, (GLsizei)w,(GLsizei)h); 
  glMatrixMode(GL_PROJECTION); 
  glLoadIdentity(); 
  gluPerspective(100.0f, (GLfloat)w/(GLfloat)h, 1.0f, 100.0f); 
  glMatrixMode(GL_MODELVIEW); 
  glLoadIdentity(); 
} 

void myDisplay() 
{ 
  glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);   

  //Square
	glLoadIdentity(); 
    glTranslatef(translate_x, translate_y, translate_z); 
    glRotatef(spin,spin_x,spin_y,spin_z);
    glColor3f(1.0f, 0.0f, 0.0f);
    glBegin(GL_POLYGON);
	glVertex3f(2, 2, 0);
	glVertex3f(2, 18, 0);
    glVertex3f(18, 18, 0);
    glVertex3f(18, 2, 0);
    glEnd();
 
	//Triangle
  glLoadIdentity();
  glTranslatef(translate_x1, translate_y1, translate_z1); 
  glRotatef(spin1,spin_x1,spin_y1,spin_z1); 
  glColor3f(0.0f, 1.0f, 0.0f);
  glBegin(GL_POLYGON);
  glVertex3f(-2, 2, 0);
  glVertex3f(-8, 2, 0);
  glVertex3f(-5, 8, 0);
  glEnd();

  
  glutSwapBuffers();  
} 
 
void spinDisplay(void) 
{ 
  spin=spin+spin_speed; 
  if(spin>360.0) 
  { 
    spin=spin-360.0; 
  } 
  glutPostRedisplay(); 
} 
 
void spinDisplayReverse(void) 
{ 
  spin=spin-spin_speed; 
  if(spin<360.0) 
  { 
    spin=spin+360.0; 
  } 
  glutPostRedisplay(); 
} 

void spinDisplay1(void) 
{ 
  spin1=spin1+spin_speed1; 
  if(spin1>360.0) 
  { 
    spin1=spin1-360.0; 
  } 
  glutPostRedisplay(); 
} 
 
void spinDisplayReverse1(void) 
{ 
  spin1=spin1-spin_speed1; 
  if(spin1<360.0) 
  { 
    spin1=spin1+360.0; 
  } 
  glutPostRedisplay(); 
} 
 
void mouse(int button,int state,int x,int y) 
{ 
  switch(button) 
  { 
  case GLUT_LEFT_BUTTON:
		      if(state==GLUT_DOWN){ 
				  if(item==0){
						 glutIdleFunc(spinDisplay);
				  }else if (item==1){
						 glutIdleFunc(spinDisplay1);
				  }
			  }
    break; 
    case GLUT_MIDDLE_BUTTON: 
      if(state==GLUT_DOWN) 
      { if(item==0){
        glutIdleFunc(NULL); 
	  }else if(item==1){
        glutIdleFunc(NULL);
	  }
      } 
    break; 
    case GLUT_RIGHT_BUTTON: 
      if(state==GLUT_DOWN){
		  if(item==0){
        glutIdleFunc(spinDisplayReverse);
		  }else if(item==1){
        glutIdleFunc(spinDisplayReverse1);
	  }
	  }
    break; 
     
    default: 
    break; 
  } 
} 
 
void keyboard(unsigned char key, int x, int y) 
{ 
  //spin
  if(key=='x') 
  { 
	  if(item==0){
     setSpin(1.0,0.0,0.0); 
     glutPostRedisplay();
	  }else if(item==1){
     setSpin1(1.0,0.0,0.0); 
     glutPostRedisplay();
	  }
  } 
  else if(key=='y') 
  { 
	 if(item==0){
     setSpin(0.0,1.0,0.0); 
     glutPostRedisplay(); 
	 }else if(item==1){
     setSpin1(0.0,1.0,0.0); 
     glutPostRedisplay(); 
	 }
  } 
  else if(key=='z') 
  { 
    if(item==0){
     setSpin(0.0,0.0,1.0); 
     glutPostRedisplay(); 
	 }else if(item==1){
     setSpin1(0.0,0.0,1.0); 
     glutPostRedisplay(); 
	 }
  } 
  else if(key=='a') 
  { 
    if(item==0){
     setSpin(1.0,1.0,1.0); 
     glutPostRedisplay(); 
	 }else if(item==1){
     setSpin1(1.0,1.0,1.0); 
     glutPostRedisplay(); 
	 }
  } 
  //spin  
 
  //zoom   
  else if(key=='+') 
  { 
	  if(item==0){    
    translate_z++; 
    glutPostRedisplay();
  }else if(item==1){    
    translate_z++; 
    glutPostRedisplay();
  }
  }   
    else if(key=='-') 
  {     
     if(item==0){    
    translate_z--; 
    glutPostRedisplay();
  }else if(item==1){    
    translate_z--; 
    glutPostRedisplay();
  }
  } 
  //zoom
 
  //reset
  else if(key=='r') 
  { 
    reset(); 
    glutPostRedisplay();   
  } 

	else if(key=='0') 
  { 
    item=0;
    glutPostRedisplay();   
  } 
  else if(key=='1') 
  { 
    item=1;
    glutPostRedisplay();   
  } 
  //reset
} 

int main(int argc, char** argv)
{
	glutInit(&argc,argv);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB);
	glutInitWindowSize(500,500);
	glutInitWindowPosition(100,100);
	glutCreateWindow(argv[0]);
	init();
	glutDisplayFunc(myDisplay);
    glutReshapeFunc(reshape);
	glutMouseFunc(mouse);
	glutKeyboardFunc(keyboard);
	glutMainLoop();
	return 0;
}