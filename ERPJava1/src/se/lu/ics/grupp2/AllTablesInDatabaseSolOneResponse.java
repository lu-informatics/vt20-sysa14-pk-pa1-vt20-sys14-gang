/**
 * AllTablesInDatabaseSolOneResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics.grupp2;

public class AllTablesInDatabaseSolOneResponse  implements java.io.Serializable {
    private se.lu.ics.grupp2.AllTablesInDatabaseSolOneResponseAllTablesInDatabaseSolOneResult allTablesInDatabaseSolOneResult;

    public AllTablesInDatabaseSolOneResponse() {
    }

    public AllTablesInDatabaseSolOneResponse(
           se.lu.ics.grupp2.AllTablesInDatabaseSolOneResponseAllTablesInDatabaseSolOneResult allTablesInDatabaseSolOneResult) {
           this.allTablesInDatabaseSolOneResult = allTablesInDatabaseSolOneResult;
    }


    /**
     * Gets the allTablesInDatabaseSolOneResult value for this AllTablesInDatabaseSolOneResponse.
     * 
     * @return allTablesInDatabaseSolOneResult
     */
    public se.lu.ics.grupp2.AllTablesInDatabaseSolOneResponseAllTablesInDatabaseSolOneResult getAllTablesInDatabaseSolOneResult() {
        return allTablesInDatabaseSolOneResult;
    }


    /**
     * Sets the allTablesInDatabaseSolOneResult value for this AllTablesInDatabaseSolOneResponse.
     * 
     * @param allTablesInDatabaseSolOneResult
     */
    public void setAllTablesInDatabaseSolOneResult(se.lu.ics.grupp2.AllTablesInDatabaseSolOneResponseAllTablesInDatabaseSolOneResult allTablesInDatabaseSolOneResult) {
        this.allTablesInDatabaseSolOneResult = allTablesInDatabaseSolOneResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof AllTablesInDatabaseSolOneResponse)) return false;
        AllTablesInDatabaseSolOneResponse other = (AllTablesInDatabaseSolOneResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.allTablesInDatabaseSolOneResult==null && other.getAllTablesInDatabaseSolOneResult()==null) || 
             (this.allTablesInDatabaseSolOneResult!=null &&
              this.allTablesInDatabaseSolOneResult.equals(other.getAllTablesInDatabaseSolOneResult())));
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
        if (getAllTablesInDatabaseSolOneResult() != null) {
            _hashCode += getAllTablesInDatabaseSolOneResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(AllTablesInDatabaseSolOneResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", ">AllTablesInDatabaseSolOneResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("allTablesInDatabaseSolOneResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "AllTablesInDatabaseSolOneResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", ">>AllTablesInDatabaseSolOneResponse>AllTablesInDatabaseSolOneResult"));
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
