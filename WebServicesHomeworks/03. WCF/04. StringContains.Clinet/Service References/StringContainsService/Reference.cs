﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _04.StringContains.Clinet.StringContainsService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StringContainsService.IServiceStringContains")]
    public interface IServiceStringContains {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStringContains/ContainsString", ReplyAction="http://tempuri.org/IServiceStringContains/ContainsStringResponse")]
        int ContainsString(string valueString, string searchString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStringContains/ContainsString", ReplyAction="http://tempuri.org/IServiceStringContains/ContainsStringResponse")]
        System.Threading.Tasks.Task<int> ContainsStringAsync(string valueString, string searchString);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceStringContainsChannel : _04.StringContains.Clinet.StringContainsService.IServiceStringContains, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceStringContainsClient : System.ServiceModel.ClientBase<_04.StringContains.Clinet.StringContainsService.IServiceStringContains>, _04.StringContains.Clinet.StringContainsService.IServiceStringContains {
        
        public ServiceStringContainsClient() {
        }
        
        public ServiceStringContainsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceStringContainsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceStringContainsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceStringContainsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int ContainsString(string valueString, string searchString) {
            return base.Channel.ContainsString(valueString, searchString);
        }
        
        public System.Threading.Tasks.Task<int> ContainsStringAsync(string valueString, string searchString) {
            return base.Channel.ContainsStringAsync(valueString, searchString);
        }
    }
}
