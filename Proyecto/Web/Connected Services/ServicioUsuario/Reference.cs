﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.ServicioUsuario {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioUsuario.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarRol", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mtdListarRol();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarRol", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mtdListarRolAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdRegistrarUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int mtdRegistrarUsuario(Web.ServicioUsuario.clUsuario objUsu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdRegistrarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<int> mtdRegistrarUsuarioAsync(Web.ServicioUsuario.clUsuario objUsu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdEditarUsuarios", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int mtdEditarUsuarios(Web.ServicioUsuario.clUsuario objUsu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdEditarUsuarios", ReplyAction="*")]
        System.Threading.Tasks.Task<int> mtdEditarUsuariosAsync(Web.ServicioUsuario.clUsuario objUsu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdRegistrarTerreno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int mtdRegistrarTerreno(Web.ServicioUsuario.clTerreno objTerr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdRegistrarTerreno", ReplyAction="*")]
        System.Threading.Tasks.Task<int> mtdRegistrarTerrenoAsync(Web.ServicioUsuario.clTerreno objTerr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdRegistrarSuelos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int mtdRegistrarSuelos(Web.ServicioUsuario.clSuelos objSuelos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdRegistrarSuelos", ReplyAction="*")]
        System.Threading.Tasks.Task<int> mtdRegistrarSuelosAsync(Web.ServicioUsuario.clSuelos objSuelos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarSuelo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mtdListarSuelo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarSuelo", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mtdListarSueloAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdLogin", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int mtdLogin(string Correo, string Clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdLogin", ReplyAction="*")]
        System.Threading.Tasks.Task<int> mtdLoginAsync(string Correo, string Clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdEnviarID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mtdEnviarID(int x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdEnviarID", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mtdEnviarIDAsync(int x);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class clUsuario : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idUsuarioField;
        
        private string documentoField;
        
        private string nombreField;
        
        private string apellidoField;
        
        private string correoField;
        
        private string claveField;
        
        private string numeroField;
        
        private int idRolField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int IdUsuario {
            get {
                return this.idUsuarioField;
            }
            set {
                this.idUsuarioField = value;
                this.RaisePropertyChanged("IdUsuario");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Documento {
            get {
                return this.documentoField;
            }
            set {
                this.documentoField = value;
                this.RaisePropertyChanged("Documento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("Nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Apellido {
            get {
                return this.apellidoField;
            }
            set {
                this.apellidoField = value;
                this.RaisePropertyChanged("Apellido");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Correo {
            get {
                return this.correoField;
            }
            set {
                this.correoField = value;
                this.RaisePropertyChanged("Correo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Clave {
            get {
                return this.claveField;
            }
            set {
                this.claveField = value;
                this.RaisePropertyChanged("Clave");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Numero {
            get {
                return this.numeroField;
            }
            set {
                this.numeroField = value;
                this.RaisePropertyChanged("Numero");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public int IdRol {
            get {
                return this.idRolField;
            }
            set {
                this.idRolField = value;
                this.RaisePropertyChanged("IdRol");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class clSuelos : object, System.ComponentModel.INotifyPropertyChanged {
        
        private double acidezOalcalinidadField;
        
        private double aluminioField;
        
        private double nitrógenoField;
        
        private double potasioField;
        
        private double fósforoField;
        
        private double calcioField;
        
        private double magnesioField;
        
        private double azufreField;
        
        private double cobreField;
        
        private double cincField;
        
        private double manganesoField;
        
        private double boroField;
        
        private int idTipoSueloField;
        
        private int idCultivoField;
        
        private int idTerrenoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public double AcidezOalcalinidad {
            get {
                return this.acidezOalcalinidadField;
            }
            set {
                this.acidezOalcalinidadField = value;
                this.RaisePropertyChanged("AcidezOalcalinidad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public double Aluminio {
            get {
                return this.aluminioField;
            }
            set {
                this.aluminioField = value;
                this.RaisePropertyChanged("Aluminio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public double Nitrógeno {
            get {
                return this.nitrógenoField;
            }
            set {
                this.nitrógenoField = value;
                this.RaisePropertyChanged("Nitrógeno");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public double Potasio {
            get {
                return this.potasioField;
            }
            set {
                this.potasioField = value;
                this.RaisePropertyChanged("Potasio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public double Fósforo {
            get {
                return this.fósforoField;
            }
            set {
                this.fósforoField = value;
                this.RaisePropertyChanged("Fósforo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public double Calcio {
            get {
                return this.calcioField;
            }
            set {
                this.calcioField = value;
                this.RaisePropertyChanged("Calcio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public double Magnesio {
            get {
                return this.magnesioField;
            }
            set {
                this.magnesioField = value;
                this.RaisePropertyChanged("Magnesio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public double Azufre {
            get {
                return this.azufreField;
            }
            set {
                this.azufreField = value;
                this.RaisePropertyChanged("Azufre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public double Cobre {
            get {
                return this.cobreField;
            }
            set {
                this.cobreField = value;
                this.RaisePropertyChanged("Cobre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public double Cinc {
            get {
                return this.cincField;
            }
            set {
                this.cincField = value;
                this.RaisePropertyChanged("Cinc");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public double Manganeso {
            get {
                return this.manganesoField;
            }
            set {
                this.manganesoField = value;
                this.RaisePropertyChanged("Manganeso");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public double Boro {
            get {
                return this.boroField;
            }
            set {
                this.boroField = value;
                this.RaisePropertyChanged("Boro");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public int IdTipoSuelo {
            get {
                return this.idTipoSueloField;
            }
            set {
                this.idTipoSueloField = value;
                this.RaisePropertyChanged("IdTipoSuelo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public int IdCultivo {
            get {
                return this.idCultivoField;
            }
            set {
                this.idCultivoField = value;
                this.RaisePropertyChanged("IdCultivo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public int IdTerreno {
            get {
                return this.idTerrenoField;
            }
            set {
                this.idTerrenoField = value;
                this.RaisePropertyChanged("IdTerreno");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class clTerreno : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idTerrenoField;
        
        private double nombreTerrenoField;
        
        private double largoField;
        
        private double anchoField;
        
        private int idUsuarioField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int IdTerreno {
            get {
                return this.idTerrenoField;
            }
            set {
                this.idTerrenoField = value;
                this.RaisePropertyChanged("IdTerreno");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public double NombreTerreno {
            get {
                return this.nombreTerrenoField;
            }
            set {
                this.nombreTerrenoField = value;
                this.RaisePropertyChanged("NombreTerreno");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public double Largo {
            get {
                return this.largoField;
            }
            set {
                this.largoField = value;
                this.RaisePropertyChanged("Largo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public double Ancho {
            get {
                return this.anchoField;
            }
            set {
                this.anchoField = value;
                this.RaisePropertyChanged("Ancho");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int IdUsuario {
            get {
                return this.idUsuarioField;
            }
            set {
                this.idUsuarioField = value;
                this.RaisePropertyChanged("IdUsuario");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Web.ServicioUsuario.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Web.ServicioUsuario.WebService1Soap>, Web.ServicioUsuario.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet mtdListarRol() {
            return base.Channel.mtdListarRol();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mtdListarRolAsync() {
            return base.Channel.mtdListarRolAsync();
        }
        
        public int mtdRegistrarUsuario(Web.ServicioUsuario.clUsuario objUsu) {
            return base.Channel.mtdRegistrarUsuario(objUsu);
        }
        
        public System.Threading.Tasks.Task<int> mtdRegistrarUsuarioAsync(Web.ServicioUsuario.clUsuario objUsu) {
            return base.Channel.mtdRegistrarUsuarioAsync(objUsu);
        }
        
        public int mtdEditarUsuarios(Web.ServicioUsuario.clUsuario objUsu) {
            return base.Channel.mtdEditarUsuarios(objUsu);
        }
        
        public System.Threading.Tasks.Task<int> mtdEditarUsuariosAsync(Web.ServicioUsuario.clUsuario objUsu) {
            return base.Channel.mtdEditarUsuariosAsync(objUsu);
        }
        
        public int mtdRegistrarTerreno(Web.ServicioUsuario.clTerreno objTerr) {
            return base.Channel.mtdRegistrarTerreno(objTerr);
        }
        
        public System.Threading.Tasks.Task<int> mtdRegistrarTerrenoAsync(Web.ServicioUsuario.clTerreno objTerr) {
            return base.Channel.mtdRegistrarTerrenoAsync(objTerr);
        }
        
        public int mtdRegistrarSuelos(Web.ServicioUsuario.clSuelos objSuelos) {
            return base.Channel.mtdRegistrarSuelos(objSuelos);
        }
        
        public System.Threading.Tasks.Task<int> mtdRegistrarSuelosAsync(Web.ServicioUsuario.clSuelos objSuelos) {
            return base.Channel.mtdRegistrarSuelosAsync(objSuelos);
        }
        
        public System.Data.DataSet mtdListarSuelo() {
            return base.Channel.mtdListarSuelo();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mtdListarSueloAsync() {
            return base.Channel.mtdListarSueloAsync();
        }
        
        public int mtdLogin(string Correo, string Clave) {
            return base.Channel.mtdLogin(Correo, Clave);
        }
        
        public System.Threading.Tasks.Task<int> mtdLoginAsync(string Correo, string Clave) {
            return base.Channel.mtdLoginAsync(Correo, Clave);
        }
        
        public System.Data.DataSet mtdEnviarID(int x) {
            return base.Channel.mtdEnviarID(x);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mtdEnviarIDAsync(int x) {
            return base.Channel.mtdEnviarIDAsync(x);
        }
    }
}
