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
import javax.swing.JLabel;
import javax.swing.JTabbedPane;
import javax.swing.JPanel;
import java.awt.GridBagLayout;

public class GUI_ERP {

	 private JFrame frame;
	 
	 WebServiceERP12SoapProxy myProxy = new WebServiceERP12SoapProxy ();
	 private JPanel panel;
	 private JTextField txtFirstName;
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					GUI_ERP window = new GUI_ERP();
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
	public GUI_ERP() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(700, 700, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JButton btnViewFile = new JButton("Add");
		btnViewFile.setBounds(118, 22, 89, 23);
		frame.getContentPane().add(btnViewFile);
		
		final JTextPane txtFileOutput = new JTextPane();
		txtFileOutput.setBounds(10, 182, 241, 68);
		frame.getContentPane().add(txtFileOutput);
		
		JButton btnUpdate = new JButton("Update");
		btnUpdate.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		btnUpdate.setBounds(118, 56, 89, 23);
		frame.getContentPane().add(btnUpdate);
		
		JButton btnDelete = new JButton("Delete");
		btnDelete.setBounds(162, 148, 89, 23);
		frame.getContentPane().add(btnDelete);
		
		JButton btnFind = new JButton("Find");
		btnFind.setBounds(133, 88, 89, 23);
		frame.getContentPane().add(btnFind);
		
		final JComboBox<String> cBoxFiles = new JComboBox<String>();
		
		//List of files from file system
		ArrayList<String>files = new ArrayList<String>(); 
		files.add("Test"); 
		files.add("Top Secret"); 
		for (String value: files) { 
			 cBoxFiles.addItem(value); 
		}
}
}