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

import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JTabbedPane;
import javax.swing.JPanel;
import java.awt.GridBagLayout;

public class GUI {

	 private JFrame frame;
	 
	 //WebServiceERP12SoapProxy myProxy = new WebServiceERP12SoapProxy ();
	 private JPanel panel;
	 private JTextField txtFirstName;
	 private JTextField textField;
	 private JTextField textField_1;
	 private JTextField textField_2;
	 private JTextField textField_3;
	 private JTextField textField_4;
	 private JTextField textField_5;
	 private JTextField textField_6;
	 private JTextField textField_7;
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
		frame.setBounds(700, 700, 696, 448);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JButton btnViewFile = new JButton("Add");
		btnViewFile.setBounds(196, 180, 89, 23);
		frame.getContentPane().add(btnViewFile);
		
		final JTextPane txtFileOutput = new JTextPane();
		txtFileOutput.setBounds(10, 330, 275, 68);
		frame.getContentPane().add(txtFileOutput);
		
		JButton btnUpdate = new JButton("Update");
		btnUpdate.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		btnUpdate.setBounds(196, 207, 89, 23);
		frame.getContentPane().add(btnUpdate);
		
		JButton btnDelete = new JButton("Delete");
		btnDelete.setBounds(196, 302, 89, 23);
		frame.getContentPane().add(btnDelete);
		
		JButton btnFind = new JButton("Find");
		btnFind.setBounds(196, 275, 89, 23);
		frame.getContentPane().add(btnFind);
		
		textField = new JTextField();
		textField.setBounds(10, 68, 86, 20);
		frame.getContentPane().add(textField);
		textField.setColumns(10);
		
		textField_1 = new JTextField();
		textField_1.setColumns(10);
		textField_1.setBounds(100, 68, 86, 20);
		frame.getContentPane().add(textField_1);
		
		textField_2 = new JTextField();
		textField_2.setColumns(10);
		textField_2.setBounds(10, 111, 86, 20);
		frame.getContentPane().add(textField_2);
		
		textField_3 = new JTextField();
		textField_3.setColumns(10);
		textField_3.setBounds(100, 111, 86, 20);
		frame.getContentPane().add(textField_3);
		
		textField_4 = new JTextField();
		textField_4.setColumns(10);
		textField_4.setBounds(10, 159, 86, 20);
		frame.getContentPane().add(textField_4);
		
		textField_5 = new JTextField();
		textField_5.setColumns(10);
		textField_5.setBounds(100, 159, 86, 20);
		frame.getContentPane().add(textField_5);
		
		textField_6 = new JTextField();
		textField_6.setColumns(10);
		textField_6.setBounds(10, 208, 86, 20);
		frame.getContentPane().add(textField_6);
		
		textField_7 = new JTextField();
		textField_7.setColumns(10);
		textField_7.setBounds(100, 208, 86, 20);
		frame.getContentPane().add(textField_7);
		
		JLabel lblNewLabel = new JLabel("First name");
		lblNewLabel.setBounds(10, 53, 62, 14);
		frame.getContentPane().add(lblNewLabel);
		
		JLabel lblLastName = new JLabel("Last name");
		lblLastName.setBounds(100, 53, 62, 14);
		frame.getContentPane().add(lblLastName);
		
		JLabel lblSsn = new JLabel("Ssn");
		lblSsn.setBounds(10, 99, 62, 14);
		frame.getContentPane().add(lblSsn);
		
		JLabel lblAddress = new JLabel("Address");
		lblAddress.setBounds(100, 99, 62, 14);
		frame.getContentPane().add(lblAddress);
		
		JLabel lblJobTitle = new JLabel("Job title");
		lblJobTitle.setBounds(10, 142, 62, 14);
		frame.getContentPane().add(lblJobTitle);
		
		JLabel lblEmployeeName = new JLabel("Employee name");
		lblEmployeeName.setBounds(100, 142, 62, 14);
		frame.getContentPane().add(lblEmployeeName);
		
		JLabel lblPhoneNumber = new JLabel("Phone number");
		lblPhoneNumber.setBounds(10, 189, 62, 14);
		frame.getContentPane().add(lblPhoneNumber);
		
		JLabel lblEmail = new JLabel("Email");
		lblEmail.setBounds(100, 189, 62, 14);
		frame.getContentPane().add(lblEmail);
		
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