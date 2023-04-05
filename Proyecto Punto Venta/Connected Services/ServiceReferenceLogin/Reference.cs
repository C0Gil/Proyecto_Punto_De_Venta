﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferenceLogin
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ValidacionSesion", Namespace="http://tempuri.org/")]
    public partial class ValidacionSesion : object
    {
        
        private bool ResultadoField;
        
        private string TipoUsuarioField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool Resultado
        {
            get
            {
                return this.ResultadoField;
            }
            set
            {
                this.ResultadoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string TipoUsuario
        {
            get
            {
                return this.TipoUsuarioField;
            }
            set
            {
                this.TipoUsuarioField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceLogin.login1Soap")]
    public interface login1Soap
    {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento usuario del espacio de nombres http://tempuri.org/ no está marcado para convertirse en valor nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ValidarSesion", ReplyAction="*")]
        ServiceReferenceLogin.ValidarSesionResponse ValidarSesion(ServiceReferenceLogin.ValidarSesionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ValidarSesion", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReferenceLogin.ValidarSesionResponse> ValidarSesionAsync(ServiceReferenceLogin.ValidarSesionRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidarSesionRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidarSesion", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferenceLogin.ValidarSesionRequestBody Body;
        
        public ValidarSesionRequest()
        {
        }
        
        public ValidarSesionRequest(ServiceReferenceLogin.ValidarSesionRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ValidarSesionRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string usuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string psw;
        
        public ValidarSesionRequestBody()
        {
        }
        
        public ValidarSesionRequestBody(string usuario, string psw)
        {
            this.usuario = usuario;
            this.psw = psw;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidarSesionResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidarSesionResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferenceLogin.ValidarSesionResponseBody Body;
        
        public ValidarSesionResponse()
        {
        }
        
        public ValidarSesionResponse(ServiceReferenceLogin.ValidarSesionResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ValidarSesionResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceReferenceLogin.ValidacionSesion ValidarSesionResult;
        
        public ValidarSesionResponseBody()
        {
        }
        
        public ValidarSesionResponseBody(ServiceReferenceLogin.ValidacionSesion ValidarSesionResult)
        {
            this.ValidarSesionResult = ValidarSesionResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface login1SoapChannel : ServiceReferenceLogin.login1Soap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class login1SoapClient : System.ServiceModel.ClientBase<ServiceReferenceLogin.login1Soap>, ServiceReferenceLogin.login1Soap
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public login1SoapClient(EndpointConfiguration endpointConfiguration) : 
                base(login1SoapClient.GetBindingForEndpoint(endpointConfiguration), login1SoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public login1SoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(login1SoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public login1SoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(login1SoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public login1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReferenceLogin.ValidarSesionResponse ServiceReferenceLogin.login1Soap.ValidarSesion(ServiceReferenceLogin.ValidarSesionRequest request)
        {
            return base.Channel.ValidarSesion(request);
        }
        
        public ServiceReferenceLogin.ValidacionSesion ValidarSesion(string usuario, string psw)
        {
            ServiceReferenceLogin.ValidarSesionRequest inValue = new ServiceReferenceLogin.ValidarSesionRequest();
            inValue.Body = new ServiceReferenceLogin.ValidarSesionRequestBody();
            inValue.Body.usuario = usuario;
            inValue.Body.psw = psw;
            ServiceReferenceLogin.ValidarSesionResponse retVal = ((ServiceReferenceLogin.login1Soap)(this)).ValidarSesion(inValue);
            return retVal.Body.ValidarSesionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceLogin.ValidarSesionResponse> ServiceReferenceLogin.login1Soap.ValidarSesionAsync(ServiceReferenceLogin.ValidarSesionRequest request)
        {
            return base.Channel.ValidarSesionAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceLogin.ValidarSesionResponse> ValidarSesionAsync(string usuario, string psw)
        {
            ServiceReferenceLogin.ValidarSesionRequest inValue = new ServiceReferenceLogin.ValidarSesionRequest();
            inValue.Body = new ServiceReferenceLogin.ValidarSesionRequestBody();
            inValue.Body.usuario = usuario;
            inValue.Body.psw = psw;
            return ((ServiceReferenceLogin.login1Soap)(this)).ValidarSesionAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.login1Soap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.login1Soap12))
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
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.login1Soap))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost/tienda_login_v1/ws/login.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.login1Soap12))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost/tienda_login_v1/ws/login.asmx");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            login1Soap,
            
            login1Soap12,
        }
    }
}
