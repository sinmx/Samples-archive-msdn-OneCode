﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Server.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Server.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No clients to connect the server..
        /// </summary>
        internal static string ConnectionMsg {
            get {
                return ResourceManager.GetString("ConnectionMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select a file to send..
        /// </summary>
        internal static string EmptyFilePathMsg {
            get {
                return ResourceManager.GetString("EmptyFilePathMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The port number is invalid..
        /// </summary>
        internal static string InvalidPortMsg {
            get {
                return ResourceManager.GetString("InvalidPortMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value can&apos;t be empty..
        /// </summary>
        internal static string IsEmptyStringMsg {
            get {
                return ResourceManager.GetString("IsEmptyStringMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must select one client to send the file at least. .
        /// </summary>
        internal static string SelectClientMsg {
            get {
                return ResourceManager.GetString("SelectClientMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server has been start successfully..
        /// </summary>
        internal static string StartupMsg {
            get {
                return ResourceManager.GetString("StartupMsg", resourceCulture);
            }
        }
    }
}
