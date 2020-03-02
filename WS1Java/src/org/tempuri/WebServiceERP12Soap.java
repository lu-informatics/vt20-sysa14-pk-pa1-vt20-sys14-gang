/**
 * WebServiceERP12Soap.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public interface WebServiceERP12Soap extends java.rmi.Remote {
    public org.tempuri.Employee createEmployee(java.lang.String no, java.lang.String firstName, java.lang.String lastName, java.lang.String jobTitle, java.lang.String address, java.lang.String phoneNumber, java.lang.String email, java.lang.String ssn) throws java.rmi.RemoteException;
    public org.tempuri.Employee findEmployee(java.lang.String no) throws java.rmi.RemoteException;
    public org.tempuri.Employee updateEmployee(java.lang.String no, java.lang.String firstName, java.lang.String lastName, java.lang.String jobTitle, java.lang.String address, java.lang.String phoneNumber, java.lang.String email) throws java.rmi.RemoteException;
    public boolean deleteEmployee(java.lang.String no) throws java.rmi.RemoteException;
    public org.tempuri.ShowContentOfCronusResponseShowContentOfCronusResult showContentOfCronus() throws java.rmi.RemoteException;
    public java.lang.String showFile(java.lang.String fileName) throws java.rmi.RemoteException;
}
