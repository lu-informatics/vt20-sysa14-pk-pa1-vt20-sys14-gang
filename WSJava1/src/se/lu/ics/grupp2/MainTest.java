package se.lu.ics.grupp2;

import java.rmi.RemoteException;

public class MainTest {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		SqlWebServiceSoapProxy myProxy = new SqlWebServiceSoapProxy(); 
		
		try { 
			System.out.println(myProxy.findStorage("1")); 
		} catch (RemoteException e) {
			e.printStackTrace();
			System.out.println("Hitåt");
		}
		
	}

}
