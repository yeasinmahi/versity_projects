import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import java.awt.event.ActionListener;


public class PlayerName extends JFrame{
	private JTextField textField1,textField2;
	
	public PlayerName(){
		super("Playe Name");
		
		Container container = getContentPane();
		container.setLayout(new FlowLayout());
		
		JTextField textField1= new JTextField("Player Name:",10);
		textField1.setEditable(false);
		container.add(textField1);
		
		JTextField textField2= new JTextField("Enter your name here");
		container.add(textField2);
		
		
		PlayerNamehandler handler= new PlayerNamehandler();
		textField1.addActionListener(handler);
		textField2.addActionListener(handler);
		
		setSize(400,100);
		setVisible(true);
		
		}
	public static void main(String Args[]){
		PlayerName application= new PlayerName();
		application.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		}
	public class PlayerNamehandler implements ActionListener{
		public void actionPerformed(ActionEvent event){
			String string="";
			
			if(event.getSource()==textField1){
				string="textField1"+event.getActionCommand();
				}
			else if(event.getSource()==textField2){
				string="Player Name:"+ event.getActionCommand();
				}
		JOptionPane.showMessageDialog(null,string);
			}
		}
	
	}