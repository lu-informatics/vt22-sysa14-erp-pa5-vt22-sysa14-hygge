/**
 * ViewAllResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class ViewAllResponse  implements java.io.Serializable {
    private org.tempuri.ViewAllResponseViewAllResult viewAllResult;

    public ViewAllResponse() {
    }

    public ViewAllResponse(
           org.tempuri.ViewAllResponseViewAllResult viewAllResult) {
           this.viewAllResult = viewAllResult;
    }


    /**
     * Gets the viewAllResult value for this ViewAllResponse.
     * 
     * @return viewAllResult
     */
    public org.tempuri.ViewAllResponseViewAllResult getViewAllResult() {
        return viewAllResult;
    }


    /**
     * Sets the viewAllResult value for this ViewAllResponse.
     * 
     * @param viewAllResult
     */
    public void setViewAllResult(org.tempuri.ViewAllResponseViewAllResult viewAllResult) {
        this.viewAllResult = viewAllResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof ViewAllResponse)) return false;
        ViewAllResponse other = (ViewAllResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.viewAllResult==null && other.getViewAllResult()==null) || 
             (this.viewAllResult!=null &&
              this.viewAllResult.equals(other.getViewAllResult())));
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
        if (getViewAllResult() != null) {
            _hashCode += getViewAllResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(ViewAllResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">ViewAllResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("viewAllResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "ViewAllResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>ViewAllResponse>ViewAllResult"));
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
