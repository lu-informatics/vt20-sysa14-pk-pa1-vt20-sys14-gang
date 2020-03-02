package org.tempuri;

public class WebServiceERP12SoapProxy implements org.tempuri.WebServiceERP12Soap {
  private String _endpoint = null;
  private org.tempuri.WebServiceERP12Soap webServiceERP12Soap = null;
  
  public WebServiceERP12SoapProxy() {
    _initWebServiceERP12SoapProxy();
  }
  
  public WebServiceERP12SoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initWebServiceERP12SoapProxy();
  }
  
  private void _initWebServiceERP12SoapProxy() {
    try {
      webServiceERP12Soap = (new org.tempuri.WebServiceERP12Locator()).getWebServiceERP12Soap();
      if (webServiceERP12Soap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)webServiceERP12Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)webServiceERP12Soap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (webServiceERP12Soap != null)
      ((javax.xml.rpc.Stub)webServiceERP12Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.WebServiceERP12Soap getWebServiceERP12Soap() {
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap;
  }
  
  public org.tempuri.Employee createEmployee(java.lang.String no, java.lang.String firstName, java.lang.String lastName, java.lang.String jobTitle, java.lang.String address, java.lang.String phoneNumber, java.lang.String email, java.lang.String ssn) throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.createEmployee(no, firstName, lastName, jobTitle, address, phoneNumber, email, ssn);
  }
  
  public org.tempuri.Employee findEmployee(java.lang.String no) throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.findEmployee(no);
  }
  
  public org.tempuri.Employee updateEmployee(java.lang.String no, java.lang.String firstName, java.lang.String lastName, java.lang.String jobTitle, java.lang.String address, java.lang.String phoneNumber, java.lang.String email) throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.updateEmployee(no, firstName, lastName, jobTitle, address, phoneNumber, email);
  }
  
  public boolean deleteEmployee(java.lang.String no) throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.deleteEmployee(no);
  }
  
  public org.tempuri.ShowContentOfCronusResponseShowContentOfCronusResult showContentOfCronus() throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.showContentOfCronus();
  }
  
  public java.lang.String showFile(java.lang.String fileName) throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.showFile(fileName);
  }
  
  
}