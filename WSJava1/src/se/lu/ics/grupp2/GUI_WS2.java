package se.lu.ics.grupp2;

import java.awt.EventQueue;
import javax.swing.JFrame;
import java.awt.GridLayout;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;
import java.util.ArrayList;
import java.awt.event.ActionEvent;
import javax.swing.JTextArea;
import java.awt.FlowLayout;
import javax.swing.JTextField;
import javax.swing.JTextPane;
import javax.swing.JComboBox;

public class GUI_WS2 {

	private JFrame frame;
	SqlWebServiceSoapProxy myProxy = new SqlWebServiceSoapProxy(); 
	
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					GUI_WS2 window = new GUI_WS2();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 * @throws RemoteException 
	 */
	public GUI_WS2() throws RemoteException {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 * @throws RemoteException 
	 */
	private void initialize() throws RemoteException {
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JButton btnViewFile = new JButton("View");
		btnViewFile.setBounds(289, 26, 89, 23);
		frame.getContentPane().add(btnViewFile);
		
		final JTextPane txtOutput = new JTextPane();
		txtOutput.setBounds(10, 60, 360, 190);
		frame.getContentPane().add(txtOutput);
		
		final JComboBox<String> cBoxFiles = new JComboBox<String>();
		ArrayList<String>files = new ArrayList<String>(); 
		files.add("Storage"); 
		files.add("Tenant"); 
		for (String value: files) { 
			 cBoxFiles.addItem(value); 
		}
		myProxy.getListOfStorages();
		
		//for each loop that populates cBox with up to date from database 
		/*
		for (Storage s : myProxy.getListOfStorages()) { 
			 cBoxFiles.addItem(s.toString()); 
		}
		*/
		 
		frame.getContentPane().add(cBoxFiles);
		cBoxFiles.setBounds(10, 26, 281, 23); 
		// method for viewing a chosen file 
		btnViewFile.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				txtOutput.setText(""); 
				String chosenList = cBoxFiles.getSelectedItem().toString(); 
				if (chosenList.contentEquals("Storage")){ 
					try {
						txtOutput.setText(myProxy.getListOfStorages().toString());
					} catch (RemoteException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
						txtOutput.setText("Failed to get list of storages");
					}
					
				}			
			}
		});
		
		
	}

	private void fillComboBox() {
		// TODO Auto-generated method stub
		
	}
}