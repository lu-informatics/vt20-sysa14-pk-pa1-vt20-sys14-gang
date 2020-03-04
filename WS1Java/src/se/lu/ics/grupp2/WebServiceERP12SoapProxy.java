package se.lu.ics.grupp2;

public class WebServiceERP12SoapProxy implements se.lu.ics.grupp2.WebServiceERP12Soap {
  private String _endpoint = null;
  private se.lu.ics.grupp2.WebServiceERP12Soap webServiceERP12Soap = null;
  
  public WebServiceERP12SoapProxy() {
    _initWebServiceERP12SoapProxy();
  }
  
  public WebServiceERP12SoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initWebServiceERP12SoapProxy();
  }
  
  private void _initWebServiceERP12SoapProxy() {
    try {
      webServiceERP12Soap = (new se.lu.ics.grupp2.WebServiceERP12Locator()).getWebServiceERP12Soap();
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
  
  public se.lu.ics.grupp2.WebServiceERP12Soap getWebServiceERP12Soap() {
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap;
  }
  
  public se.lu.ics.grupp2.Employee createEmployee(java.lang.String no, java.lang.String firstName, java.lang.String lastName, java.lang.String jobTitle, java.lang.String address, java.lang.String phoneNumber, java.lang.String email, java.lang.String ssn) throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.createEmployee(no, firstName, lastName, jobTitle, address, phoneNumber, email, ssn);
  }
  
  public se.lu.ics.grupp2.Employee findEmployee(java.lang.String no) throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.findEmployee(no);
  }
  
  public se.lu.ics.grupp2.Employee updateEmployee(java.lang.String no, java.lang.String firstName, java.lang.String lastName, java.lang.String jobTitle, java.lang.String address, java.lang.String phoneNumber, java.lang.String email) throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.updateEmployee(no, firstName, lastName, jobTitle, address, phoneNumber, email);
  }
  
  public boolean deleteEmployee(java.lang.String no) throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.deleteEmployee(no);
  }
  
  public se.lu.ics.grupp2.ShowContentOfCronusResponseShowContentOfCronusResult showContentOfCronus() throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.showContentOfCronus();
  }
  
  public java.lang.String[] employeeAndRelatives() throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.employeeAndRelatives();
  }
  
  public java.lang.String[] showSickEmployees2004() throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.showSickEmployees2004();
  }
  
  public java.lang.String[] allKeys() throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.allKeys();
  }
  
  public java.lang.String[] showContentOfCronusDataTable() throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.showContentOfCronusDataTable();
  }
  
  public java.lang.String[] mostAbsentEmployees() throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.mostAbsentEmployees();
  }
  
  public java.lang.String[] allIndexes() throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.allIndexes();
  }
  
  public java.lang.String[] allTableConstrains() throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.allTableConstrains();
  }
  
  public java.lang.String[] allTablesInDatabaseSolOne() throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.allTablesInDatabaseSolOne();
  }
  
  public java.lang.String[] allTablesInDatabaseSolTwo() throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.allTablesInDatabaseSolTwo();
  }
  
  public java.lang.String[] allColEmpTableSolOne() throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.allColEmpTableSolOne();
  }
  
  public java.lang.String[] allColEmpTableSolTwo() throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.allColEmpTableSolTwo();
  }
  
  public java.lang.String showFile(java.lang.String fileName) throws java.rmi.RemoteException{
    if (webServiceERP12Soap == null)
      _initWebServiceERP12SoapProxy();
    return webServiceERP12Soap.showFile(fileName);
  }
  
  
}