﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessWebApp.BMIServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BMIServiceReference.BMICalculatorSoap")]
    public interface BMICalculatorSoap {
        
        // CODEGEN: Generating message contract since element name CalculateBMIResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateBMI", ReplyAction="*")]
        FitnessWebApp.BMIServiceReference.CalculateBMIResponse CalculateBMI(FitnessWebApp.BMIServiceReference.CalculateBMIRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateBMI", ReplyAction="*")]
        System.Threading.Tasks.Task<FitnessWebApp.BMIServiceReference.CalculateBMIResponse> CalculateBMIAsync(FitnessWebApp.BMIServiceReference.CalculateBMIRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalculateBMIRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalculateBMI", Namespace="http://tempuri.org/", Order=0)]
        public FitnessWebApp.BMIServiceReference.CalculateBMIRequestBody Body;
        
        public CalculateBMIRequest() {
        }
        
        public CalculateBMIRequest(FitnessWebApp.BMIServiceReference.CalculateBMIRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalculateBMIRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public float heightCm;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public float weightKg;
        
        public CalculateBMIRequestBody() {
        }
        
        public CalculateBMIRequestBody(float heightCm, float weightKg) {
            this.heightCm = heightCm;
            this.weightKg = weightKg;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalculateBMIResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalculateBMIResponse", Namespace="http://tempuri.org/", Order=0)]
        public FitnessWebApp.BMIServiceReference.CalculateBMIResponseBody Body;
        
        public CalculateBMIResponse() {
        }
        
        public CalculateBMIResponse(FitnessWebApp.BMIServiceReference.CalculateBMIResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalculateBMIResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CalculateBMIResult;
        
        public CalculateBMIResponseBody() {
        }
        
        public CalculateBMIResponseBody(string CalculateBMIResult) {
            this.CalculateBMIResult = CalculateBMIResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BMICalculatorSoapChannel : FitnessWebApp.BMIServiceReference.BMICalculatorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BMICalculatorSoapClient : System.ServiceModel.ClientBase<FitnessWebApp.BMIServiceReference.BMICalculatorSoap>, FitnessWebApp.BMIServiceReference.BMICalculatorSoap {
        
        public BMICalculatorSoapClient() {
        }
        
        public BMICalculatorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BMICalculatorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BMICalculatorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BMICalculatorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FitnessWebApp.BMIServiceReference.CalculateBMIResponse FitnessWebApp.BMIServiceReference.BMICalculatorSoap.CalculateBMI(FitnessWebApp.BMIServiceReference.CalculateBMIRequest request) {
            return base.Channel.CalculateBMI(request);
        }
        
        public string CalculateBMI(float heightCm, float weightKg) {
            FitnessWebApp.BMIServiceReference.CalculateBMIRequest inValue = new FitnessWebApp.BMIServiceReference.CalculateBMIRequest();
            inValue.Body = new FitnessWebApp.BMIServiceReference.CalculateBMIRequestBody();
            inValue.Body.heightCm = heightCm;
            inValue.Body.weightKg = weightKg;
            FitnessWebApp.BMIServiceReference.CalculateBMIResponse retVal = ((FitnessWebApp.BMIServiceReference.BMICalculatorSoap)(this)).CalculateBMI(inValue);
            return retVal.Body.CalculateBMIResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FitnessWebApp.BMIServiceReference.CalculateBMIResponse> FitnessWebApp.BMIServiceReference.BMICalculatorSoap.CalculateBMIAsync(FitnessWebApp.BMIServiceReference.CalculateBMIRequest request) {
            return base.Channel.CalculateBMIAsync(request);
        }
        
        public System.Threading.Tasks.Task<FitnessWebApp.BMIServiceReference.CalculateBMIResponse> CalculateBMIAsync(float heightCm, float weightKg) {
            FitnessWebApp.BMIServiceReference.CalculateBMIRequest inValue = new FitnessWebApp.BMIServiceReference.CalculateBMIRequest();
            inValue.Body = new FitnessWebApp.BMIServiceReference.CalculateBMIRequestBody();
            inValue.Body.heightCm = heightCm;
            inValue.Body.weightKg = weightKg;
            return ((FitnessWebApp.BMIServiceReference.BMICalculatorSoap)(this)).CalculateBMIAsync(inValue);
        }
    }
}
