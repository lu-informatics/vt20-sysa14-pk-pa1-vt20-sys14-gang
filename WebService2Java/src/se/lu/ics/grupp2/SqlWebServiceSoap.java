/**
 * SqlWebServiceSoap.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics.grupp2;

public interface SqlWebServiceSoap extends java.rmi.Remote {
    public se.lu.ics.grupp2.Tenant findTenant(java.lang.String ssn) throws java.rmi.RemoteException;
    public se.lu.ics.grupp2.Storage[] getListOfStorages() throws java.rmi.RemoteException;
    public se.lu.ics.grupp2.Storage findStorage(java.lang.String nbr) throws java.rmi.RemoteException;
}
