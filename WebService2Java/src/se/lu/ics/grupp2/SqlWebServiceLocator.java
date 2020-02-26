/**
 * SqlWebServiceLocator.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics.grupp2;

public class SqlWebServiceLocator extends org.apache.axis.client.Service implements se.lu.ics.grupp2.SqlWebService {

    public SqlWebServiceLocator() {
    }


    public SqlWebServiceLocator(org.apache.axis.EngineConfiguration config) {
        super(config);
    }

    public SqlWebServiceLocator(java.lang.String wsdlLoc, javax.xml.namespace.QName sName) throws javax.xml.rpc.ServiceException {
        super(wsdlLoc, sName);
    }

    // Use to get a proxy class for SqlWebServiceSoap
    private java.lang.String SqlWebServiceSoap_address = "http://localhost/SqlWebApplication/SqlWebService.asmx";

    public java.lang.String getSqlWebServiceSoapAddress() {
        return SqlWebServiceSoap_address;
    }

    // The WSDD service name defaults to the port name.
    private java.lang.String SqlWebServiceSoapWSDDServiceName = "SqlWebServiceSoap";

    public java.lang.String getSqlWebServiceSoapWSDDServiceName() {
        return SqlWebServiceSoapWSDDServiceName;
    }

    public void setSqlWebServiceSoapWSDDServiceName(java.lang.String name) {
        SqlWebServiceSoapWSDDServiceName = name;
    }

    public se.lu.ics.grupp2.SqlWebServiceSoap getSqlWebServiceSoap() throws javax.xml.rpc.ServiceException {
       java.net.URL endpoint;
        try {
            endpoint = new java.net.URL(SqlWebServiceSoap_address);
        }
        catch (java.net.MalformedURLException e) {
            throw new javax.xml.rpc.ServiceException(e);
        }
        return getSqlWebServiceSoap(endpoint);
    }

    public se.lu.ics.grupp2.SqlWebServiceSoap getSqlWebServiceSoap(java.net.URL portAddress) throws javax.xml.rpc.ServiceException {
        try {
            se.lu.ics.grupp2.SqlWebServiceSoapStub _stub = new se.lu.ics.grupp2.SqlWebServiceSoapStub(portAddress, this);
            _stub.setPortName(getSqlWebServiceSoapWSDDServiceName());
            return _stub;
        }
        catch (org.apache.axis.AxisFault e) {
            return null;
        }
    }

    public void setSqlWebServiceSoapEndpointAddress(java.lang.String address) {
        SqlWebServiceSoap_address = address;
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        try {
            if (se.lu.ics.grupp2.SqlWebServiceSoap.class.isAssignableFrom(serviceEndpointInterface)) {
                se.lu.ics.grupp2.SqlWebServiceSoapStub _stub = new se.lu.ics.grupp2.SqlWebServiceSoapStub(new java.net.URL(SqlWebServiceSoap_address), this);
                _stub.setPortName(getSqlWebServiceSoapWSDDServiceName());
                return _stub;
            }
        }
        catch (java.lang.Throwable t) {
            throw new javax.xml.rpc.ServiceException(t);
        }
        throw new javax.xml.rpc.ServiceException("There is no stub implementation for the interface:  " + (serviceEndpointInterface == null ? "null" : serviceEndpointInterface.getName()));
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(javax.xml.namespace.QName portName, Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        if (portName == null) {
            return getPort(serviceEndpointInterface);
        }
        java.lang.String inputPortName = portName.getLocalPart();
        if ("SqlWebServiceSoap".equals(inputPortName)) {
            return getSqlWebServiceSoap();
        }
        else  {
            java.rmi.Remote _stub = getPort(serviceEndpointInterface);
            ((org.apache.axis.client.Stub) _stub).setPortName(portName);
            return _stub;
        }
    }

    public javax.xml.namespace.QName getServiceName() {
        return new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "SqlWebService");
    }

    private java.util.HashSet ports = null;

    public java.util.Iterator getPorts() {
        if (ports == null) {
            ports = new java.util.HashSet();
            ports.add(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "SqlWebServiceSoap"));
        }
        return ports.iterator();
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(java.lang.String portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        
if ("SqlWebServiceSoap".equals(portName)) {
            setSqlWebServiceSoapEndpointAddress(address);
        }
        else 
{ // Unknown Port Name
            throw new javax.xml.rpc.ServiceException(" Cannot set Endpoint Address for Unknown Port" + portName);
        }
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(javax.xml.namespace.QName portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        setEndpointAddress(portName.getLocalPart(), address);
    }

}
