/**
 * WebServiceERP12Locator.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics.grupp2;

public class WebServiceERP12Locator extends org.apache.axis.client.Service implements se.lu.ics.grupp2.WebServiceERP12 {

    public WebServiceERP12Locator() {
    }


    public WebServiceERP12Locator(org.apache.axis.EngineConfiguration config) {
        super(config);
    }

    public WebServiceERP12Locator(java.lang.String wsdlLoc, javax.xml.namespace.QName sName) throws javax.xml.rpc.ServiceException {
        super(wsdlLoc, sName);
    }

    // Use to get a proxy class for WebServiceERP12Soap
    private java.lang.String WebServiceERP12Soap_address = "http://localhost/WebAppERP/WebServiceERP12.asmx";

    public java.lang.String getWebServiceERP12SoapAddress() {
        return WebServiceERP12Soap_address;
    }

    // The WSDD service name defaults to the port name.
    private java.lang.String WebServiceERP12SoapWSDDServiceName = "WebServiceERP12Soap";

    public java.lang.String getWebServiceERP12SoapWSDDServiceName() {
        return WebServiceERP12SoapWSDDServiceName;
    }

    public void setWebServiceERP12SoapWSDDServiceName(java.lang.String name) {
        WebServiceERP12SoapWSDDServiceName = name;
    }

    public se.lu.ics.grupp2.WebServiceERP12Soap getWebServiceERP12Soap() throws javax.xml.rpc.ServiceException {
       java.net.URL endpoint;
        try {
            endpoint = new java.net.URL(WebServiceERP12Soap_address);
        }
        catch (java.net.MalformedURLException e) {
            throw new javax.xml.rpc.ServiceException(e);
        }
        return getWebServiceERP12Soap(endpoint);
    }

    public se.lu.ics.grupp2.WebServiceERP12Soap getWebServiceERP12Soap(java.net.URL portAddress) throws javax.xml.rpc.ServiceException {
        try {
            se.lu.ics.grupp2.WebServiceERP12SoapStub _stub = new se.lu.ics.grupp2.WebServiceERP12SoapStub(portAddress, this);
            _stub.setPortName(getWebServiceERP12SoapWSDDServiceName());
            return _stub;
        }
        catch (org.apache.axis.AxisFault e) {
            return null;
        }
    }

    public void setWebServiceERP12SoapEndpointAddress(java.lang.String address) {
        WebServiceERP12Soap_address = address;
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        try {
            if (se.lu.ics.grupp2.WebServiceERP12Soap.class.isAssignableFrom(serviceEndpointInterface)) {
                se.lu.ics.grupp2.WebServiceERP12SoapStub _stub = new se.lu.ics.grupp2.WebServiceERP12SoapStub(new java.net.URL(WebServiceERP12Soap_address), this);
                _stub.setPortName(getWebServiceERP12SoapWSDDServiceName());
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
        if ("WebServiceERP12Soap".equals(inputPortName)) {
            return getWebServiceERP12Soap();
        }
        else  {
            java.rmi.Remote _stub = getPort(serviceEndpointInterface);
            ((org.apache.axis.client.Stub) _stub).setPortName(portName);
            return _stub;
        }
    }

    public javax.xml.namespace.QName getServiceName() {
        return new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "WebServiceERP12");
    }

    private java.util.HashSet ports = null;

    public java.util.Iterator getPorts() {
        if (ports == null) {
            ports = new java.util.HashSet();
            ports.add(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "WebServiceERP12Soap"));
        }
        return ports.iterator();
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(java.lang.String portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        
if ("WebServiceERP12Soap".equals(portName)) {
            setWebServiceERP12SoapEndpointAddress(address);
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
