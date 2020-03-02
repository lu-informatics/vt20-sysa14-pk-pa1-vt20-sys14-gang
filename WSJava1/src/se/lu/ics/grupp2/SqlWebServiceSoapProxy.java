package se.lu.ics.grupp2;

public class SqlWebServiceSoapProxy implements se.lu.ics.grupp2.SqlWebServiceSoap {
  private String _endpoint = null;
  private se.lu.ics.grupp2.SqlWebServiceSoap sqlWebServiceSoap = null;
  
  public SqlWebServiceSoapProxy() {
    _initSqlWebServiceSoapProxy();
  }
  
  public SqlWebServiceSoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initSqlWebServiceSoapProxy();
  }
  
  private void _initSqlWebServiceSoapProxy() {
    try {
      sqlWebServiceSoap = (new se.lu.ics.grupp2.SqlWebServiceLocator()).getSqlWebServiceSoap();
      if (sqlWebServiceSoap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)sqlWebServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)sqlWebServiceSoap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (sqlWebServiceSoap != null)
      ((javax.xml.rpc.Stub)sqlWebServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public se.lu.ics.grupp2.SqlWebServiceSoap getSqlWebServiceSoap() {
    if (sqlWebServiceSoap == null)
      _initSqlWebServiceSoapProxy();
    return sqlWebServiceSoap;
  }
  
  public se.lu.ics.grupp2.Tenant[] getTenantBookings() throws java.rmi.RemoteException{
    if (sqlWebServiceSoap == null)
      _initSqlWebServiceSoapProxy();
    return sqlWebServiceSoap.getTenantBookings();
  }
  
  public se.lu.ics.grupp2.Storage[] getListOfStorages() throws java.rmi.RemoteException{
    if (sqlWebServiceSoap == null)
      _initSqlWebServiceSoapProxy();
    return sqlWebServiceSoap.getListOfStorages();
  }
  
  
}