//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CasosTotalizadores.Views {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("C:\\Users\\ebuenog\\Desktop\\Casos\\starter\\CasosTotalizadores\\Views\\InstalarMedidor.x" +
        "aml")]
    public partial class InstalarMedidor : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry txtNis;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label lblAviso;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.ActivityIndicator IsLoading;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.EntryCell entryNic;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.EntryCell entryMatricula;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.EntryCell entryMedidor;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.EntryCell entryMarca;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.EntryCell entryMultiplo;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.EntryCell entrySector;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.EntryCell entryCircuito;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.EntryCell entryMunicipio;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.EntryCell entryLocalidad;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.EntryCell entryEstado;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.EntryCell entryTipoCon;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.EntryCell entryNaturaleza;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.EntryCell entryTipoTec;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.SwitchCell swBidireccional;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::UXDivers.Artina.Shared.Button btnFoto;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::UXDivers.Artina.Shared.Button btnInstalar;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.ContentView overlay;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry txtLectura;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(InstalarMedidor));
            txtNis = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Entry>(this, "txtNis");
            lblAviso = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "lblAviso");
            IsLoading = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ActivityIndicator>(this, "IsLoading");
            entryNic = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.EntryCell>(this, "entryNic");
            entryMatricula = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.EntryCell>(this, "entryMatricula");
            entryMedidor = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.EntryCell>(this, "entryMedidor");
            entryMarca = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.EntryCell>(this, "entryMarca");
            entryMultiplo = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.EntryCell>(this, "entryMultiplo");
            entrySector = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.EntryCell>(this, "entrySector");
            entryCircuito = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.EntryCell>(this, "entryCircuito");
            entryMunicipio = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.EntryCell>(this, "entryMunicipio");
            entryLocalidad = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.EntryCell>(this, "entryLocalidad");
            entryEstado = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.EntryCell>(this, "entryEstado");
            entryTipoCon = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.EntryCell>(this, "entryTipoCon");
            entryNaturaleza = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.EntryCell>(this, "entryNaturaleza");
            entryTipoTec = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.EntryCell>(this, "entryTipoTec");
            swBidireccional = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.SwitchCell>(this, "swBidireccional");
            btnFoto = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::UXDivers.Artina.Shared.Button>(this, "btnFoto");
            btnInstalar = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::UXDivers.Artina.Shared.Button>(this, "btnInstalar");
            overlay = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ContentView>(this, "overlay");
            txtLectura = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Entry>(this, "txtLectura");
        }
    }
}
