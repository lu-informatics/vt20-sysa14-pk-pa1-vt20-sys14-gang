/**
 * Tenant.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics.grupp2;

public class Tenant  implements java.io.Serializable {
    private java.lang.String ssn;

    private java.lang.String name;

    private java.lang.String phoneNbr;

    private java.lang.String email;

    private java.lang.String storageNbr;

    private java.util.Calendar rentDate;

    private java.lang.String storageAddress;

    public Tenant() {
    }

    public Tenant(
           java.lang.String ssn,
           java.lang.String name,
           java.lang.String phoneNbr,
           java.lang.String email,
           java.lang.String storageNbr,
           java.util.Calendar rentDate,
           java.lang.String storageAddress) {
           this.ssn = ssn;
           this.name = name;
           this.phoneNbr = phoneNbr;
           this.email = email;
           this.storageNbr = storageNbr;
           this.rentDate = rentDate;
           this.storageAddress = storageAddress;
    }


    /**
     * Gets the ssn value for this Tenant.
     * 
     * @return ssn
     */
    public java.lang.String getSsn() {
        return ssn;
    }


    /**
     * Sets the ssn value for this Tenant.
     * 
     * @param ssn
     */
    public void setSsn(java.lang.String ssn) {
        this.ssn = ssn;
    }


    /**
     * Gets the name value for this Tenant.
     * 
     * @return name
     */
    public java.lang.String getName() {
        return name;
    }


    /**
     * Sets the name value for this Tenant.
     * 
     * @param name
     */
    public void setName(java.lang.String name) {
        this.name = name;
    }


    /**
     * Gets the phoneNbr value for this Tenant.
     * 
     * @return phoneNbr
     */
    public java.lang.String getPhoneNbr() {
        return phoneNbr;
    }


    /**
     * Sets the phoneNbr value for this Tenant.
     * 
     * @param phoneNbr
     */
    public void setPhoneNbr(java.lang.String phoneNbr) {
        this.phoneNbr = phoneNbr;
    }


    /**
     * Gets the email value for this Tenant.
     * 
     * @return email
     */
    public java.lang.String getEmail() {
        return email;
    }


    /**
     * Sets the email value for this Tenant.
     * 
     * @param email
     */
    public void setEmail(java.lang.String email) {
        this.email = email;
    }


    /**
     * Gets the storageNbr value for this Tenant.
     * 
     * @return storageNbr
     */
    public java.lang.String getStorageNbr() {
        return storageNbr;
    }


    /**
     * Sets the storageNbr value for this Tenant.
     * 
     * @param storageNbr
     */
    public void setStorageNbr(java.lang.String storageNbr) {
        this.storageNbr = storageNbr;
    }


    /**
     * Gets the rentDate value for this Tenant.
     * 
     * @return rentDate
     */
    public java.util.Calendar getRentDate() {
        return rentDate;
    }


    /**
     * Sets the rentDate value for this Tenant.
     * 
     * @param rentDate
     */
    public void setRentDate(java.util.Calendar rentDate) {
        this.rentDate = rentDate;
    }


    /**
     * Gets the storageAddress value for this Tenant.
     * 
     * @return storageAddress
     */
    public java.lang.String getStorageAddress() {
        return storageAddress;
    }


    /**
     * Sets the storageAddress value for this Tenant.
     * 
     * @param storageAddress
     */
    public void setStorageAddress(java.lang.String storageAddress) {
        this.storageAddress = storageAddress;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof Tenant)) return false;
        Tenant other = (Tenant) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.ssn==null && other.getSsn()==null) || 
             (this.ssn!=null &&
              this.ssn.equals(other.getSsn()))) &&
            ((this.name==null && other.getName()==null) || 
             (this.name!=null &&
              this.name.equals(other.getName()))) &&
            ((this.phoneNbr==null && other.getPhoneNbr()==null) || 
             (this.phoneNbr!=null &&
              this.phoneNbr.equals(other.getPhoneNbr()))) &&
            ((this.email==null && other.getEmail()==null) || 
             (this.email!=null &&
              this.email.equals(other.getEmail()))) &&
            ((this.storageNbr==null && other.getStorageNbr()==null) || 
             (this.storageNbr!=null &&
              this.storageNbr.equals(other.getStorageNbr()))) &&
            ((this.rentDate==null && other.getRentDate()==null) || 
             (this.rentDate!=null &&
              this.rentDate.equals(other.getRentDate()))) &&
            ((this.storageAddress==null && other.getStorageAddress()==null) || 
             (this.storageAddress!=null &&
              this.storageAddress.equals(other.getStorageAddress())));
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
        if (getSsn() != null) {
            _hashCode += getSsn().hashCode();
        }
        if (getName() != null) {
            _hashCode += getName().hashCode();
        }
        if (getPhoneNbr() != null) {
            _hashCode += getPhoneNbr().hashCode();
        }
        if (getEmail() != null) {
            _hashCode += getEmail().hashCode();
        }
        if (getStorageNbr() != null) {
            _hashCode += getStorageNbr().hashCode();
        }
        if (getRentDate() != null) {
            _hashCode += getRentDate().hashCode();
        }
        if (getStorageAddress() != null) {
            _hashCode += getStorageAddress().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(Tenant.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "Tenant"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("ssn");
        elemField.setXmlName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "Ssn"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("name");
        elemField.setXmlName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "Name"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("phoneNbr");
        elemField.setXmlName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "PhoneNbr"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("email");
        elemField.setXmlName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "Email"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("storageNbr");
        elemField.setXmlName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "StorageNbr"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("rentDate");
        elemField.setXmlName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "RentDate"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "dateTime"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("storageAddress");
        elemField.setXmlName(new javax.xml.namespace.QName("http://grupp2.ics.lu.se/", "StorageAddress"));
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
