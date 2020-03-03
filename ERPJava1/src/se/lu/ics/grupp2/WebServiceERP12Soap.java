/**
 * WebServiceERP12Soap.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics.grupp2;

public interface WebServiceERP12Soap extends java.rmi.Remote {
    public se.lu.ics.grupp2.Employee createEmployee(java.lang.String no, java.lang.String firstName, java.lang.String lastName, java.lang.String jobTitle, java.lang.String address, java.lang.String phoneNumber, java.lang.String email, java.lang.String ssn) throws java.rmi.RemoteException;
    public se.lu.ics.grupp2.Employee findEmployee(java.lang.String no) throws java.rmi.RemoteException;
    public se.lu.ics.grupp2.Employee updateEmployee(java.lang.String no, java.lang.String firstName, java.lang.String lastName, java.lang.String jobTitle, java.lang.String address, java.lang.String phoneNumber, java.lang.String email) throws java.rmi.RemoteException;
    public boolean deleteEmployee(java.lang.String no) throws java.rmi.RemoteException;
    public se.lu.ics.grupp2.ShowContentOfCronusResponseShowContentOfCronusResult showContentOfCronus() throws java.rmi.RemoteException;
    public se.lu.ics.grupp2.EmployeeAndRelativesResponseEmployeeAndRelativesResult employeeAndRelatives() throws java.rmi.RemoteException;
    public se.lu.ics.grupp2.ShowSickEmployees2004ResponseShowSickEmployees2004Result showSickEmployees2004() throws java.rmi.RemoteException;
    public se.lu.ics.grupp2.MostAbsentEmployeesResponseMostAbsentEmployeesResult mostAbsentEmployees() throws java.rmi.RemoteException;
    public se.lu.ics.grupp2.AllKeysResponseAllKeysResult allKeys() throws java.rmi.RemoteException;
    public se.lu.ics.grupp2.AllIndexesResponseAllIndexesResult allIndexes() throws java.rmi.RemoteException;
    public se.lu.ics.grupp2.AllTableConstrainsResponseAllTableConstrainsResult allTableConstrains() throws java.rmi.RemoteException;
    public se.lu.ics.grupp2.AllTablesInDatabaseSolOneResponseAllTablesInDatabaseSolOneResult allTablesInDatabaseSolOne() throws java.rmi.RemoteException;
    public se.lu.ics.grupp2.AllTablesInDatabaseSolTwoResponseAllTablesInDatabaseSolTwoResult allTablesInDatabaseSolTwo() throws java.rmi.RemoteException;
    public se.lu.ics.grupp2.AllColEmpTableSolOneResponseAllColEmpTableSolOneResult allColEmpTableSolOne() throws java.rmi.RemoteException;
    public se.lu.ics.grupp2.AllColEmpTableSolTwoResponseAllColEmpTableSolTwoResult allColEmpTableSolTwo() throws java.rmi.RemoteException;
    public java.lang.String showFile(java.lang.String fileName) throws java.rmi.RemoteException;
}
