﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferenceCrud
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceCrud.CrudProductosSoap")]
    public interface CrudProductosSoap
    {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento pro del espacio de nombres http://tempuri.org/ no está marcado para convertirse en valor nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertarProducto", ReplyAction="*")]
        ServiceReferenceCrud.InsertarProductoResponse InsertarProducto(ServiceReferenceCrud.InsertarProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertarProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReferenceCrud.InsertarProductoResponse> InsertarProductoAsync(ServiceReferenceCrud.InsertarProductoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento pro del espacio de nombres http://tempuri.org/ no está marcado para convertirse en valor nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ModificarProducto", ReplyAction="*")]
        ServiceReferenceCrud.ModificarProductoResponse ModificarProducto(ServiceReferenceCrud.ModificarProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ModificarProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReferenceCrud.ModificarProductoResponse> ModificarProductoAsync(ServiceReferenceCrud.ModificarProductoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento EliminarProductoResult del espacio de nombres http://tempuri.org/ no está marcado para convertirse en valor nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarProducto", ReplyAction="*")]
        ServiceReferenceCrud.EliminarProductoResponse EliminarProducto(ServiceReferenceCrud.EliminarProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReferenceCrud.EliminarProductoResponse> EliminarProductoAsync(ServiceReferenceCrud.EliminarProductoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento BuscarProductoResult del espacio de nombres http://tempuri.org/ no está marcado para convertirse en valor nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarProducto", ReplyAction="*")]
        ServiceReferenceCrud.BuscarProductoResponse BuscarProducto(ServiceReferenceCrud.BuscarProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReferenceCrud.BuscarProductoResponse> BuscarProductoAsync(ServiceReferenceCrud.BuscarProductoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarProductoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarProducto", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferenceCrud.InsertarProductoRequestBody Body;
        
        public InsertarProductoRequest()
        {
        }
        
        public InsertarProductoRequest(ServiceReferenceCrud.InsertarProductoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertarProductoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int idpro;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string pro;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public double preven;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public double precom;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public System.DateTime cadu;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int sto;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public bool disp;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public int idcat;
        
        public InsertarProductoRequestBody()
        {
        }
        
        public InsertarProductoRequestBody(int idpro, string pro, double preven, double precom, System.DateTime cadu, int sto, bool disp, int idcat)
        {
            this.idpro = idpro;
            this.pro = pro;
            this.preven = preven;
            this.precom = precom;
            this.cadu = cadu;
            this.sto = sto;
            this.disp = disp;
            this.idcat = idcat;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarProductoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarProductoResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferenceCrud.InsertarProductoResponseBody Body;
        
        public InsertarProductoResponse()
        {
        }
        
        public InsertarProductoResponse(ServiceReferenceCrud.InsertarProductoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertarProductoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InsertarProductoResult;
        
        public InsertarProductoResponseBody()
        {
        }
        
        public InsertarProductoResponseBody(string InsertarProductoResult)
        {
            this.InsertarProductoResult = InsertarProductoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificarProductoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ModificarProducto", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferenceCrud.ModificarProductoRequestBody Body;
        
        public ModificarProductoRequest()
        {
        }
        
        public ModificarProductoRequest(ServiceReferenceCrud.ModificarProductoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificarProductoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int idpro;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string pro;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public double preven;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public double precom;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public System.DateTime cadu;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int sto;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public bool disp;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public int idcat;
        
        public ModificarProductoRequestBody()
        {
        }
        
        public ModificarProductoRequestBody(int idpro, string pro, double preven, double precom, System.DateTime cadu, int sto, bool disp, int idcat)
        {
            this.idpro = idpro;
            this.pro = pro;
            this.preven = preven;
            this.precom = precom;
            this.cadu = cadu;
            this.sto = sto;
            this.disp = disp;
            this.idcat = idcat;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificarProductoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ModificarProductoResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferenceCrud.ModificarProductoResponseBody Body;
        
        public ModificarProductoResponse()
        {
        }
        
        public ModificarProductoResponse(ServiceReferenceCrud.ModificarProductoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificarProductoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ModificarProductoResult;
        
        public ModificarProductoResponseBody()
        {
        }
        
        public ModificarProductoResponseBody(string ModificarProductoResult)
        {
            this.ModificarProductoResult = ModificarProductoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EliminarProductoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EliminarProducto", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferenceCrud.EliminarProductoRequestBody Body;
        
        public EliminarProductoRequest()
        {
        }
        
        public EliminarProductoRequest(ServiceReferenceCrud.EliminarProductoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EliminarProductoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int idpro;
        
        public EliminarProductoRequestBody()
        {
        }
        
        public EliminarProductoRequestBody(int idpro)
        {
            this.idpro = idpro;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EliminarProductoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EliminarProductoResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferenceCrud.EliminarProductoResponseBody Body;
        
        public EliminarProductoResponse()
        {
        }
        
        public EliminarProductoResponse(ServiceReferenceCrud.EliminarProductoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EliminarProductoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string EliminarProductoResult;
        
        public EliminarProductoResponseBody()
        {
        }
        
        public EliminarProductoResponseBody(string EliminarProductoResult)
        {
            this.EliminarProductoResult = EliminarProductoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarProductoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarProducto", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferenceCrud.BuscarProductoRequestBody Body;
        
        public BuscarProductoRequest()
        {
        }
        
        public BuscarProductoRequest(ServiceReferenceCrud.BuscarProductoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarProductoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int idpro;
        
        public BuscarProductoRequestBody()
        {
        }
        
        public BuscarProductoRequestBody(int idpro)
        {
            this.idpro = idpro;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarProductoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarProductoResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferenceCrud.BuscarProductoResponseBody Body;
        
        public BuscarProductoResponse()
        {
        }
        
        public BuscarProductoResponse(ServiceReferenceCrud.BuscarProductoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuscarProductoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string BuscarProductoResult;
        
        public BuscarProductoResponseBody()
        {
        }
        
        public BuscarProductoResponseBody(string BuscarProductoResult)
        {
            this.BuscarProductoResult = BuscarProductoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface CrudProductosSoapChannel : ServiceReferenceCrud.CrudProductosSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class CrudProductosSoapClient : System.ServiceModel.ClientBase<ServiceReferenceCrud.CrudProductosSoap>, ServiceReferenceCrud.CrudProductosSoap
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CrudProductosSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(CrudProductosSoapClient.GetBindingForEndpoint(endpointConfiguration), CrudProductosSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CrudProductosSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CrudProductosSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CrudProductosSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CrudProductosSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CrudProductosSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReferenceCrud.InsertarProductoResponse ServiceReferenceCrud.CrudProductosSoap.InsertarProducto(ServiceReferenceCrud.InsertarProductoRequest request)
        {
            return base.Channel.InsertarProducto(request);
        }
        
        public string InsertarProducto(int idpro, string pro, double preven, double precom, System.DateTime cadu, int sto, bool disp, int idcat)
        {
            ServiceReferenceCrud.InsertarProductoRequest inValue = new ServiceReferenceCrud.InsertarProductoRequest();
            inValue.Body = new ServiceReferenceCrud.InsertarProductoRequestBody();
            inValue.Body.idpro = idpro;
            inValue.Body.pro = pro;
            inValue.Body.preven = preven;
            inValue.Body.precom = precom;
            inValue.Body.cadu = cadu;
            inValue.Body.sto = sto;
            inValue.Body.disp = disp;
            inValue.Body.idcat = idcat;
            ServiceReferenceCrud.InsertarProductoResponse retVal = ((ServiceReferenceCrud.CrudProductosSoap)(this)).InsertarProducto(inValue);
            return retVal.Body.InsertarProductoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCrud.InsertarProductoResponse> ServiceReferenceCrud.CrudProductosSoap.InsertarProductoAsync(ServiceReferenceCrud.InsertarProductoRequest request)
        {
            return base.Channel.InsertarProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCrud.InsertarProductoResponse> InsertarProductoAsync(int idpro, string pro, double preven, double precom, System.DateTime cadu, int sto, bool disp, int idcat)
        {
            ServiceReferenceCrud.InsertarProductoRequest inValue = new ServiceReferenceCrud.InsertarProductoRequest();
            inValue.Body = new ServiceReferenceCrud.InsertarProductoRequestBody();
            inValue.Body.idpro = idpro;
            inValue.Body.pro = pro;
            inValue.Body.preven = preven;
            inValue.Body.precom = precom;
            inValue.Body.cadu = cadu;
            inValue.Body.sto = sto;
            inValue.Body.disp = disp;
            inValue.Body.idcat = idcat;
            return ((ServiceReferenceCrud.CrudProductosSoap)(this)).InsertarProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReferenceCrud.ModificarProductoResponse ServiceReferenceCrud.CrudProductosSoap.ModificarProducto(ServiceReferenceCrud.ModificarProductoRequest request)
        {
            return base.Channel.ModificarProducto(request);
        }
        
        public string ModificarProducto(int idpro, string pro, double preven, double precom, System.DateTime cadu, int sto, bool disp, int idcat)
        {
            ServiceReferenceCrud.ModificarProductoRequest inValue = new ServiceReferenceCrud.ModificarProductoRequest();
            inValue.Body = new ServiceReferenceCrud.ModificarProductoRequestBody();
            inValue.Body.idpro = idpro;
            inValue.Body.pro = pro;
            inValue.Body.preven = preven;
            inValue.Body.precom = precom;
            inValue.Body.cadu = cadu;
            inValue.Body.sto = sto;
            inValue.Body.disp = disp;
            inValue.Body.idcat = idcat;
            ServiceReferenceCrud.ModificarProductoResponse retVal = ((ServiceReferenceCrud.CrudProductosSoap)(this)).ModificarProducto(inValue);
            return retVal.Body.ModificarProductoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCrud.ModificarProductoResponse> ServiceReferenceCrud.CrudProductosSoap.ModificarProductoAsync(ServiceReferenceCrud.ModificarProductoRequest request)
        {
            return base.Channel.ModificarProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCrud.ModificarProductoResponse> ModificarProductoAsync(int idpro, string pro, double preven, double precom, System.DateTime cadu, int sto, bool disp, int idcat)
        {
            ServiceReferenceCrud.ModificarProductoRequest inValue = new ServiceReferenceCrud.ModificarProductoRequest();
            inValue.Body = new ServiceReferenceCrud.ModificarProductoRequestBody();
            inValue.Body.idpro = idpro;
            inValue.Body.pro = pro;
            inValue.Body.preven = preven;
            inValue.Body.precom = precom;
            inValue.Body.cadu = cadu;
            inValue.Body.sto = sto;
            inValue.Body.disp = disp;
            inValue.Body.idcat = idcat;
            return ((ServiceReferenceCrud.CrudProductosSoap)(this)).ModificarProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReferenceCrud.EliminarProductoResponse ServiceReferenceCrud.CrudProductosSoap.EliminarProducto(ServiceReferenceCrud.EliminarProductoRequest request)
        {
            return base.Channel.EliminarProducto(request);
        }
        
        public string EliminarProducto(int idpro)
        {
            ServiceReferenceCrud.EliminarProductoRequest inValue = new ServiceReferenceCrud.EliminarProductoRequest();
            inValue.Body = new ServiceReferenceCrud.EliminarProductoRequestBody();
            inValue.Body.idpro = idpro;
            ServiceReferenceCrud.EliminarProductoResponse retVal = ((ServiceReferenceCrud.CrudProductosSoap)(this)).EliminarProducto(inValue);
            return retVal.Body.EliminarProductoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCrud.EliminarProductoResponse> ServiceReferenceCrud.CrudProductosSoap.EliminarProductoAsync(ServiceReferenceCrud.EliminarProductoRequest request)
        {
            return base.Channel.EliminarProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCrud.EliminarProductoResponse> EliminarProductoAsync(int idpro)
        {
            ServiceReferenceCrud.EliminarProductoRequest inValue = new ServiceReferenceCrud.EliminarProductoRequest();
            inValue.Body = new ServiceReferenceCrud.EliminarProductoRequestBody();
            inValue.Body.idpro = idpro;
            return ((ServiceReferenceCrud.CrudProductosSoap)(this)).EliminarProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReferenceCrud.BuscarProductoResponse ServiceReferenceCrud.CrudProductosSoap.BuscarProducto(ServiceReferenceCrud.BuscarProductoRequest request)
        {
            return base.Channel.BuscarProducto(request);
        }
        
        public string BuscarProducto(int idpro)
        {
            ServiceReferenceCrud.BuscarProductoRequest inValue = new ServiceReferenceCrud.BuscarProductoRequest();
            inValue.Body = new ServiceReferenceCrud.BuscarProductoRequestBody();
            inValue.Body.idpro = idpro;
            ServiceReferenceCrud.BuscarProductoResponse retVal = ((ServiceReferenceCrud.CrudProductosSoap)(this)).BuscarProducto(inValue);
            return retVal.Body.BuscarProductoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReferenceCrud.BuscarProductoResponse> ServiceReferenceCrud.CrudProductosSoap.BuscarProductoAsync(ServiceReferenceCrud.BuscarProductoRequest request)
        {
            return base.Channel.BuscarProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceCrud.BuscarProductoResponse> BuscarProductoAsync(int idpro)
        {
            ServiceReferenceCrud.BuscarProductoRequest inValue = new ServiceReferenceCrud.BuscarProductoRequest();
            inValue.Body = new ServiceReferenceCrud.BuscarProductoRequestBody();
            inValue.Body.idpro = idpro;
            return ((ServiceReferenceCrud.CrudProductosSoap)(this)).BuscarProductoAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CrudProductosSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.CrudProductosSoap12))
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
            if ((endpointConfiguration == EndpointConfiguration.CrudProductosSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost/WebService_PuntoVenta/ws/CrudProductos.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.CrudProductosSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost/WebService_PuntoVenta/ws/CrudProductos.asmx");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            CrudProductosSoap,
            
            CrudProductosSoap12,
        }
    }
}
