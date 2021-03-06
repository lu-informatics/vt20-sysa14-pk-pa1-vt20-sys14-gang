package view;

import java.awt.EventQueue;

import javax.swing.JFrame;


import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;
import java.util.ArrayList;
import java.awt.event.ActionEvent;

import javax.swing.JTextField;
import javax.swing.JTextPane;

import se.lu.ics.grupp2.Employee;
import se.lu.ics.grupp2.WebServiceERP12SoapProxy;

import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTable;
import javax.swing.JSpinner;
import javax.swing.JScrollBar;
import javax.swing.JScrollPane;

public class JavaClientGui {

	 private JFrame frame;
	 
	 
	 WebServiceERP12SoapProxy myProxy = new WebServiceERP12SoapProxy ();
	 private JPanel panel;
	 private JTextField txtFirstName;
	 private JTextField txtFFirstName;
	 private JTextField txtFLastName;
	 private JTextField txtFSsn;
	 private JTextField txtFAddress;
	 private JTextField txtFJobTitle;
	 private JTextField txtFEmpNo;
	 private JTextField txtFPhoneNbr;
	 private JTextField txtFEmail;
	 private JTextField txtFSearchEmp;
	
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					JavaClientGui window = new JavaClientGui();
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
	public JavaClientGui() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(800, 800, 934, 610);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JButton btnAdd = new JButton("Add");
		btnAdd.setBounds(196, 180, 89, 23);
		frame.getContentPane().add(btnAdd);
		
		final JTextPane txtPOutput = new JTextPane();
		txtPOutput.setBounds(10, 330, 275, 230);
		frame.getContentPane().add(txtPOutput);
		
		JButton btnUpdate = new JButton("Update");
		
		btnUpdate.setBounds(196, 207, 89, 23);
		frame.getContentPane().add(btnUpdate);
		
		JButton btnDelete = new JButton("Delete");
		btnDelete.setBounds(196, 303, 89, 23);
		frame.getContentPane().add(btnDelete);
		
		JButton btnFind = new JButton("Find");
		btnFind.setBounds(196, 275, 89, 23);
		frame.getContentPane().add(btnFind);
		
		txtFFirstName = new JTextField();
		txtFFirstName.setBounds(10, 68, 86, 20);
		frame.getContentPane().add(txtFFirstName);
		txtFFirstName.setColumns(10);
		
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
		
		final JComboBox cBoxQuery = new JComboBox();
		cBoxQuery.setToolTipText(" ");
		cBoxQuery.setBounds(298, 67, 450, 23);
		frame.getContentPane().add(cBoxQuery);
		
		JButton btnRunQuery = new JButton("Run Query");
		btnRunQuery.setBounds(758, 67, 89, 23);
		frame.getContentPane().add(btnRunQuery);
		
		JLabel lblErpUppgift = new JLabel("ERP Uppgift 1");
		lblErpUppgift.setBounds(10, 28, 108, 14);
		frame.getContentPane().add(lblErpUppgift);
		
		JLabel lblErpUppgift_2 = new JLabel("ERP Uppgift 2");
		lblErpUppgift_2.setBounds(298, 28, 108, 14);
		frame.getContentPane().add(lblErpUppgift_2);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(295, 122, 613, 438);
		frame.getContentPane().add(scrollPane);
		
		final JTextPane txtPQuery = new JTextPane();
		scrollPane.setViewportView(txtPQuery);
		
		
		
		
		
		//populates cBox with querys 
		ArrayList<String>querys = new ArrayList<String>(); 
		querys.add("Content and metadata for employee"); 
		querys.add("Employees and their relatives"); 
		querys.add("Sick employees 2004"); 
		querys.add("Metadata: Keys");
		querys.add("Metadata: Indexes");
		querys.add("Metadata: Table constraint");
		querys.add("Metadata: All tables");
		querys.add("Metadata: All columns");
		for (String value: querys) { 
			 cBoxQuery.addItem(value); 
		}
		
