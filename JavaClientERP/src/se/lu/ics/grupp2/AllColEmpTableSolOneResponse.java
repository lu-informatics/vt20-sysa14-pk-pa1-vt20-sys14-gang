/**
 * AllColEmpTableSolOneResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics.grupp2;

public class AllColEmpTableSolOneResponse  implements java.io.Serializable {
    private java.lang.String[] allColEmpTableSolOneResult;

    public AllColEmpTableSolOneResponse() {
    }

    public AllColEmpTableSolOneResponse(
           java.lang.String[] allColEmpTableSolOneResult) {
           this.allColEmpTableSolOneResult = allColEmpTableSolOneResult;
    }


    /**
     * Gets the allColEmpTableSolOneResult value for this AllColEmpTableSolOneResponse.
     * 
     * @return allColEmpTableSolOneResult
     */
    public java.lang.String[] getAllColEmpTableSolOneResult() {
        return allColEmpTableSolOneResult;
    }


    /**
     * Sets the allColEmpTableSolOneResult value for this AllColEmpTableSolOneResponse.
     * 
     * @param allColEmpTableSolOneResult
     */
    public void setAllColEmpTableSolOneResult(java.lang.String[] allColEmpTableSolOneResult) {
        this.allColEmpTableSolOneResult = allColEmpTableSolOneResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof AllColEmpTableSolOneResponse)) return false;
        AllColEmpTableSolOneResponse other = (AllColEmpTableSolOneResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.allColEmpTableSolOneResult==null && other.getAllColEmpTableSolOneResult()==null) || 
             (this.allColEmpTableSolOneResult!=null &&
              java.util.Arrays.equals(this.allColEmpTableSolOneResult, other.getAllColEmpTableSolOneResult())));
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
        if (getAllColEmpTableSolOneResult() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getAllColEmpTableSolOneResult());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getAllColEmpTableSolOneResult(), i);
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
        new org.apache.axis.description.TypeDesc(AllColEmpTableSolOneResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", ">AllColEmpTableSolOneResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("allColEmpTableSolOneResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "AllColEmpTableSolOneResult"));
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
