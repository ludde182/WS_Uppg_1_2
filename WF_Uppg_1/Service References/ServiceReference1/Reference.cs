﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WF_Uppg_1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://www.bff.com/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.bff.com/", ConfigurationName="ServiceReference1.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Generating message contract since element name s from namespace http://www.bff.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bff.com/Exists", ReplyAction="*")]
        WF_Uppg_1.ServiceReference1.ExistsResponse Exists(WF_Uppg_1.ServiceReference1.ExistsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bff.com/Exists", ReplyAction="*")]
        System.Threading.Tasks.Task<WF_Uppg_1.ServiceReference1.ExistsResponse> ExistsAsync(WF_Uppg_1.ServiceReference1.ExistsRequest request);
        
        // CODEGEN: Generating message contract since element name s from namespace http://www.bff.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bff.com/TxtFile", ReplyAction="*")]
        WF_Uppg_1.ServiceReference1.TxtFileResponse TxtFile(WF_Uppg_1.ServiceReference1.TxtFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bff.com/TxtFile", ReplyAction="*")]
        System.Threading.Tasks.Task<WF_Uppg_1.ServiceReference1.TxtFileResponse> TxtFileAsync(WF_Uppg_1.ServiceReference1.TxtFileRequest request);
        
        // CODEGEN: Generating message contract since element name GetCustomersResult from namespace http://www.bff.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bff.com/GetCustomers", ReplyAction="*")]
        WF_Uppg_1.ServiceReference1.GetCustomersResponse GetCustomers(WF_Uppg_1.ServiceReference1.GetCustomersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bff.com/GetCustomers", ReplyAction="*")]
        System.Threading.Tasks.Task<WF_Uppg_1.ServiceReference1.GetCustomersResponse> GetCustomersAsync(WF_Uppg_1.ServiceReference1.GetCustomersRequest request);
        
        // CODEGEN: Generating message contract since element name GetReservationsResult from namespace http://www.bff.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bff.com/GetReservations", ReplyAction="*")]
        WF_Uppg_1.ServiceReference1.GetReservationsResponse GetReservations(WF_Uppg_1.ServiceReference1.GetReservationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bff.com/GetReservations", ReplyAction="*")]
        System.Threading.Tasks.Task<WF_Uppg_1.ServiceReference1.GetReservationsResponse> GetReservationsAsync(WF_Uppg_1.ServiceReference1.GetReservationsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExistsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Exists", Namespace="http://www.bff.com/", Order=0)]
        public WF_Uppg_1.ServiceReference1.ExistsRequestBody Body;
        
        public ExistsRequest() {
        }
        
        public ExistsRequest(WF_Uppg_1.ServiceReference1.ExistsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.bff.com/")]
    public partial class ExistsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string s;
        
        public ExistsRequestBody() {
        }
        
        public ExistsRequestBody(string s) {
            this.s = s;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExistsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExistsResponse", Namespace="http://www.bff.com/", Order=0)]
        public WF_Uppg_1.ServiceReference1.ExistsResponseBody Body;
        
        public ExistsResponse() {
        }
        
        public ExistsResponse(WF_Uppg_1.ServiceReference1.ExistsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.bff.com/")]
    public partial class ExistsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ExistsResult;
        
        public ExistsResponseBody() {
        }
        
        public ExistsResponseBody(bool ExistsResult) {
            this.ExistsResult = ExistsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TxtFileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TxtFile", Namespace="http://www.bff.com/", Order=0)]
        public WF_Uppg_1.ServiceReference1.TxtFileRequestBody Body;
        
        public TxtFileRequest() {
        }
        
        public TxtFileRequest(WF_Uppg_1.ServiceReference1.TxtFileRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.bff.com/")]
    public partial class TxtFileRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string s;
        
        public TxtFileRequestBody() {
        }
        
        public TxtFileRequestBody(string s) {
            this.s = s;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TxtFileResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TxtFileResponse", Namespace="http://www.bff.com/", Order=0)]
        public WF_Uppg_1.ServiceReference1.TxtFileResponseBody Body;
        
        public TxtFileResponse() {
        }
        
        public TxtFileResponse(WF_Uppg_1.ServiceReference1.TxtFileResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.bff.com/")]
    public partial class TxtFileResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TxtFileResult;
        
        public TxtFileResponseBody() {
        }
        
        public TxtFileResponseBody(string TxtFileResult) {
            this.TxtFileResult = TxtFileResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCustomersRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCustomers", Namespace="http://www.bff.com/", Order=0)]
        public WF_Uppg_1.ServiceReference1.GetCustomersRequestBody Body;
        
        public GetCustomersRequest() {
        }
        
        public GetCustomersRequest(WF_Uppg_1.ServiceReference1.GetCustomersRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetCustomersRequestBody {
        
        public GetCustomersRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCustomersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCustomersResponse", Namespace="http://www.bff.com/", Order=0)]
        public WF_Uppg_1.ServiceReference1.GetCustomersResponseBody Body;
        
        public GetCustomersResponse() {
        }
        
        public GetCustomersResponse(WF_Uppg_1.ServiceReference1.GetCustomersResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.bff.com/")]
    public partial class GetCustomersResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WF_Uppg_1.ServiceReference1.ArrayOfString GetCustomersResult;
        
        public GetCustomersResponseBody() {
        }
        
        public GetCustomersResponseBody(WF_Uppg_1.ServiceReference1.ArrayOfString GetCustomersResult) {
            this.GetCustomersResult = GetCustomersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetReservationsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetReservations", Namespace="http://www.bff.com/", Order=0)]
        public WF_Uppg_1.ServiceReference1.GetReservationsRequestBody Body;
        
        public GetReservationsRequest() {
        }
        
        public GetReservationsRequest(WF_Uppg_1.ServiceReference1.GetReservationsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetReservationsRequestBody {
        
        public GetReservationsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetReservationsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetReservationsResponse", Namespace="http://www.bff.com/", Order=0)]
        public WF_Uppg_1.ServiceReference1.GetReservationsResponseBody Body;
        
        public GetReservationsResponse() {
        }
        
        public GetReservationsResponse(WF_Uppg_1.ServiceReference1.GetReservationsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.bff.com/")]
    public partial class GetReservationsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WF_Uppg_1.ServiceReference1.ArrayOfString GetReservationsResult;
        
        public GetReservationsResponseBody() {
        }
        
        public GetReservationsResponseBody(WF_Uppg_1.ServiceReference1.ArrayOfString GetReservationsResult) {
            this.GetReservationsResult = GetReservationsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : WF_Uppg_1.ServiceReference1.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<WF_Uppg_1.ServiceReference1.WebServiceSoap>, WF_Uppg_1.ServiceReference1.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WF_Uppg_1.ServiceReference1.ExistsResponse WF_Uppg_1.ServiceReference1.WebServiceSoap.Exists(WF_Uppg_1.ServiceReference1.ExistsRequest request) {
            return base.Channel.Exists(request);
        }
        
        public bool Exists(string s) {
            WF_Uppg_1.ServiceReference1.ExistsRequest inValue = new WF_Uppg_1.ServiceReference1.ExistsRequest();
            inValue.Body = new WF_Uppg_1.ServiceReference1.ExistsRequestBody();
            inValue.Body.s = s;
            WF_Uppg_1.ServiceReference1.ExistsResponse retVal = ((WF_Uppg_1.ServiceReference1.WebServiceSoap)(this)).Exists(inValue);
            return retVal.Body.ExistsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WF_Uppg_1.ServiceReference1.ExistsResponse> WF_Uppg_1.ServiceReference1.WebServiceSoap.ExistsAsync(WF_Uppg_1.ServiceReference1.ExistsRequest request) {
            return base.Channel.ExistsAsync(request);
        }
        
        public System.Threading.Tasks.Task<WF_Uppg_1.ServiceReference1.ExistsResponse> ExistsAsync(string s) {
            WF_Uppg_1.ServiceReference1.ExistsRequest inValue = new WF_Uppg_1.ServiceReference1.ExistsRequest();
            inValue.Body = new WF_Uppg_1.ServiceReference1.ExistsRequestBody();
            inValue.Body.s = s;
            return ((WF_Uppg_1.ServiceReference1.WebServiceSoap)(this)).ExistsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WF_Uppg_1.ServiceReference1.TxtFileResponse WF_Uppg_1.ServiceReference1.WebServiceSoap.TxtFile(WF_Uppg_1.ServiceReference1.TxtFileRequest request) {
            return base.Channel.TxtFile(request);
        }
        
        public string TxtFile(string s) {
            WF_Uppg_1.ServiceReference1.TxtFileRequest inValue = new WF_Uppg_1.ServiceReference1.TxtFileRequest();
            inValue.Body = new WF_Uppg_1.ServiceReference1.TxtFileRequestBody();
            inValue.Body.s = s;
            WF_Uppg_1.ServiceReference1.TxtFileResponse retVal = ((WF_Uppg_1.ServiceReference1.WebServiceSoap)(this)).TxtFile(inValue);
            return retVal.Body.TxtFileResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WF_Uppg_1.ServiceReference1.TxtFileResponse> WF_Uppg_1.ServiceReference1.WebServiceSoap.TxtFileAsync(WF_Uppg_1.ServiceReference1.TxtFileRequest request) {
            return base.Channel.TxtFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<WF_Uppg_1.ServiceReference1.TxtFileResponse> TxtFileAsync(string s) {
            WF_Uppg_1.ServiceReference1.TxtFileRequest inValue = new WF_Uppg_1.ServiceReference1.TxtFileRequest();
            inValue.Body = new WF_Uppg_1.ServiceReference1.TxtFileRequestBody();
            inValue.Body.s = s;
            return ((WF_Uppg_1.ServiceReference1.WebServiceSoap)(this)).TxtFileAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WF_Uppg_1.ServiceReference1.GetCustomersResponse WF_Uppg_1.ServiceReference1.WebServiceSoap.GetCustomers(WF_Uppg_1.ServiceReference1.GetCustomersRequest request) {
            return base.Channel.GetCustomers(request);
        }
        
        public WF_Uppg_1.ServiceReference1.ArrayOfString GetCustomers() {
            WF_Uppg_1.ServiceReference1.GetCustomersRequest inValue = new WF_Uppg_1.ServiceReference1.GetCustomersRequest();
            inValue.Body = new WF_Uppg_1.ServiceReference1.GetCustomersRequestBody();
            WF_Uppg_1.ServiceReference1.GetCustomersResponse retVal = ((WF_Uppg_1.ServiceReference1.WebServiceSoap)(this)).GetCustomers(inValue);
            return retVal.Body.GetCustomersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WF_Uppg_1.ServiceReference1.GetCustomersResponse> WF_Uppg_1.ServiceReference1.WebServiceSoap.GetCustomersAsync(WF_Uppg_1.ServiceReference1.GetCustomersRequest request) {
            return base.Channel.GetCustomersAsync(request);
        }
        
        public System.Threading.Tasks.Task<WF_Uppg_1.ServiceReference1.GetCustomersResponse> GetCustomersAsync() {
            WF_Uppg_1.ServiceReference1.GetCustomersRequest inValue = new WF_Uppg_1.ServiceReference1.GetCustomersRequest();
            inValue.Body = new WF_Uppg_1.ServiceReference1.GetCustomersRequestBody();
            return ((WF_Uppg_1.ServiceReference1.WebServiceSoap)(this)).GetCustomersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WF_Uppg_1.ServiceReference1.GetReservationsResponse WF_Uppg_1.ServiceReference1.WebServiceSoap.GetReservations(WF_Uppg_1.ServiceReference1.GetReservationsRequest request) {
            return base.Channel.GetReservations(request);
        }
        
        public WF_Uppg_1.ServiceReference1.ArrayOfString GetReservations() {
            WF_Uppg_1.ServiceReference1.GetReservationsRequest inValue = new WF_Uppg_1.ServiceReference1.GetReservationsRequest();
            inValue.Body = new WF_Uppg_1.ServiceReference1.GetReservationsRequestBody();
            WF_Uppg_1.ServiceReference1.GetReservationsResponse retVal = ((WF_Uppg_1.ServiceReference1.WebServiceSoap)(this)).GetReservations(inValue);
            return retVal.Body.GetReservationsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WF_Uppg_1.ServiceReference1.GetReservationsResponse> WF_Uppg_1.ServiceReference1.WebServiceSoap.GetReservationsAsync(WF_Uppg_1.ServiceReference1.GetReservationsRequest request) {
            return base.Channel.GetReservationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<WF_Uppg_1.ServiceReference1.GetReservationsResponse> GetReservationsAsync() {
            WF_Uppg_1.ServiceReference1.GetReservationsRequest inValue = new WF_Uppg_1.ServiceReference1.GetReservationsRequest();
            inValue.Body = new WF_Uppg_1.ServiceReference1.GetReservationsRequestBody();
            return ((WF_Uppg_1.ServiceReference1.WebServiceSoap)(this)).GetReservationsAsync(inValue);
        }
    }
}
