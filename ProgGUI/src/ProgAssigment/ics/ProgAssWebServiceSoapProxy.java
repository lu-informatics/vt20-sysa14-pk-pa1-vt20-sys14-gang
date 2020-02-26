package ProgAssigment.ics;

public class ProgAssWebServiceSoapProxy implements ProgAssigment.ics.ProgAssWebServiceSoap {
  private String _endpoint = null;
  private ProgAssigment.ics.ProgAssWebServiceSoap progAssWebServiceSoap = null;
  
  public ProgAssWebServiceSoapProxy() {
    _initProgAssWebServiceSoapProxy();
  }
  
  public ProgAssWebServiceSoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initProgAssWebServiceSoapProxy();
  }
  
  private void _initProgAssWebServiceSoapProxy() {
    try {
      progAssWebServiceSoap = (new ProgAssigment.ics.ProgAssWebServiceLocator()).getProgAssWebServiceSoap();
      if (progAssWebServiceSoap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)progAssWebServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)progAssWebServiceSoap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (progAssWebServiceSoap != null)
      ((javax.xml.rpc.Stub)progAssWebServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public ProgAssigment.ics.ProgAssWebServiceSoap getProgAssWebServiceSoap() {
    if (progAssWebServiceSoap == null)
      _initProgAssWebServiceSoapProxy();
    return progAssWebServiceSoap;
  }
  
  public java.lang.String helloWorld() throws java.rmi.RemoteException{
    if (progAssWebServiceSoap == null)
      _initProgAssWebServiceSoapProxy();
    return progAssWebServiceSoap.helloWorld();
  }
  
  public java.lang.String showFile(java.lang.String fileName) throws java.rmi.RemoteException{
    if (progAssWebServiceSoap == null)
      _initProgAssWebServiceSoapProxy();
    return progAssWebServiceSoap.showFile(fileName);
  }
  
  
}