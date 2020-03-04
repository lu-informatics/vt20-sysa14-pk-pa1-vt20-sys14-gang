/**
 * MostAbsentEmployeesResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics.grupp2;

public class MostAbsentEmployeesResponse  implements java.io.Serializable {
    private java.lang.String[] mostAbsentEmployeesResult;

    public MostAbsentEmployeesResponse() {
    }

    public MostAbsentEmployeesResponse(
           java.lang.String[] mostAbsentEmployeesResult) {
           this.mostAbsentEmployeesResult = mostAbsentEmployeesResult;
    }


    /**
     * Gets the mostAbsentEmployeesResult value for this MostAbsentEmployeesResponse.
     * 
     * @return mostAbsentEmployeesResult
     */
    public java.lang.String[] getMostAbsentEmployeesResult() {
        return mostAbsentEmployeesResult;
    }


    /**
     * Sets the mostAbsentEmployeesResult value for this MostAbsentEmployeesResponse.
     * 
     * @param mostAbsentEmployeesResult
     */
    public void setMostAbsentEmployeesResult(java.lang.String[] mostAbsentEmployeesResult) {
        this.mostAbsentEmployeesResult = mostAbsentEmployeesResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof MostAbsentEmployeesResponse)) return false;
        MostAbsentEmployeesResponse other = (MostAbsentEmployeesResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.mostAbsentEmployeesResult==null && other.getMostAbsentEmployeesResult()==null) || 
             (this.mostAbsentEmployeesResult!=null &&
              java.util.Arrays.equals(this.mostAbsentEmployeesResult, other.getMostAbsentEmployeesResult())));
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
        if (getMostAbsentEmployeesResult() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getMostAbsentEmployeesResult());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getMostAbsentEmployeesResult(), i);
                if (obj != null &&
                    !obj.getClass().isArray()) {
                    _hashCode += obj.hashCode();
                }
            }
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(MostAbsentEmployeesResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", ">MostAbsentEmployeesResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("mostAbsentEmployeesResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "MostAbsentEmployeesResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        elemField.setItemQName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "string"));
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
