﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace srvlocal_gui {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.6.0.0")]
    internal sealed partial class DebugSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static DebugSettings defaultInstance = ((DebugSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DebugSettings())));
        
        public static DebugSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool debug {
            get {
                return ((bool)(this["debug"]));
            }
            set {
                this["debug"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("builder_gui")]
        public string debugForm {
            get {
                return ((string)(this["debugForm"]));
            }
            set {
                this["debugForm"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("warning")]
        public string reportLevel {
            get {
                return ((string)(this["reportLevel"]));
            }
            set {
                this["reportLevel"] = value;
            }
        }
    }
}
