import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.event.*;


class Overs extends JFrame implements ItemListener{
	private JComboBox combo;
	
	final String sList[]={"1","2","3","4","5"};
	
	public Overs(){
		setTitle("Overs");
		setSize(300,110);
		setBackground(Color.blue);
		getContentPane().setLayout(new BorderLayout());
		
		
		JPanel topPanel=new JPanel();
		topPanel.setLayout(null);
		getContentPane().add(topPanel,BorderLayout.CENTER);
		
		
		combo=new JComboBox();
		combo.setBounds(20,35,260,20);
		topPanel.add(combo);
		
		for(int i=0;i<sList.length;i++)
		combo.addItem(sList[i]);
		
		combo.setVisible(true);
		combo.addItemListener(this);
		
		}
		
	public void itemStateChanged(ItemEvent event){
		String string="";
	if( event.getSource() == combo && event.getStateChange() == ItemEvent.SELECTED )
		{
			string= "over selected: "+combo.getSelectedItem();
			}
		JOptionPane.showMessageDialog(null,string);
		}
		public static void main( String args[] )
	{
		
		Overs mainFrame	= new Overs();
		mainFrame.setVisible( true );
	}
	
	
	
	}