/**
 * AllColEmpTableSolOneResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics.grupp2;

public class AllColEmpTableSolOneResponse  implements java.io.Serializable {
    private se.lu.ics.grupp2.AllColEmpTableSolOneResponseAllColEmpTableSolOneResult allColEmpTableSolOneResult;

    public AllColEmpTableSolOneResponse() {
    }

    public AllColEmpTableSolOneResponse(
           se.lu.ics.grupp2.AllColEmpTableSolOneResponseAllColEmpTableSolOneResult allColEmpTableSolOneResult) {
           this.allColEmpTableSolOneResult = allColEmpTableSolOneResult;
    }


    /**
     * Gets the allColEmpTableSolOneResult value for this AllColEmpTableSolOneResponse.
     * 
     * @return allColEmpTableSolOneResult
     */
    public se.lu.ics.grupp2.AllColEmpTableSolOneResponseAllColEmpTableSolOneResult getAllColEmpTableSolOneResult() {
        return allColEmpTableSolOneResult;
    }


    /**
     * Sets the allColEmpTableSolOneResult value for this AllColEmpTableSolOneResponse.
     * 
     * @param allColEmpTableSolOneResult
     */
    public void setAllColEmpTableSolOneResult(se.lu.ics.grupp2.AllColEmpTableSolOneResponseAllColEmpTableSolOneResult allColEmpTableSolOneResult) {
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
              this.allColEmpTableSolOneResult.equals(other.getAllColEmpTableSolOneResult())));
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
            _hashCode += getAllColEmpTableSolOneResult().hashCode();
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
        elemField.setXmlType(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", ">>AllColEmpTableSolOneResponse>AllColEmpTableSolOneResult"));
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
