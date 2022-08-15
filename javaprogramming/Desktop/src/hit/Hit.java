package hit;

/**
 *
 * @author Mousum
 */

import java.awt.FlowLayout;
import java.awt.event.*;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JFrame;
import javax.swing.JButton;
import javax.swing.ImageIcon;
import javax.swing.Icon;
import javax.swing.JOptionPane;
import javax.swing.*;
import java.util.Random;

public class Hit extends JFrame{
    private JButton hit;
    private JTextField textField;
    static int totalRun=0,wicket=0;
    
    public Hit(){
             super("Virtual Cricket");
             setDefaultCloseOperation(EXIT_ON_CLOSE);
             setLocation(500,300);
             getContentPane().setLayout(new FlowLayout());
             
             textField=new JTextField(10);
             textField.setEditable(false);
             getContentPane().add(textField);
             Icon pre= new ImageIcon(getClass().getResource("pre.jpg"));
	     Icon post= new ImageIcon(getClass().getResource("post.jpg"));
             
             hit= new JButton("Hit!!",pre);
             hit.setRolloverIcon(post);
             hit.addActionListener(new ActionListener() {
                 @Override
                public void actionPerformed(ActionEvent e) {
                         int takeValue;
			 String string[]={"0.jpg","1.gif","2.gif","3.gif","4.gif","5.jpg","6.gif","LBW.jpg","Catch Out.jpg","Run Out.jpg","Bowld.jpg"};
                         Icon icons[]=new Icon[string.length];
                         for(int i=0;i<string.length;i++){
			 icons[i]=new ImageIcon(getClass().getResource(string[i]));
                                 }
			 Random r= new Random();
			 takeValue=r.nextInt(string.length);
			 JOptionPane.showMessageDialog(null,icons[takeValue]);
				if(takeValue>6){
					 wicket++;
				}
			         else{ 
				 totalRun= totalRun+takeValue;
					
				}
			  textField.setText("Score:" +totalRun+"/"+wicket);
				}	
			});
                       getContentPane().add(hit);
    }
    
    

    
    public static void main(String[] args) {
        Hit window = new Hit();
		window.pack();
		window.show();
               window.setSize(500,300);
                window.setVisible(true);
    }
}
