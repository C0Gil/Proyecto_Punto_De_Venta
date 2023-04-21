﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferenceVentas
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceVentas.CrudVentasSoap")]
    public interface CrudVentasSoap
    {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento InsertarVentaResult del espacio de nombres http://tempuri.org/ no está marcado para convertirse en valor nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertarVenta", ReplyAction="*")]
        ServiceReferenceVentas.InsertarVentaResponse InsertarVenta(ServiceReferenceVentas.InsertarVentaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertarVenta", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReferenceVentas.InsertarVentaResponse> InsertarVentaAsync(ServiceReferenceVentas.InsertarVentaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento idVenta del espacio de nombres http://tempuri.org/ no está marcado para convertirse en valor nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsertarVentaProducto", ReplyAction="*")]
        ServiceReferenceVentas.IsertarVentaProductoResponse IsertarVentaProducto(ServiceReferenceVentas.IsertarVentaProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsertarVentaProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReferenceVentas.IsertarVentaProductoResponse> IsertarVentaProductoAsync(ServiceReferenceVentas.IsertarVentaProductoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento idUsuario del espacio de nombres http://tempuri.org/ no está marcado para convertirse en valor nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsertarUsuarioVenta", ReplyAction="*")]
        ServiceReferenceVentas.IsertarUsuarioVentaResponse IsertarUsuarioVenta(ServiceReferenceVentas.IsertarUsuarioVentaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsertarUsuarioVenta", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReferenceVentas.IsertarUsuarioVentaResponse> IsertarUsuarioVentaAsync(ServiceReferenceVentas.IsertarUsuarioVentaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarVentaRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarVenta", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferenceVentas.InsertarVentaRequestBody Body;
        
        public InsertarVentaRequest()
        {
        }
        
        public InsertarVentaRequest(ServiceReferenceVentas.InsertarVentaRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertarVentaRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public System.DateTime fecha;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public double monto;
        
        public InsertarVentaRequestBody()
        {
        }
        
        public InsertarVentaRequestBody(System.DateTime fecha, double monto)
        {
            this.fecha = fecha;
            this.monto = monto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarVentaResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarVentaResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferenceVentas.InsertarVentaResponseBody Body;
        
        public InsertarVentaResponse()
        {
        }
        
        public InsertarVentaResponse(ServiceReferenceVentas.InsertarVentaResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertarVentaResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InsertarVentaResult;
        
        public InsertarVentaResponseBody()
        {
        }
        
        public InsertarVentaResponseBody(string InsertarVentaResult)
        {
            this.InsertarVentaResult = InsertarVentaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IsertarVentaProductoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IsertarVentaProducto", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferenceVentas.IsertarVentaProductoRequestBody Body;
        
        public IsertarVentaProductoRequest()
        {
        }
        
        public IsertarVentaProductoRequest(ServiceReferenceVentas.IsertarVentaProductoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class IsertarVentaProductoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string idVenta;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string idProducto;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string cantidad;
        
        public IsertarVentaProductoRequestBody()
        {
        }
        
        public IsertarVentaProductoRequestBody(string idVenta, string idProducto, string cantidad)
        {
            this.idVenta = idVenta;
            this.idProducto = idProducto;
            this.cantidad = cantidad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IsertarVentaProductoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IsertarVentaProductoResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferenceVentas.IsertarVentaProductoResponseBody Body;
        
        public IsertarVentaProductoResponse()
        {
        }
        
        public IsertarVentaProductoResponse(ServiceReferenceVentas.IsertarVentaProductoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class IsertarVentaProductoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string IsertarVentaProductoResult;
        
        public IsertarVentaProductoResponseBody()
        {
        }
        
        public IsertarVentaProductoResponseBody(string IsertarVentaProductoResult)
        {
            this.IsertarVentaProductoResult = IsertarVentaProductoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IsertarUsuarioVentaRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IsertarUsuarioVenta", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferenceVentas.IsertarUsuarioVentaRequestBody Body;
        
        public IsertarUsuarioVentaRequest()
        {
        }
        
        public IsertarUsuarioVentaRequest(ServiceReferenceVentas.IsertarUsuarioVentaRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class IsertarUsuarioVentaRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string idUsuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string idVenta;
        
        public IsertarUsuarioVentaRequestBody()
        {
        }
        
        public IsertarUsuarioVentaRequestBody(string idUsuario, string idVenta)
        {
            this.idUsuario = idUsuario;
            this.idVenta = idVenta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IsertarUsuarioVentaResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IsertarUsuarioVentaResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferenceVentas.IsertarUsuarioVentaResponseBody Body;
        
        public IsertarUsuarioVentaResponse()
        {
        }
        
        public IsertarUsuarioVentaResponse(ServiceReferenceVentas.IsertarUsuarioVentaResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class IsertarUsuarioVentaResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string IsertarUsuarioVentaResult;
        
        public IsertarUsuarioVentaResponseBody()
        {
        }
        
        public IsertarUsuarioVentaResponseBody(string IsertarUsuarioVentaResult)
        {
            this.IsertarUsuarioVentaResult = IsertarUsuarioVentaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface CrudVentasSoapChannel : ServiceReferenceVentas.CrudVentasSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class CrudVentasSoapClient : System.ServiceModel.ClientBase<ServiceReferenceVentas.CrudVentasSoap>, ServiceReferenceVentas.CrudVentasSoap
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CrudVentasSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(CrudVentasSoapClient.GetBindingForEndpoint(endpointConfiguration), CrudVentasSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CrudVentasSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CrudVentasSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CrudVentasSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CrudVentasSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CrudVentasSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReferenceVentas.InsertarVentaResponse ServiceReferenceVentas.CrudVentasSoap.InsertarVenta(ServiceReferenceVentas.InsertarVentaRequest request)
        {
            return base.Channel.InsertarVenta(request);
        }
        
        public string InsertarVenta(System.DateTime fecha, double monto)
        {
            ServiceReferenceVentas.InsertarVentaRequest inValue = new ServiceReferenceVentas.InsertarVentaRequest();
            inValue.Body = new ServiceReferenceVentas.InsertarVentaRequestBody();
            inValue.Body.fecha = fecha;
            inValue.Body.monto = monto;
            ServiceReferenceVentas.InsertarVentaResponse retVal = ((ServiceReferenceVentas.CrudVentasSoap)(this)).InsertarVenta(inValue);
            return retVal.Body.InsertarVentaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceVentas.InsertarVentaResponse> ServiceReferenceVentas.CrudVentasSoap.InsertarVentaAsync(ServiceReferenceVentas.InsertarVentaRequest request)
        {
            return base.Channel.InsertarVentaAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceVentas.InsertarVentaResponse> InsertarVentaAsync(System.DateTime fecha, double monto)
        {
            ServiceReferenceVentas.InsertarVentaRequest inValue = new ServiceReferenceVentas.InsertarVentaRequest();
            inValue.Body = new ServiceReferenceVentas.InsertarVentaRequestBody();
            inValue.Body.fecha = fecha;
            inValue.Body.monto = monto;
            return ((ServiceReferenceVentas.CrudVentasSoap)(this)).InsertarVentaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReferenceVentas.IsertarVentaProductoResponse ServiceReferenceVentas.CrudVentasSoap.IsertarVentaProducto(ServiceReferenceVentas.IsertarVentaProductoRequest request)
        {
            return base.Channel.IsertarVentaProducto(request);
        }
        
        public string IsertarVentaProducto(string idVenta, string idProducto, string cantidad)
        {
            ServiceReferenceVentas.IsertarVentaProductoRequest inValue = new ServiceReferenceVentas.IsertarVentaProductoRequest();
            inValue.Body = new ServiceReferenceVentas.IsertarVentaProductoRequestBody();
            inValue.Body.idVenta = idVenta;
            inValue.Body.idProducto = idProducto;
            inValue.Body.cantidad = cantidad;
            ServiceReferenceVentas.IsertarVentaProductoResponse retVal = ((ServiceReferenceVentas.CrudVentasSoap)(this)).IsertarVentaProducto(inValue);
            return retVal.Body.IsertarVentaProductoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceVentas.IsertarVentaProductoResponse> ServiceReferenceVentas.CrudVentasSoap.IsertarVentaProductoAsync(ServiceReferenceVentas.IsertarVentaProductoRequest request)
        {
            return base.Channel.IsertarVentaProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceVentas.IsertarVentaProductoResponse> IsertarVentaProductoAsync(string idVenta, string idProducto, string cantidad)
        {
            ServiceReferenceVentas.IsertarVentaProductoRequest inValue = new ServiceReferenceVentas.IsertarVentaProductoRequest();
            inValue.Body = new ServiceReferenceVentas.IsertarVentaProductoRequestBody();
            inValue.Body.idVenta = idVenta;
            inValue.Body.idProducto = idProducto;
            inValue.Body.cantidad = cantidad;
            return ((ServiceReferenceVentas.CrudVentasSoap)(this)).IsertarVentaProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReferenceVentas.IsertarUsuarioVentaResponse ServiceReferenceVentas.CrudVentasSoap.IsertarUsuarioVenta(ServiceReferenceVentas.IsertarUsuarioVentaRequest request)
        {
            return base.Channel.IsertarUsuarioVenta(request);
        }
        
        public string IsertarUsuarioVenta(string idUsuario, string idVenta)
        {
            ServiceReferenceVentas.IsertarUsuarioVentaRequest inValue = new ServiceReferenceVentas.IsertarUsuarioVentaRequest();
            inValue.Body = new ServiceReferenceVentas.IsertarUsuarioVentaRequestBody();
            inValue.Body.idUsuario = idUsuario;
            inValue.Body.idVenta = idVenta;
            ServiceReferenceVentas.IsertarUsuarioVentaResponse retVal = ((ServiceReferenceVentas.CrudVentasSoap)(this)).IsertarUsuarioVenta(inValue);
            return retVal.Body.IsertarUsuarioVentaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceVentas.IsertarUsuarioVentaResponse> ServiceReferenceVentas.CrudVentasSoap.IsertarUsuarioVentaAsync(ServiceReferenceVentas.IsertarUsuarioVentaRequest request)
        {
            return base.Channel.IsertarUsuarioVentaAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceVentas.IsertarUsuarioVentaResponse> IsertarUsuarioVentaAsync(string idUsuario, string idVenta)
        {
            ServiceReferenceVentas.IsertarUsuarioVentaRequest inValue = new ServiceReferenceVentas.IsertarUsuarioVentaRequest();
            inValue.Body = new ServiceReferenceVentas.IsertarUsuarioVentaRequestBody();
            inValue.Body.idUsuario = idUsuario;
            inValue.Body.idVenta = idVenta;
            return ((ServiceReferenceVentas.CrudVentasSoap)(this)).IsertarUsuarioVentaAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CrudVentasSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.CrudVentasSoap12))
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
            if ((endpointConfiguration == EndpointConfiguration.CrudVentasSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost/WebService_PuntoVenta/ws/CrudVentas.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.CrudVentasSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost/WebService_PuntoVenta/ws/CrudVentas.asmx");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            CrudVentasSoap,
            
            CrudVentasSoap12,
        }
    }
}
