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
import javax.swing.JTable;

public class GUI {

	 private JFrame frame;
	 
	 //WebServiceERP12SoapProxy myProxy = new WebServiceERP12SoapProxy ();
	 private JPanel panel;
	 private JTextField txtFirstName;
	 private JTextField textFFirstName;
	 private JTextField txtFLastName;
	 private JTextField txtFSsn;
	 private JTextField txtFAddress;
	 private JTextField txtFJobTitle;
	 private JTextField txtFEmpNo;
	 private JTextField txtFPhoneNbr;
	 private JTextField txtFEmail;
	 private JTextField txtFSearchEmp;
	 private JTable table;
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
		
		final JTextPane txtPOutput = new JTextPane();
		txtPOutput.setBounds(10, 330, 275, 68);
		frame.getContentPane().add(txtPOutput);
		
		JButton btnUpdate = new JButton("Update");
		btnUpdate.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		btnUpdate.setBounds(196, 207, 89, 23);
		frame.getContentPane().add(btnUpdate);
		
		JButton btnDelete = new JButton("Delete");
		btnDelete.setBounds(196, 303, 89, 23);
		frame.getContentPane().add(btnDelete);
		
		JButton btnFind = new JButton("Find");
		btnFind.setBounds(196, 275, 89, 23);
		frame.getContentPane().add(btnFind);
		
		textFFirstName = new JTextField();
		textFFirstName.setBounds(10, 68, 86, 20);
		frame.getContentPane().add(textFFirstName);
		textFFirstName.setColumns(10);
		
		txtFLastName = new JTextField();
		txtFLastName.setColumns(10);
		txtFLastName.setBounds(100, 68, 86, 20);
		frame.getContentPane().add(txtFLastName);
		
		txtFSsn = new JTextField();
		txtFSsn.setColumns(10);
		txtFSsn.setBounds(10, 111, 86, 20);
		frame.getContentPane().add(txtFSsn);
		
		txtFAddress = new JTextField();
		txtFAddress.setColumns(10);
		txtFAddress.setBounds(100, 111, 86, 20);
		frame.getContentPane().add(txtFAddress);
		
		txtFJobTitle = new JTextField();
		txtFJobTitle.setColumns(10);
		txtFJobTitle.setBounds(10, 159, 86, 20);
		frame.getContentPane().add(txtFJobTitle);
		
		txtFEmpNo = new JTextField();
		txtFEmpNo.setColumns(10);
		txtFEmpNo.setBounds(100, 159, 86, 20);
		frame.getContentPane().add(txtFEmpNo);
		
		txtFPhoneNbr = new JTextField();
		txtFPhoneNbr.setColumns(10);
		txtFPhoneNbr.setBounds(10, 208, 86, 20);
		frame.getContentPane().add(txtFPhoneNbr);
		
		txtFEmail = new JTextField();
		txtFEmail.setColumns(10);
		txtFEmail.setBounds(100, 208, 86, 20);
		frame.getContentPane().add(txtFEmail);
		
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
		
		JLabel lblEmployeeName = new JLabel("Employee no");
		lblEmployeeName.setBounds(100, 142, 62, 14);
		frame.getContentPane().add(lblEmployeeName);
		
		JLabel lblPhoneNbr = new JLabel("Phone number");
		lblPhoneNbr.setBounds(10, 189, 86, 14);
		frame.getContentPane().add(lblPhoneNbr);
		
		JLabel lblEmail = new JLabel("Email");
		lblEmail.setBounds(100, 189, 62, 14);
		frame.getContentPane().add(lblEmail);
		
		txtFSearchEmp = new JTextField();
		txtFSearchEmp.setColumns(10);
		txtFSearchEmp.setBounds(124, 304, 62, 20);
		frame.getContentPane().add(txtFSearchEmp);
		
		JLabel lblEmployeeNo = new JLabel("Employee no");
		lblEmployeeNo.setBounds(124, 289, 62, 14);
		frame.getContentPane().add(lblEmployeeNo);
		
		JLabel lblSearchEmployee = new JLabel("Search employee:");
		lblSearchEmployee.setBounds(10, 305, 86, 18);
		frame.getContentPane().add(lblSearchEmployee);
		
		JComboBox cBoxQuery = new JComboBox();
		cBoxQuery.setToolTipText(" ");
		cBoxQuery.setBounds(298, 67, 251, 23);
		frame.getContentPane().add(cBoxQuery);
		
		JButton btnRunQuery = new JButton("Run Query");
		btnRunQuery.setBounds(559, 67, 89, 23);
		frame.getContentPane().add(btnRunQuery);
		
		table = new JTable();
		table.setBounds(298, 142, 351, 256);
		frame.getContentPane().add(table);
		
		JLabel lblErpUppgift = new JLabel("ERP Uppgift 1");
		lblErpUppgift.setBounds(10, 28, 108, 14);
		frame.getContentPane().add(lblErpUppgift);
		
		JLabel lblErpUppgift_2 = new JLabel("ERP Uppgift 2");
		lblErpUppgift_2.setBounds(298, 28, 108, 14);
		frame.getContentPane().add(lblErpUppgift_2);
		
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