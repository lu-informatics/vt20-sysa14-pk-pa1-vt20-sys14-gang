/**
 * Storage.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics.grupp2;

public class Storage  implements java.io.Serializable {
    private java.lang.String nbr;

    private float price;

    private float size;

    private java.lang.String address;

    public Storage() {
    }

    public Storage(
           java.lang.String nbr,
           float price,
           float size,
           java.lang.String address) {
           this.nbr = nbr;
           this.price = price;
           this.size = size;
           this.address = address;
    }


    /**
     * Gets the nbr value for this Storage.
     * 
     * @return nbr
     */
    public java.lang.String getNbr() {
        return nbr;
    }


    /**
     * Sets the nbr value for this Storage.
     * 
     * @param nbr
     */
    public void setNbr(java.lang.String nbr) {
        this.nbr = nbr;
    }


    /**
     * Gets the price value for this Storage.
     * 
     * @return price
     */
    public float getPrice() {
        return price;
    }


    /**
     * Sets the price value for this Storage.
     * 
     * @param price
     */
    public void setPrice(float price) {
        this.price = price;
    }


    /**
     * Gets the size value for this Storage.
     * 
     * @return size
     */
    public float getSize() {
        return size;
    }


    /**
     * Sets the size value for this Storage.
     * 
     * @param size
     */
    public void setSize(float size) {
        this.size = size;
    }


    /**
     * Gets the address value for this Storage.
     * 
     * @return address
     */
    public java.lang.String getAddress() {
        return address;
    }


    /**
     * Sets the address value for this Storage.
     * 
     * @param address
     */
    public void setAddress(java.lang.String address) {
        this.address = address;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof Storage)) return false;
        Storage other = (Storage) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.nbr==null && other.getNbr()==null) || 
             (this.nbr!=null &&
              this.nbr.equals(other.getNbr()))) &&
            this.price == other.getPrice() &&
            this.size == other.getSize() &&
            ((this.address==null && other.getAddress()==null) || 
             (this.address!=null &&
              this.address.equals(other.getAddress())));
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
        if (getNbr() != null) {
            _hashCode += getNbr().hashCode();
        }
        _hashCode += new Float(getPrice()).hashCode();
        _hashCode += new Float(getSize()).hashCode();
        if (getAddress() != null) {
            _hashCode += getAddress().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(Storage.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "Storage"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("nbr");
        elemField.setXmlName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "Nbr"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("price");
        elemField.setXmlName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "Price"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "float"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("size");
        elemField.setXmlName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "Size"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "float"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("address");
        elemField.setXmlName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "Address"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
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
