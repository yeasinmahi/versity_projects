import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class MyLoginForm extends JFrame implements ActionListener{
    
    JLabel nameLabel, passLabel;
    JTextField nameText;
    JPasswordField passText;
    JButton loginButton, exitButton;
    
    
    MyLoginForm(){
        // Get the Content Pane Reference
        Container container = getContentPane();
        // Define Layout Manager
        FlowLayout flow = new FlowLayout();
        container.setLayout(flow);
        
        // Create Components
        nameLabel = new JLabel("User Name");
        container.add(nameLabel);
        nameText = new JTextField(10);
        container.add(nameText);
        passLabel = new JLabel("Password");
        container.add(passLabel);
        passText = new JPasswordField(10);
        container.add(passText);
        
        loginButton = new JButton("LOGIN");
        exitButton = new JButton("EXIT");
        // Register Action Listener
        loginButton.addActionListener(this);
        exitButton.addActionListener(this);
        // Add Components
        container.add(loginButton);
        container.add(exitButton);
        
        setSize(250,250);
        setVisible(true);
        setTitle("USER LOGIN");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        
    }
    // Action Handling
    public void actionPerformed(ActionEvent event){
        if(event.getActionCommand().equals("LOGIN")){
            String n = nameText.getText();
            String p = passText.getText();
            if(n.equals("admin") && p.equals("1234")){
               JOptionPane.showMessageDialog(getContentPane(),"LOGIN SUCCESSFUL"); 
            }else{
               JOptionPane.showMessageDialog(getContentPane(),"LOGIN FAILED"); 
                
            }
            
            
        }
        if(event.getActionCommand().equals("EXIT")){
            System.out.println("EXIT");
        }
    }
    
    
    public static void main(String args[]){
        MyLoginForm mf = new MyLoginForm();
        
    }
}