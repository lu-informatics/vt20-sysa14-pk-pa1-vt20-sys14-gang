package View;

import java.awt.EventQueue;
import javax.swing.JFrame;
import java.awt.GridLayout;
import java.awt.List;

import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;
import java.util.ArrayList;
import java.awt.event.ActionEvent;
import javax.swing.JTextArea;
import java.awt.FlowLayout;
import javax.swing.JTextField;
import javax.swing.JTextPane;

import se.lu.ics.grupp2.SqlWebServiceSoapProxy;
import se.lu.ics.grupp2.Storage;
import se.lu.ics.grupp2.Tenant;

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
		frame.setBounds(200, 200, 700, 700);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		//Button for viewing file
		JButton btnViewFile = new JButton("View");
		btnViewFile.setBounds(492, 11, 89, 23);
		frame.getContentPane().add(btnViewFile);
		
		//Textpane that sets text output from objects
		final JTextPane txtOutput = new JTextPane();
		txtOutput.setBounds(20, 45, 561, 409);
		frame.getContentPane().add(txtOutput);
		
		//Combobox that holds options
		
		
		//for each loop that populates cBox with up to date from database 
		/*
		for (Storage s : myProxy.getListOfStorages()) { 
			 cBoxFiles.addItem(s.toString()); 
		}
		*/
		//fill cBox with options Storage and Tenant 
		final JComboBox<String> cBoxFiles = new JComboBox<String>();
		ArrayList<String>files = new ArrayList<String>(); 
		files.add("Storage"); 
		files.add("Tenant"); 
		for (String value: files) { 
		cBoxFiles.addItem(value); 
		}
				
		frame.getContentPane().add(cBoxFiles);
		cBoxFiles.setBounds(20, 11, 142, 23); 
		
		// method for viewing a chosen file 
		btnViewFile.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				 
				txtOutput.setText(""); 
				String chosenList = cBoxFiles.getSelectedItem().toString(); 
				String storageOutput = "";
				String tenantOutput= ""; 
				
				if (chosenList.contentEquals("Storage")){ 
					try {
							Storage [] storageList = myProxy.getListOfStorages(); 
							for (Storage storage : storageList) {
								storageOutput+=(
									"Storage number: " + storage.getNbr() + "\n"
									+ "Price: " + storage.getPrice() + "\n"
									+ "Size: " + storage.getSize() + "\n" 
									+ "Adress: " + storage.getAddress()+ "\n" + "\n" ); 
							}
							txtOutput.setText(storageOutput);
					} catch (RemoteException e1) {
						e1.printStackTrace();
						txtOutput.setText("Failed to get list of storages");
					}
					
				}
				if (chosenList.contentEquals("Tenant")) {
					try {
						Tenant [] tenantList = myProxy.getTenantBookings(); 
						for (Tenant tenant: myProxy.getTenantBookings()) {
								tenantOutput+= (
									"Email: " + tenant.getEmail() + "\n"
									+ "Name: " + tenant.getName() + "\n"
									+ "Phone number: " + tenant.getPhoneNbr() + "\n"
									+ "Ssn: " + tenant.getSsn() + "\n" 
									+ "Storage number: " + tenant.getEmail()+ "\n" + "\n" );		
							txtOutput.setText(tenantOutput); 	
						}
					} catch (RemoteException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
					}
				}
			}
		});
		
		
	}

	
}
