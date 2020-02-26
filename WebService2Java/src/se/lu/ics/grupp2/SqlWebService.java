/**
 * SqlWebService.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics.grupp2;

public interface SqlWebService extends javax.xml.rpc.Service {
    public java.lang.String getSqlWebServiceSoapAddress();

    public se.lu.ics.grupp2.SqlWebServiceSoap getSqlWebServiceSoap() throws javax.xml.rpc.ServiceException;

    public se.lu.ics.grupp2.SqlWebServiceSoap getSqlWebServiceSoap(java.net.URL portAddress) throws javax.xml.rpc.ServiceException;
}
