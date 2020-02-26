package ProgAssigment.ics;

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

public class GUI {

	private JFrame frame;
	ProgAssWebServiceSoapProxy myProxy = new ProgAssWebServiceSoapProxy(); 
	
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					GUI window = new GUI();
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
	public GUI() {
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
		//Lista med valbara filer att visa
		ArrayList<String>files = new ArrayList<String>(); 
		files.add("Test"); 
		files.add("Top Secret"); 
		for (String value: files) { 
			 cBoxFiles.addItem(value); 
		}
		 
		frame.getContentPane().add(cBoxFiles);
		cBoxFiles.setBounds(10, 26, 111, 23); 
		// method for viewing a chosen file 
		btnViewFile.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
						String chosenFile = cBoxFiles.getSelectedItem().toString(); 
						String fileOutput = myProxy.showFile(chosenFile); 
						; 
						txtFileOutput.setText(fileOutput);
					} catch (RemoteException e1) {
						e1.printStackTrace();
					} 
				
				
				
				
			}
		});
		
		
	}
}
