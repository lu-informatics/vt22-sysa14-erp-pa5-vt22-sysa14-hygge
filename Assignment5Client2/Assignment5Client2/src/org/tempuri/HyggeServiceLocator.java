/**
 * HyggeServiceLocator.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class HyggeServiceLocator extends org.apache.axis.client.Service implements org.tempuri.HyggeService {

    public HyggeServiceLocator() {
    }


    public HyggeServiceLocator(org.apache.axis.EngineConfiguration config) {
        super(config);
    }

    public HyggeServiceLocator(java.lang.String wsdlLoc, javax.xml.namespace.QName sName) throws javax.xml.rpc.ServiceException {
        super(wsdlLoc, sName);
    }

    // Use to get a proxy class for HyggeServiceSoap
    private java.lang.String HyggeServiceSoap_address = "http://localhost/HyggeAssignment5/CronusService.asmx";

    public java.lang.String getHyggeServiceSoapAddress() {
        return HyggeServiceSoap_address;
    }

    // The WSDD service name defaults to the port name.
    private java.lang.String HyggeServiceSoapWSDDServiceName = "HyggeServiceSoap";

    public java.lang.String getHyggeServiceSoapWSDDServiceName() {
        return HyggeServiceSoapWSDDServiceName;
    }

    public void setHyggeServiceSoapWSDDServiceName(java.lang.String name) {
        HyggeServiceSoapWSDDServiceName = name;
    }

    public org.tempuri.HyggeServiceSoap getHyggeServiceSoap() throws javax.xml.rpc.ServiceException {
       java.net.URL endpoint;
        try {
            endpoint = new java.net.URL(HyggeServiceSoap_address);
        }
        catch (java.net.MalformedURLException e) {
            throw new javax.xml.rpc.ServiceException(e);
        }
        return getHyggeServiceSoap(endpoint);
    }

    public org.tempuri.HyggeServiceSoap getHyggeServiceSoap(java.net.URL portAddress) throws javax.xml.rpc.ServiceException {
        try {
            org.tempuri.HyggeServiceSoapStub _stub = new org.tempuri.HyggeServiceSoapStub(portAddress, this);
            _stub.setPortName(getHyggeServiceSoapWSDDServiceName());
            return _stub;
        }
        catch (org.apache.axis.AxisFault e) {
            return null;
        }
    }

    public void setHyggeServiceSoapEndpointAddress(java.lang.String address) {
        HyggeServiceSoap_address = address;
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        try {
            if (org.tempuri.HyggeServiceSoap.class.isAssignableFrom(serviceEndpointInterface)) {
                org.tempuri.HyggeServiceSoapStub _stub = new org.tempuri.HyggeServiceSoapStub(new java.net.URL(HyggeServiceSoap_address), this);
                _stub.setPortName(getHyggeServiceSoapWSDDServiceName());
                return _stub;
            }
        }
        catch (java.lang.Throwable t) {
            throw new javax.xml.rpc.ServiceException(t);
        }
        throw new javax.xml.rpc.ServiceException("There is no stub implementation for the interface:  " + (serviceEndpointInterface == null ? "null" : serviceEndpointInterface.getName()));
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(javax.xml.namespace.QName portName, Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        if (portName == null) {
            return getPort(serviceEndpointInterface);
        }
        java.lang.String inputPortName = portName.getLocalPart();
        if ("HyggeServiceSoap".equals(inputPortName)) {
            return getHyggeServiceSoap();
        }
        else  {
            java.rmi.Remote _stub = getPort(serviceEndpointInterface);
            ((org.apache.axis.client.Stub) _stub).setPortName(portName);
            return _stub;
        }
    }

    public javax.xml.namespace.QName getServiceName() {
        return new javax.xml.namespace.QName("http://tempuri.org/", "HyggeService");
    }

    private java.util.HashSet ports = null;

    public java.util.Iterator getPorts() {
        if (ports == null) {
            ports = new java.util.HashSet();
            ports.add(new javax.xml.namespace.QName("http://tempuri.org/", "HyggeServiceSoap"));
        }
        return ports.iterator();
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(java.lang.String portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        
if ("HyggeServiceSoap".equals(portName)) {
            setHyggeServiceSoapEndpointAddress(address);
        }
        else 
{ // Unknown Port Name
            throw new javax.xml.rpc.ServiceException(" Cannot set Endpoint Address for Unknown Port" + portName);
        }
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(javax.xml.namespace.QName portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        setEndpointAddress(portName.getLocalPart(), address);
    }

}
