﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace srvlocal_gui.LAB.SETTINGS {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.7.0.0")]
    public sealed partial class config : global::System.Configuration.ApplicationSettingsBase {
        
        private static config defaultInstance = ((config)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new config())));
        
        public static config Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool acceptedLicenseAgrement {
            get {
                return ((bool)(this["acceptedLicenseAgrement"]));
            }
            set {
                this["acceptedLicenseAgrement"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("admin")]
        public string lastLoggedInUser {
            get {
                return ((string)(this["lastLoggedInUser"]));
            }
            set {
                this["lastLoggedInUser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\joeva\\Documents\\GitHub\\LILO-LocalServer\\srvlocal_gui\\bin\\Debug\\net7.0-wi" +
            "ndows\\srvlocal.exe")]
        public string srvlocal_path {
            get {
                return ((string)(this["srvlocal_path"]));
            }
            set {
                this["srvlocal_path"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\joeva\\Documents\\GitHub\\LILO-LocalServer\\srvlocal_gui\\bin\\Debug\\net7.0-wi" +
            "ndows\\")]
        public string resource_dir {
            get {
                return ((string)(this["resource_dir"]));
            }
            set {
                this["resource_dir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string resource_img {
            get {
                return ((string)(this["resource_img"]));
            }
            set {
                this["resource_img"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool useNewUI {
            get {
                return ((bool)(this["useNewUI"]));
            }
            set {
                this["useNewUI"] = value;
            }
        }
    }
}
