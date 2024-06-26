﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



/// From WsdlDocumentation:
///
/// <summary>This contract is a stateless contract that provides a mechanism for
/// computing the nth Fibonacci term.</summary>
///
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://microsoft.wcf.documentation", ConfigurationName="IFibonacci")]
public interface IFibonacci
{

    /// From WsdlDocumentation:
    ///
    /// <summary>The Compute operation returns the nth Fibonacci number.  Because it
    /// uses dual recursion it's very inefficient and therefore useful to demonstrate
    /// caching.</summary><returns>The nth Fibonacci number.</returns><param
    /// name="num">The value to use when computing the Fibonacci number.</param>
    ///
    [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.wcf.documentation/IFibonacci/Compute", ReplyAction="http://microsoft.wcf.documentation/IFibonacci/ComputeResponse")]
    int Compute(int num);

    /// From WsdlDocumentation:
    ///
    /// <summary>The GetPerson operation tests custom WSDL documentation
    /// generation.</summary><returns>The Person object to be returned.</returns><param
    /// name="FirstParameter">The value for the first parameter.</param><param
    /// name="SecondParameter">The value for the second parameter.</param>
    ///
    [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.wcf.documentation/IFibonacci/GetPerson", ReplyAction="http://microsoft.wcf.documentation/IFibonacci/GetPersonResponse")]
    Microsoft.WCF.Documentation.Person GetPerson(int FirstParameter, int SecondParameter);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IFibonacciChannel : IFibonacci, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class FibonacciClient : System.ServiceModel.ClientBase<IFibonacci>, IFibonacci
{

    public FibonacciClient()
    {
    }

    public FibonacciClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
    {
    }

    public FibonacciClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public FibonacciClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public FibonacciClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
    {
    }

    public int Compute(int num)
    {
        return base.Channel.Compute(num);
    }

    public Microsoft.WCF.Documentation.Person GetPerson(int FirstParameter, int SecondParameter)
    {
        return base.Channel.GetPerson(FirstParameter, SecondParameter);
    }
}
namespace Microsoft.WCF.Documentation
{
    using System.Runtime.Serialization;


    /// From WsdlDocumentation:
    ///
    /// <summary>The string for the Person type.</summary>
    ///
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string NameField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        /// From WsdlDocumentation:
        ///
        /// <summary>The string for the Name data member.</summary>
        ///
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
}
