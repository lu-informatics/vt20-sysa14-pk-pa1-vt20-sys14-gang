/**
 * AllKeysResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics.grupp2;

public class AllKeysResponse  implements java.io.Serializable {
    private se.lu.ics.grupp2.AllKeysResponseAllKeysResult allKeysResult;

    public AllKeysResponse() {
    }

    public AllKeysResponse(
           se.lu.ics.grupp2.AllKeysResponseAllKeysResult allKeysResult) {
           this.allKeysResult = allKeysResult;
    }


    /**
     * Gets the allKeysResult value for this AllKeysResponse.
     * 
     * @return allKeysResult
     */
    public se.lu.ics.grupp2.AllKeysResponseAllKeysResult getAllKeysResult() {
        return allKeysResult;
    }


    /**
     * Sets the allKeysResult value for this AllKeysResponse.
     * 
     * @param allKeysResult
     */
    public void setAllKeysResult(se.lu.ics.grupp2.AllKeysResponseAllKeysResult allKeysResult) {
        this.allKeysResult = allKeysResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof AllKeysResponse)) return false;
        AllKeysResponse other = (AllKeysResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.allKeysResult==null && other.getAllKeysResult()==null) || 
             (this.allKeysResult!=null &&
              this.allKeysResult.equals(other.getAllKeysResult())));
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
        if (getAllKeysResult() != null) {
            _hashCode += getAllKeysResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(AllKeysResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", ">AllKeysResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("allKeysResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "AllKeysResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", ">>AllKeysResponse>AllKeysResult"));
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
