/**
 * AllTablesInDatabaseSolTwoResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics.grupp2;

public class AllTablesInDatabaseSolTwoResponse  implements java.io.Serializable {
    private se.lu.ics.grupp2.AllTablesInDatabaseSolTwoResponseAllTablesInDatabaseSolTwoResult allTablesInDatabaseSolTwoResult;

    public AllTablesInDatabaseSolTwoResponse() {
    }

    public AllTablesInDatabaseSolTwoResponse(
           se.lu.ics.grupp2.AllTablesInDatabaseSolTwoResponseAllTablesInDatabaseSolTwoResult allTablesInDatabaseSolTwoResult) {
           this.allTablesInDatabaseSolTwoResult = allTablesInDatabaseSolTwoResult;
    }


    /**
     * Gets the allTablesInDatabaseSolTwoResult value for this AllTablesInDatabaseSolTwoResponse.
     * 
     * @return allTablesInDatabaseSolTwoResult
     */
    public se.lu.ics.grupp2.AllTablesInDatabaseSolTwoResponseAllTablesInDatabaseSolTwoResult getAllTablesInDatabaseSolTwoResult() {
        return allTablesInDatabaseSolTwoResult;
    }


    /**
     * Sets the allTablesInDatabaseSolTwoResult value for this AllTablesInDatabaseSolTwoResponse.
     * 
     * @param allTablesInDatabaseSolTwoResult
     */
    public void setAllTablesInDatabaseSolTwoResult(se.lu.ics.grupp2.AllTablesInDatabaseSolTwoResponseAllTablesInDatabaseSolTwoResult allTablesInDatabaseSolTwoResult) {
        this.allTablesInDatabaseSolTwoResult = allTablesInDatabaseSolTwoResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof AllTablesInDatabaseSolTwoResponse)) return false;
        AllTablesInDatabaseSolTwoResponse other = (AllTablesInDatabaseSolTwoResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.allTablesInDatabaseSolTwoResult==null && other.getAllTablesInDatabaseSolTwoResult()==null) || 
             (this.allTablesInDatabaseSolTwoResult!=null &&
              this.allTablesInDatabaseSolTwoResult.equals(other.getAllTablesInDatabaseSolTwoResult())));
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
        if (getAllTablesInDatabaseSolTwoResult() != null) {
            _hashCode += getAllTablesInDatabaseSolTwoResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(AllTablesInDatabaseSolTwoResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", ">AllTablesInDatabaseSolTwoResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("allTablesInDatabaseSolTwoResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "AllTablesInDatabaseSolTwoResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", ">>AllTablesInDatabaseSolTwoResponse>AllTablesInDatabaseSolTwoResult"));
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
