/**
 * HyggeService.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public interface HyggeService extends javax.xml.rpc.Service {
    public java.lang.String getHyggeServiceSoapAddress();

    public org.tempuri.HyggeServiceSoap getHyggeServiceSoap() throws javax.xml.rpc.ServiceException;

    public org.tempuri.HyggeServiceSoap getHyggeServiceSoap(java.net.URL portAddress) throws javax.xml.rpc.ServiceException;
}