		//method for creating new employee 
		btnAdd.addActionListener(new ActionListener() {
			public void actionPerformed (ActionEvent e) {
				
				String firstName = txtFFirstName.getText(); 
				String lastName = txtFLastName.getText();
				String ssn = txtFSsn.getText();
				String address = txtFAddress.getText(); 
				String jobTitle = txtFJobTitle.getText(); 
				String empNbr = txtFEmpNo.getText(); 
				String phoneNbr = txtFPhoneNbr.getText(); 
				String email = txtFEmail.getText();
				
				if (firstName.equals("")) { 
					txtPOutput.setText("Please enter first name"); 
					return;
				}
			
				else if (lastName.equals("")) { 
					txtPOutput.setText("Please enter last name"); 
					return;
				}
			
				else if (ssn.equals("")) { 
					txtPOutput.setText("Please enter ssn"); 
					return; 
				}
				else if (address.equals("")) { 
					txtPOutput.setText("Please enter address"); 
					return;
				}
			
				else if (jobTitle.equals("")) { 
					txtPOutput.setText("Please enter job title"); 
					return;
				}
				
				else if (firstName.equals("")) { 
					txtPOutput.setText("Please enter employee number"); 
					return;
				}
			
				else if (firstName.equals("")) { 
					txtPOutput.setText("Please enter phone number"); 
					return;
				}
			
				else if (firstName.equals("")) { 
					txtPOutput.setText("Please enter email"); 
					return;
				}
				else { 	txtPOutput.setText("Please fill out fields"); }
				
				try {
					
					myProxy.createEmployee(empNbr, firstName, lastName, jobTitle, address, phoneNbr, email, ssn);
					txtPOutput.setText("Employee created");
				} catch (RemoteException e1) {
					
					e1.printStackTrace();
					txtPOutput.setText("Failed to create employee");
				} {
					
				}; 
				
			}
		}
				
				);
		
		btnUpdate.addActionListener(new ActionListener() {
				public void actionPerformed (ActionEvent e) {
				
						
						String firstName = txtFFirstName.getText(); 
						String lastName = txtFLastName.getText();
						String ssn = txtFSsn.getText();
						String address = txtFAddress.getText(); 
						String jobTitle = txtFJobTitle.getText(); 
						String empNbr = txtFEmpNo.getText(); 
						String phoneNbr = txtFPhoneNbr.getText(); 
						String email = txtFEmail.getText(); 
						
						
						if (firstName.equals("")) { 
							txtPOutput.setText("Please enter first name"); 
							return;
						}
						
						else if (lastName.equals("")) { 
							txtPOutput.setText("Please enter last name"); 
							return;
						}
						 
						else if (ssn.equals("")) { 
							txtPOutput.setText("Please enter ssn"); 
							return; 
						}
						
						else if (address.equals("")) { 
							txtPOutput.setText("Please enter address"); 
							return;
						}
						else if (jobTitle.equals("")) { 
							txtPOutput.setText("Please enter job title"); 
							return;
						}
						else if (empNbr.equals("")) { 
							txtPOutput.setText("Please enter employee number"); 
							return;
						}
						else if (phoneNbr.equals("")) { 
							txtPOutput.setText("Please enter phone number"); 
							return;
						}
						else if (email.equals("")) { 
							txtPOutput.setText("Please enter email"); 
							return;
						}
						else { txtPOutput.setText("N�got gick fel, f�rs�k igen");
						
						
						try {
							myProxy.updateEmployee(empNbr, firstName, lastName, jobTitle, address, phoneNbr, email);
							txtPOutput.setText("Updated employee with employee number " + empNbr); 
						} catch (RemoteException e1) {
							// TODO Auto-generated catch block
							e1.printStackTrace();
							txtPOutput.setText("Failed to update employee");
						}
				}	
				}
				
		}); 
		
