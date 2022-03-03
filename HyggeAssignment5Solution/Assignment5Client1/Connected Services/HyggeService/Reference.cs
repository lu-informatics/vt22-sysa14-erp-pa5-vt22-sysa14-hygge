﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HyggeService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HyggeService.HyggeServiceSoap")]
    public interface HyggeServiceSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ViewAll", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        HyggeService.ArrayOfXElement ViewAll(string table);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ViewAll", ReplyAction="*")]
        System.Threading.Tasks.Task<HyggeService.ArrayOfXElement> ViewAllAsync(string table);
        
        // CODEGEN: Parameter 'GetTableAsListResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'Microsoft.Xml.Serialization.XmlArrayItemAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTableAsList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        HyggeService.GetTableAsListResponse GetTableAsList(HyggeService.GetTableAsListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTableAsList", ReplyAction="*")]
        System.Threading.Tasks.Task<HyggeService.GetTableAsListResponse> GetTableAsListAsync(HyggeService.GetTableAsListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDataTableAsDataSet", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        HyggeService.ArrayOfXElement GetDataTableAsDataSet(string tableName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDataTableAsDataSet", ReplyAction="*")]
        System.Threading.Tasks.Task<HyggeService.ArrayOfXElement> GetDataTableAsDataSetAsync(string tableName);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetTableAsList", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetTableAsListRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string tableName;
        
        public GetTableAsListRequest()
        {
        }
        
        public GetTableAsListRequest(string tableName)
        {
            this.tableName = tableName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetTableAsListResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetTableAsListResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ArrayOfAnyType")]
        [System.Xml.Serialization.XmlArrayItemAttribute(NestingLevel=1)]
        public object[][] GetTableAsListResult;
        
        public GetTableAsListResponse()
        {
        }
        
        public GetTableAsListResponse(object[][] GetTableAsListResult)
        {
            this.GetTableAsListResult = GetTableAsListResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface HyggeServiceSoapChannel : HyggeService.HyggeServiceSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class HyggeServiceSoapClient : System.ServiceModel.ClientBase<HyggeService.HyggeServiceSoap>, HyggeService.HyggeServiceSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public HyggeServiceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(HyggeServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), HyggeServiceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HyggeServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(HyggeServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HyggeServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(HyggeServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HyggeServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public HyggeService.ArrayOfXElement ViewAll(string table)
        {
            return base.Channel.ViewAll(table);
        }
        
        public System.Threading.Tasks.Task<HyggeService.ArrayOfXElement> ViewAllAsync(string table)
        {
            return base.Channel.ViewAllAsync(table);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HyggeService.GetTableAsListResponse HyggeService.HyggeServiceSoap.GetTableAsList(HyggeService.GetTableAsListRequest request)
        {
            return base.Channel.GetTableAsList(request);
        }
        
        public object[][] GetTableAsList(string tableName)
        {
            HyggeService.GetTableAsListRequest inValue = new HyggeService.GetTableAsListRequest();
            inValue.tableName = tableName;
            HyggeService.GetTableAsListResponse retVal = ((HyggeService.HyggeServiceSoap)(this)).GetTableAsList(inValue);
            return retVal.GetTableAsListResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HyggeService.GetTableAsListResponse> HyggeService.HyggeServiceSoap.GetTableAsListAsync(HyggeService.GetTableAsListRequest request)
        {
            return base.Channel.GetTableAsListAsync(request);
        }
        
        public System.Threading.Tasks.Task<HyggeService.GetTableAsListResponse> GetTableAsListAsync(string tableName)
        {
            HyggeService.GetTableAsListRequest inValue = new HyggeService.GetTableAsListRequest();
            inValue.tableName = tableName;
            return ((HyggeService.HyggeServiceSoap)(this)).GetTableAsListAsync(inValue);
        }
        
        public HyggeService.ArrayOfXElement GetDataTableAsDataSet(string tableName)
        {
            return base.Channel.GetDataTableAsDataSet(tableName);
        }
        
        public System.Threading.Tasks.Task<HyggeService.ArrayOfXElement> GetDataTableAsDataSetAsync(string tableName)
        {
            return base.Channel.GetDataTableAsDataSetAsync(tableName);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.HyggeServiceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.HyggeServiceSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.HyggeServiceSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost/HyggeAssignment5/HyggeService.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.HyggeServiceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost/HyggeAssignment5/HyggeService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            HyggeServiceSoap,
            
            HyggeServiceSoap12,
        }
    }
    
    [System.Xml.Serialization.XmlSchemaProviderAttribute(null, IsAny=true)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil-lib", "2.0.3.0")]
    public partial class ArrayOfXElement : object, System.Xml.Serialization.IXmlSerializable
    {
        
        private System.Collections.Generic.List<System.Xml.Linq.XElement> nodesList = new System.Collections.Generic.List<System.Xml.Linq.XElement>();
        
        public ArrayOfXElement()
        {
        }
        
        public virtual System.Collections.Generic.List<System.Xml.Linq.XElement> Nodes
        {
            get
            {
                return this.nodesList;
            }
        }
        
        public virtual System.Xml.Schema.XmlSchema GetSchema()
        {
            throw new System.NotImplementedException();
        }
        
        public virtual void WriteXml(System.Xml.XmlWriter writer)
        {
            System.Collections.Generic.IEnumerator<System.Xml.Linq.XElement> e = nodesList.GetEnumerator();
            for (
            ; e.MoveNext(); 
            )
            {
                ((System.Xml.Serialization.IXmlSerializable)(e.Current)).WriteXml(writer);
            }
        }
        
        public virtual void ReadXml(System.Xml.XmlReader reader)
        {
            for (
            ; (reader.NodeType != System.Xml.XmlNodeType.EndElement); 
            )
            {
                if ((reader.NodeType == System.Xml.XmlNodeType.Element))
                {
                    System.Xml.Linq.XElement elem = new System.Xml.Linq.XElement("default");
                    ((System.Xml.Serialization.IXmlSerializable)(elem)).ReadXml(reader);
                    Nodes.Add(elem);
                }
                else
                {
                    reader.Skip();
                }
            }
        }
    }
}
