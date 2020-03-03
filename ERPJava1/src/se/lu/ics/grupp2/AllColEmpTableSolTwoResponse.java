/**
 * AllColEmpTableSolTwoResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics.grupp2;

public class AllColEmpTableSolTwoResponse  implements java.io.Serializable {
    private se.lu.ics.grupp2.AllColEmpTableSolTwoResponseAllColEmpTableSolTwoResult allColEmpTableSolTwoResult;

    public AllColEmpTableSolTwoResponse() {
    }

    public AllColEmpTableSolTwoResponse(
           se.lu.ics.grupp2.AllColEmpTableSolTwoResponseAllColEmpTableSolTwoResult allColEmpTableSolTwoResult) {
           this.allColEmpTableSolTwoResult = allColEmpTableSolTwoResult;
    }


    /**
     * Gets the allColEmpTableSolTwoResult value for this AllColEmpTableSolTwoResponse.
     * 
     * @return allColEmpTableSolTwoResult
     */
    public se.lu.ics.grupp2.AllColEmpTableSolTwoResponseAllColEmpTableSolTwoResult getAllColEmpTableSolTwoResult() {
        return allColEmpTableSolTwoResult;
    }


    /**
     * Sets the allColEmpTableSolTwoResult value for this AllColEmpTableSolTwoResponse.
     * 
     * @param allColEmpTableSolTwoResult
     */
    public void setAllColEmpTableSolTwoResult(se.lu.ics.grupp2.AllColEmpTableSolTwoResponseAllColEmpTableSolTwoResult allColEmpTableSolTwoResult) {
        this.allColEmpTableSolTwoResult = allColEmpTableSolTwoResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof AllColEmpTableSolTwoResponse)) return false;
        AllColEmpTableSolTwoResponse other = (AllColEmpTableSolTwoResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.allColEmpTableSolTwoResult==null && other.getAllColEmpTableSolTwoResult()==null) || 
             (this.allColEmpTableSolTwoResult!=null &&
              this.allColEmpTableSolTwoResult.equals(other.getAllColEmpTableSolTwoResult())));
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
        if (getAllColEmpTableSolTwoResult() != null) {
            _hashCode += getAllColEmpTableSolTwoResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(AllColEmpTableSolTwoResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", ">AllColEmpTableSolTwoResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("allColEmpTableSolTwoResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "AllColEmpTableSolTwoResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", ">>AllColEmpTableSolTwoResponse>AllColEmpTableSolTwoResult"));
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
