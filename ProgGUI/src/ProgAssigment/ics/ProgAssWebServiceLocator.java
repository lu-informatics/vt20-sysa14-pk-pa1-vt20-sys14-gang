/**
 * ProgAssWebServiceLocator.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package ProgAssigment.ics;

public class ProgAssWebServiceLocator extends org.apache.axis.client.Service implements ProgAssigment.ics.ProgAssWebService {

    public ProgAssWebServiceLocator() {
    }


    public ProgAssWebServiceLocator(org.apache.axis.EngineConfiguration config) {
        super(config);
    }

    public ProgAssWebServiceLocator(java.lang.String wsdlLoc, javax.xml.namespace.QName sName) throws javax.xml.rpc.ServiceException {
        super(wsdlLoc, sName);
    }

    // Use to get a proxy class for ProgAssWebServiceSoap
    private java.lang.String ProgAssWebServiceSoap_address = "http://localhost/ProgAssApplication/ProgAssWebService.asmx";

    public java.lang.String getProgAssWebServiceSoapAddress() {
        return ProgAssWebServiceSoap_address;
    }

    // The WSDD service name defaults to the port name.
    private java.lang.String ProgAssWebServiceSoapWSDDServiceName = "ProgAssWebServiceSoap";

    public java.lang.String getProgAssWebServiceSoapWSDDServiceName() {
        return ProgAssWebServiceSoapWSDDServiceName;
    }

    public void setProgAssWebServiceSoapWSDDServiceName(java.lang.String name) {
        ProgAssWebServiceSoapWSDDServiceName = name;
    }

    public ProgAssigment.ics.ProgAssWebServiceSoap getProgAssWebServiceSoap() throws javax.xml.rpc.ServiceException {
       java.net.URL endpoint;
        try {
            endpoint = new java.net.URL(ProgAssWebServiceSoap_address);
        }
        catch (java.net.MalformedURLException e) {
            throw new javax.xml.rpc.ServiceException(e);
        }
        return getProgAssWebServiceSoap(endpoint);
    }

    public ProgAssigment.ics.ProgAssWebServiceSoap getProgAssWebServiceSoap(java.net.URL portAddress) throws javax.xml.rpc.ServiceException {
        try {
            ProgAssigment.ics.ProgAssWebServiceSoapStub _stub = new ProgAssigment.ics.ProgAssWebServiceSoapStub(portAddress, this);
            _stub.setPortName(getProgAssWebServiceSoapWSDDServiceName());
            return _stub;
        }
        catch (org.apache.axis.AxisFault e) {
            return null;
        }
    }

    public void setProgAssWebServiceSoapEndpointAddress(java.lang.String address) {
        ProgAssWebServiceSoap_address = address;
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        try {
            if (ProgAssigment.ics.ProgAssWebServiceSoap.class.isAssignableFrom(serviceEndpointInterface)) {
                ProgAssigment.ics.ProgAssWebServiceSoapStub _stub = new ProgAssigment.ics.ProgAssWebServiceSoapStub(new java.net.URL(ProgAssWebServiceSoap_address), this);
                _stub.setPortName(getProgAssWebServiceSoapWSDDServiceName());
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
        if ("ProgAssWebServiceSoap".equals(inputPortName)) {
            return getProgAssWebServiceSoap();
        }
        else  {
            java.rmi.Remote _stub = getPort(serviceEndpointInterface);
            ((org.apache.axis.client.Stub) _stub).setPortName(portName);
            return _stub;
        }
    }

    public javax.xml.namespace.QName getServiceName() {
        return new javax.xml.namespace.QName("ics.ProgAssigment", "ProgAssWebService");
    }

    private java.util.HashSet ports = null;

    public java.util.Iterator getPorts() {
        if (ports == null) {
            ports = new java.util.HashSet();
            ports.add(new javax.xml.namespace.QName("ics.ProgAssigment", "ProgAssWebServiceSoap"));
        }
        return ports.iterator();
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(java.lang.String portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        
if ("ProgAssWebServiceSoap".equals(portName)) {
            setProgAssWebServiceSoapEndpointAddress(address);
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
