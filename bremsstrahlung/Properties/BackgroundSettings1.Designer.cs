﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bremsstrahlung.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.5.0.0")]
    internal sealed partial class BackgroundSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static BackgroundSettings defaultInstance = ((BackgroundSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new BackgroundSettings())));
        
        public static BackgroundSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("control_background_13_02_2018_COMP1.ats")]
        public string DefaultBackgroundName {
            get {
                return ((string)(this["DefaultBackgroundName"]));
            }
            set {
                this["DefaultBackgroundName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>D:\Работы\Ядерная физика\Лаб гамма_3\control_background_13_02_2018_COMP1.ats</string>
  <string>D:\Работы\Ядерная физика\Лаб гамма_3\control_background_13_02_2018_COMP2.ats</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection BackgroundPaths {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["BackgroundPaths"]));
            }
            set {
                this["BackgroundPaths"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>control_background_13_02_2018_COMP1.ats</string>
  <string>control_background_13_02_2018_COMP2.ats</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection BackgroundNames {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["BackgroundNames"]));
            }
            set {
                this["BackgroundNames"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\Работы\\Ядерная физика\\Лаб гамма_3\\control_background_13_02_2018_COMP1.ats")]
        public string DefaultBackgroundPath {
            get {
                return ((string)(this["DefaultBackgroundPath"]));
            }
            set {
                this["DefaultBackgroundPath"] = value;
            }
        }
    }
}
