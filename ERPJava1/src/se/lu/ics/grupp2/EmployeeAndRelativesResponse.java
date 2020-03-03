/**
 * EmployeeAndRelativesResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics.grupp2;

public class EmployeeAndRelativesResponse  implements java.io.Serializable {
    private se.lu.ics.grupp2.EmployeeAndRelativesResponseEmployeeAndRelativesResult employeeAndRelativesResult;

    public EmployeeAndRelativesResponse() {
    }

    public EmployeeAndRelativesResponse(
           se.lu.ics.grupp2.EmployeeAndRelativesResponseEmployeeAndRelativesResult employeeAndRelativesResult) {
           this.employeeAndRelativesResult = employeeAndRelativesResult;
    }


    /**
     * Gets the employeeAndRelativesResult value for this EmployeeAndRelativesResponse.
     * 
     * @return employeeAndRelativesResult
     */
    public se.lu.ics.grupp2.EmployeeAndRelativesResponseEmployeeAndRelativesResult getEmployeeAndRelativesResult() {
        return employeeAndRelativesResult;
    }


    /**
     * Sets the employeeAndRelativesResult value for this EmployeeAndRelativesResponse.
     * 
     * @param employeeAndRelativesResult
     */
    public void setEmployeeAndRelativesResult(se.lu.ics.grupp2.EmployeeAndRelativesResponseEmployeeAndRelativesResult employeeAndRelativesResult) {
        this.employeeAndRelativesResult = employeeAndRelativesResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof EmployeeAndRelativesResponse)) return false;
        EmployeeAndRelativesResponse other = (EmployeeAndRelativesResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.employeeAndRelativesResult==null && other.getEmployeeAndRelativesResult()==null) || 
             (this.employeeAndRelativesResult!=null &&
              this.employeeAndRelativesResult.equals(other.getEmployeeAndRelativesResult())));
        __equalsCalc = null;
        return _equals;
    }

    private boolean __hashCodeCalc = false;
    public synchronized int hashCode() {
        if (__hashCodeCalc) {
            return 0;
        }
        __hashCodeCalc = true;
        int _hashCode = 1;
        if (getEmployeeAndRelativesResult() != null) {
            _hashCode += getEmployeeAndRelativesResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(EmployeeAndRelativesResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", ">EmployeeAndRelativesResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("employeeAndRelativesResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "EmployeeAndRelativesResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", ">>EmployeeAndRelativesResponse>EmployeeAndRelativesResult"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
    }

    /**
     * Return type metadata object
     */
    public static org.apache.axis.description.TypeDesc getTypeDesc() {
        return typeDesc;
    }

    /**
     * Get Custom Serializer
     */
    public static org.apache.axis.encoding.Serializer getSerializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanSerializer(
            _javaType, _xmlType, typeDesc);
    }

    /**
     * Get Custom Deserializer
     */
    public static org.apache.axis.encoding.Deserializer getDeserializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanDeserializer(
            _javaType, _xmlType, typeDesc);
    }

}
