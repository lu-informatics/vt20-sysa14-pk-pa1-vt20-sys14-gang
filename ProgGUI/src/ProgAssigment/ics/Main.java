package ProgAssigment.ics;

import java.rmi.RemoteException;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		ProgAssWebServiceSoapProxy proxy = new ProgAssWebServiceSoapProxy(); 
		
		try { 
			System.out.println(proxy.showFile("Test")); 
		} catch (RemoteException e) {
			e.printStackTrace();
			System.out.println("Hitåt");
		}
	}
	
}