		//method for findButton 
		btnFind.addActionListener(new ActionListener() {
			public void actionPerformed (ActionEvent e) {
				txtFFirstName.setText(""); 
				txtFLastName.setText(""); 
				txtFSsn.setText(""); 
				txtFAddress.setText("");
				txtFJobTitle.setText("");
				txtFPhoneNbr.setText("");
				txtFEmpNo.setText("");
				txtFEmail.setText("");
				
				String emp = txtFSearchEmp.getText(); 
				if (emp.equals("")) { 
					txtPOutput.setText("Please enter a ssn");
				}
				else { 
					try {
					Employee employee = myProxy.findEmployee(emp);  
					myProxy.findEmployee(emp); 
					txtPOutput.setText("Found employee with No: " + emp + "\n"
							+ "Last name: " + employee.getLastName() + "\n"
							+ "Job title: " + employee.getJobTitle() + "\n"
							+ "Email: " + employee.getEmail());
					
				} catch (RemoteException e1) {
					e1.printStackTrace();
					txtPOutput.setText("Failed to find employee, try entering a valid ssn");
				} 
			}
		}
		}); 
		/*
		 * Deletes emp from database by emp no search. Checks if a ssn has been entered as
		 * that is where it collects the chosen emp from (and not e.g. cBox)
		 * Else statement checks that the entered ssn exists in DB. If it does, object 
		 * will be deleted. 
		 */
		btnDelete.addActionListener(new ActionListener() {
			public void actionPerformed (ActionEvent e) {
				txtFFirstName.setText(""); 
				txtFLastName.setText(""); 
				txtFSsn.setText(""); 
				txtFAddress.setText("");
				txtFJobTitle.setText("");
				txtFPhoneNbr.setText("");
				txtFEmpNo.setText("");
				txtFEmail.setText("");
				
				String empNo = txtFSearchEmp.getText(); 
				if (empNo.equals("")) { 
					txtPOutput.setText("Please enter a ssn");
				} else {
					try {
						myProxy.deleteEmployee(empNo);
					} catch (RemoteException e2) {
						// TODO Auto-generated catch block
						e2.printStackTrace();
					}
					txtPOutput.setText("Employee with" + empNo +  "deleted");
					
				}
			}
		}); 
		/*
		 * method takes string and opens query. Result is shown in textpane. 
		 */
		btnRunQuery.addActionListener(new ActionListener() {
			public void actionPerformed (ActionEvent e) {
				txtPQuery.setText(""); 
				String query = cBoxQuery.getSelectedItem().toString(); 
				if (query.equals("Content and metadata for employee")) {
					txtPQuery.setText("");
					try {
						String output = ""; 
						for (String s: myProxy.allTablesInDatabaseSolOne()) {
							output+=s + "\n";
							
						}
						txtPQuery.setText(output); 
						
					}
					 catch (RemoteException e1) {
						 txtPQuery.setText("Connection failed");
						e1.printStackTrace();
					} 
				}
				else if (query.equals("Employees and their relatives")) { 
					txtPQuery.setText("");
					try {
						String output = ""; 
						for (String s: myProxy.employeeAndRelatives()) {
							output+=s + "\n";
							
						}
						txtPQuery.setText(output); 
						
					}
					 catch (RemoteException e1) {
						 txtPQuery.setText("Connection failed");
						e1.printStackTrace();
					} 
				}
				else if (query.equals("Sick employees 2004")) { 
					txtPQuery.setText("");
					try {
						String output = ""; 
						for (String s: myProxy.showSickEmployees2004()) {
							output+=s + "\n";
							
						}
						txtPQuery.setText(output); 
						
					}
					 catch (RemoteException e1) {
						 txtPQuery.setText("Connection failed");
						e1.printStackTrace();
					} 
				}
				else if (query.equals("Most absent employee")) { 
					txtPQuery.setText("");
					try {
						String output = ""; 
						for (String s: myProxy.mostAbsentEmployees()) {
							output+=s + "\n";
							
						}
						txtPQuery.setText(output); 
						
					}
					 catch (RemoteException e1) {
						 txtPQuery.setText("Connection failed");
						e1.printStackTrace();
					} 
				}
				else if (query.equals("Metadata: Keys")) { 
					txtPQuery.setText("");
					try {
						String output = ""; 
						for (String s: myProxy.allKeys()) {
							output+=s + "\n";
							
						}
						txtPQuery.setText(output); 
						
					}
					 catch (RemoteException e1) {
						 txtPQuery.setText("Connection failed");
						e1.printStackTrace();
					} 
				}
				else if (query.equals("Metadata: Indexes")) { 
					txtPQuery.setText("");
					try {
						String output = ""; 
						for (String s: myProxy.allIndexes()) {
							output+=s + "\n";
							
						}
						txtPQuery.setText(output); 
						
					}
					 catch (RemoteException e1) {
						 txtPQuery.setText("Connection failed");
						e1.printStackTrace();
					} 
				}
				else if (query.equals("Metadata: Table constraint")) { 
					txtPQuery.setText("");
					try {
						String output = ""; 
						for (String s: myProxy.allTableConstrains()) {
							output+=s + "\n";
							
						}
						txtPQuery.setText(output); 
						
					}
					 catch (RemoteException e1) {
						 txtPQuery.setText("Connection failed");
						e1.printStackTrace();
					} 
				}
				else if (query.equals("Metadata: All tables")) { 
					txtPQuery.setText("");
					try {
						String output = ""; 
						for (String s: myProxy.allTablesInDatabaseSolOne()) {
							output+=s + "\n";
							
						}
						txtPQuery.setText(output); 
						
					}
					 catch (RemoteException e1) {
						 txtPQuery.setText("Connection failed");
						e1.printStackTrace();
					} 
				}
				else if (query.equals("Metadata: All columns")) { 
					txtPQuery.setText("");
					try {
						String output = ""; 
						for (String s: myProxy.allColEmpTableSolOne()) {
							output+=s + "\n";
							
						}
						txtPQuery.setText(output); 
						
					}
					 catch (RemoteException e1) {
						 txtPQuery.setText("Connection failed");
						e1.printStackTrace();
					} 
				}
				else {txtPQuery.setText("Failed to read query ");} 
			}
		}); 		
}
}