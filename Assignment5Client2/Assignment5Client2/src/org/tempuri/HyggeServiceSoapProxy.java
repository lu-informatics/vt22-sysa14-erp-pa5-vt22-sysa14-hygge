package org.tempuri;

public class HyggeServiceSoapProxy implements org.tempuri.HyggeServiceSoap {
  private String _endpoint = null;
  private org.tempuri.HyggeServiceSoap hyggeServiceSoap = null;
  
  public HyggeServiceSoapProxy() {
    _initHyggeServiceSoapProxy();
  }
  
  public HyggeServiceSoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initHyggeServiceSoapProxy();
  }
  
  private void _initHyggeServiceSoapProxy() {
    try {
      hyggeServiceSoap = (new org.tempuri.HyggeServiceLocator()).getHyggeServiceSoap();
      if (hyggeServiceSoap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)hyggeServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)hyggeServiceSoap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (hyggeServiceSoap != null)
      ((javax.xml.rpc.Stub)hyggeServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.HyggeServiceSoap getHyggeServiceSoap() {
    if (hyggeServiceSoap == null)
      _initHyggeServiceSoapProxy();
    return hyggeServiceSoap;
  }
  
  public java.lang.String helloWorld() throws java.rmi.RemoteException{
    if (hyggeServiceSoap == null)
      _initHyggeServiceSoapProxy();
    return hyggeServiceSoap.helloWorld();
  }
  
  public void print() throws java.rmi.RemoteException{
    if (hyggeServiceSoap == null)
      _initHyggeServiceSoapProxy();
    hyggeServiceSoap.print();
  }
  
  
}