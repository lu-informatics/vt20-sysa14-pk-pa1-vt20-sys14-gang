package View;

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

import se.lu.ics.grupp2.WebServiceERP12SoapProxy;

import javax.swing.JComboBox;

public class GUI_WS1 {

	private JFrame frame;
	WebServiceERP12SoapProxy myProxy = new WebServiceERP12SoapProxy(); 
	
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					GUI_WS1 window = new GUI_WS1();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public GUI_WS1() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JButton btnViewFile = new JButton("View");
		btnViewFile.setBounds(119, 26, 89, 23);
		frame.getContentPane().add(btnViewFile);
		
		final JTextPane txtFileOutput = new JTextPane();
		txtFileOutput.setBounds(10, 60, 197, 190);
		frame.getContentPane().add(txtFileOutput);
		
		final JComboBox<String> cBoxFiles = new JComboBox<String>();
		
		//List of files from file system
		ArrayList<String>files = new ArrayList<String>(); 
		files.add("Test"); 
		files.add("HelloWorld"); 
		for (String value: files) { 
			 cBoxFiles.addItem(value); 
		}
		 
		frame.getContentPane().add(cBoxFiles);
		cBoxFiles.setBounds(10, 26, 111, 23); 
		
		// method for viewing a chosen file 
		btnViewFile.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
						String chosenFile = cBoxFiles.getSelectedItem().toString() + ".txt"; 
						String fileOutput = myProxy.showFile(chosenFile); 
						
						txtFileOutput.setText(fileOutput);
					} catch (RemoteException e1) {
						txtFileOutput.setText("ojsan");
						e1.printStackTrace();
					} 
				
				
				
				
			}
		});
		
		
	}
}
