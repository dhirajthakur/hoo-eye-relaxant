﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hoo.Relaxant.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int WorkingMinutes {
            get {
                return ((int)(this["WorkingMinutes"]));
            }
            set {
                this["WorkingMinutes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1234")]
        public string AdminPassword {
            get {
                return ((string)(this["AdminPassword"]));
            }
            set {
                this["AdminPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Free")]
        public global::Hoo.Relaxant.RestrictionLevels Resctriction4Configuration {
            get {
                return ((global::Hoo.Relaxant.RestrictionLevels)(this["Resctriction4Configuration"]));
            }
            set {
                this["Resctriction4Configuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Free")]
        public global::Hoo.Relaxant.RestrictionLevels Resctriction4TerminateBreaking {
            get {
                return ((global::Hoo.Relaxant.RestrictionLevels)(this["Resctriction4TerminateBreaking"]));
            }
            set {
                this["Resctriction4TerminateBreaking"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Password")]
        public global::Hoo.Relaxant.AdminModes AdminMode {
            get {
                return ((global::Hoo.Relaxant.AdminModes)(this["AdminMode"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int MaxDelayMinutes {
            get {
                return ((int)(this["MaxDelayMinutes"]));
            }
            set {
                this["MaxDelayMinutes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShutdownMonitor {
            get {
                return ((bool)(this["ShutdownMonitor"]));
            }
            set {
                this["ShutdownMonitor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int BreakingMinutes {
            get {
                return ((int)(this["BreakingMinutes"]));
            }
            set {
                this["BreakingMinutes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Free")]
        public global::Hoo.Relaxant.RestrictionLevels Resctriction4Quit {
            get {
                return ((global::Hoo.Relaxant.RestrictionLevels)(this["Resctriction4Quit"]));
            }
            set {
                this["Resctriction4Quit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string MusicFile {
            get {
                return ((string)(this["MusicFile"]));
            }
            set {
                this["MusicFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Sound4CompletingBreaking {
            get {
                return ((string)(this["Sound4CompletingBreaking"]));
            }
            set {
                this["Sound4CompletingBreaking"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Chinese (Simplified)")]
        public global::System.Globalization.CultureInfo Language {
            get {
                return ((global::System.Globalization.CultureInfo)(this["Language"]));
            }
            set {
                this["Language"] = value;
            }
        }
    }
}
