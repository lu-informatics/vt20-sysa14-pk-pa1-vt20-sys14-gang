/**
 * ShowSickEmployees2004Response.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics.grupp2;

public class ShowSickEmployees2004Response  implements java.io.Serializable {
    private java.lang.String[] showSickEmployees2004Result;

    public ShowSickEmployees2004Response() {
    }

    public ShowSickEmployees2004Response(
           java.lang.String[] showSickEmployees2004Result) {
           this.showSickEmployees2004Result = showSickEmployees2004Result;
    }


    /**
     * Gets the showSickEmployees2004Result value for this ShowSickEmployees2004Response.
     * 
     * @return showSickEmployees2004Result
     */
    public java.lang.String[] getShowSickEmployees2004Result() {
        return showSickEmployees2004Result;
    }


    /**
     * Sets the showSickEmployees2004Result value for this ShowSickEmployees2004Response.
     * 
     * @param showSickEmployees2004Result
     */
    public void setShowSickEmployees2004Result(java.lang.String[] showSickEmployees2004Result) {
        this.showSickEmployees2004Result = showSickEmployees2004Result;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof ShowSickEmployees2004Response)) return false;
        ShowSickEmployees2004Response other = (ShowSickEmployees2004Response) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.showSickEmployees2004Result==null && other.getShowSickEmployees2004Result()==null) || 
             (this.showSickEmployees2004Result!=null &&
              java.util.Arrays.equals(this.showSickEmployees2004Result, other.getShowSickEmployees2004Result())));
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
        if (getShowSickEmployees2004Result() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getShowSickEmployees2004Result());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getShowSickEmployees2004Result(), i);
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
        new org.apache.axis.description.TypeDesc(ShowSickEmployees2004Response.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", ">ShowSickEmployees2004Response"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("showSickEmployees2004Result");
        elemField.setXmlName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "ShowSickEmployees2004Result"));
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
